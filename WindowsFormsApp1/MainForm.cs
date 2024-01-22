using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;


namespace NotePadMinusMinus
{
	public enum FileSaveChangeFlag
	{
		NoChange,
		Changed
	}
	public enum CloseMode
	{
		CloseAll,
		CloseThisWindow
	}
    public partial class MainForm : Form
    {
        #region BackendFields
        private float _zoom = 1;
        private int _length = 0;
        private int _lineCount = 0;
        private int _atLine = 0;
        private int _atColumn = 0;
        private int _atChar = 0;
        private FileSaveChangeFlag _saveChangeFlag = FileSaveChangeFlag.NoChange;
        private string _currentFilePath = "";
        #endregion

        #region Properties
        private FormWindowState PreviousWindowState { get; set; }
        public CloseMode AppCloseMode { get; set; } = CloseMode.CloseAll;
        public string CurrentFilePath
        {
            get
            {
                return _currentFilePath;
            }
            set
            {
                _currentFilePath = value;
                SetTitle();
            }
        }
        public FileSaveChangeFlag SaveChangeFlag
        {
            get
            {
                return _saveChangeFlag;
            }
            set
            {
                _saveChangeFlag = value;
                SetTitle();
            }
        }
        public float Zoom
        {
            get
            {
                return _zoom;
            }
            set
            {
                _zoom = value;
                ZoomInfoText.Text = string.Format("{0:N0}%", value * 100);
            }
        }
        public (int Length, int LineCount) DocumentLengthInfo
        {
            get
            {
                return (_length, _lineCount);
            }
            set
            {
                (_length, _lineCount) = value;
                DocInfoText.Text = string.Format("Length: {0}, Lines: {1}", _length, _lineCount);
            }
        }
        public (int Line, int Column, int Position) CursorPosInfo
        {
            get
            {
                return (_atLine, _atColumn, _atChar);
            }
            set
            {
                (_atLine, _atColumn, _atChar) = value;
                CursorPosInfoText.Text = string.Format("Ln: {0}, Col: {1}, Pos: {2}", _atLine, _atColumn, _atChar);
            }
        }
        #endregion

        #region Constructor
        public MainForm()
        {

            InitializeComponent();
            CursorPosInfo = (1, 1, 1);
            DocumentLengthInfo = (0, 0);
            Zoom = 1;
            EditingArea.WordWrap = true;
            EditingArea.MouseWheel += new MouseEventHandler(EditingArea_MouseWheelEvent);
            ActionUndoMenuItem.Enabled = false;
            undoToolStripMenuItem1.Enabled = false;
            ActionRedoMenuItem.Enabled = false;
            redoToolStripMenuItem1.Enabled = false;

            bool isFilePathEmpty = string.IsNullOrEmpty(CurrentFilePath);
            CopyDirectoryWithFileMenuItem.Enabled = isFilePathEmpty;
            CopyFileMenuItem.Enabled = isFilePathEmpty;
            CopyDirectoryOnlyMenuItem.Enabled = isFilePathEmpty;
            OpenFileFolderSubMenu.Enabled = isFilePathEmpty;
            CopyToClipboardSubMenu.Enabled = isFilePathEmpty;

            ActionPasteMenuItem.Enabled = Clipboard.ContainsText();
            pasteToolStripMenuItem1.Enabled = Clipboard.ContainsText();
            ActionCopyMenuItem.Enabled = false;
            copyToolStripMenuItem1.Enabled = false;
            ActionDeleteMenuItem.Enabled = false;
            deleteToolStripMenuItem1.Enabled = false;
            ActionCutMenuItem.Enabled = false;
            cutToolStripMenuItem1.Enabled = false;
            ReOpenMenuItem.Enabled = false;
            OpenInMSNotepadMenuItem.Enabled = false;

            SetTitle();
        }
        #endregion

        #region Misc
        private void SetTitle()
        {
            bool isEmpty = string.IsNullOrEmpty(CurrentFilePath);
            this.Text = string.Format(
                "{0}{1} {2}{3}{4}",
                SaveChangeFlag == FileSaveChangeFlag.NoChange ? "" : "*",
                isEmpty ? "Unnamed" : Path.GetFileName(CurrentFilePath),
                isEmpty ? "" : "(",
                CurrentFilePath,
                isEmpty ? "" : ")"
            );
        }
        #endregion

        #region File operations
        private void NewFileEvent(object sender, EventArgs e)
        {
            if (SaveChangeFlag == FileSaveChangeFlag.Changed)
                if (!string.IsNullOrEmpty(EditingArea.Text) && (string.IsNullOrEmpty(CurrentFilePath) || File.Exists(CurrentFilePath)))
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        SaveFile();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // User clicked Cancel, do nothing
                        return;
                    }
                }

            // Reset the CurrentFilePath and clear the RichTextBox
            CurrentFilePath = "";
            EditingArea.Clear();
        }
        private void SaveFileEvent(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveAsEvent(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                CurrentFilePath = saveFileDialog.FileName;
                EditingArea.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                SaveChangeFlag = 0;
                CopyDirectoryWithFileMenuItem.Enabled = (CurrentFilePath != "");
                CopyFileMenuItem.Enabled = (CurrentFilePath != "");
                CopyDirectoryOnlyMenuItem.Enabled = (CurrentFilePath != "");
            }
        }
        private void OpenFileEvent(object sender, EventArgs e)
        {
            if (SaveChangeFlag == FileSaveChangeFlag.Changed)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }

            }
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = openFileDialog.FileName;
                EditingArea.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                int charCount = EditingArea.TextLength;
                int lineCount = EditingArea.Lines.Length;
                DocumentLengthInfo = (charCount, lineCount);
            }
        }
        private bool SaveFile()
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                SaveFileDialog saveFileDialog = new()
                {
                    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                    Title = "Save File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentFilePath = saveFileDialog.FileName;
                    using (StreamWriter streamWriter = new(CurrentFilePath))
                    {
                        streamWriter.Write(EditingArea.Text);
                        SaveChangeFlag = 0;
                        CopyDirectoryWithFileMenuItem.Enabled = (CurrentFilePath != "");
                        CopyFileMenuItem.Enabled = (CurrentFilePath != "");
                        CopyDirectoryOnlyMenuItem.Enabled = (CurrentFilePath != "");

                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                using (StreamWriter streamWriter = new(CurrentFilePath))
                {
                    streamWriter.Write(EditingArea.Text);
                    SaveChangeFlag = 0;
                }
            }
            return true;
        }
        private void OpenInMSNotepadMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = CurrentFilePath,
                UseShellExecute = true
            });
        }
        private void DeletePermanentlyMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Really? You can't get back your file after you delete it", "Warning", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                File.Delete(CurrentFilePath);
            }
            EditingArea.Text = "";
            CurrentFilePath = "";
            int charCount = EditingArea.TextLength;
            int lineCount = EditingArea.Lines.Length;
            DocumentLengthInfo = (charCount, lineCount);
        }
        private void RemoveFileMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Really?", "Warning", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                FileSystem.DeleteFile(CurrentFilePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            }
            EditingArea.Text = "";
            CurrentFilePath = "";
            int charCount = EditingArea.TextLength;
            int lineCount = EditingArea.Lines.Length;
            DocumentLengthInfo = (charCount, lineCount);
        }
        private void OpenInExplorer(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CurrentFilePath) && File.Exists(CurrentFilePath))
            {
                string folderPath = Path.GetDirectoryName(CurrentFilePath);
                Process.Start("explorer.exe", folderPath);
            }
        }
        private void OpenInCMD(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CurrentFilePath) && File.Exists(CurrentFilePath))
            {
                // Get the directory containing the current file
                string folderPath = Path.GetDirectoryName(CurrentFilePath);

                // Open a new Command Prompt window and set its current directory
                Process.Start("cmd", $"/k cd /d \"{folderPath}\"");
            }
        }
        private void ReOpenMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveChangeFlag == FileSaveChangeFlag.Changed)
            {
                if (!string.IsNullOrEmpty(EditingArea.Text) && (string.IsNullOrEmpty(CurrentFilePath) || File.Exists(CurrentFilePath)))
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Warning", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        SaveFile();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // User clicked Cancel, do nothing
                        return;
                    }
                }
            }
            EditingArea.LoadFile(CurrentFilePath, RichTextBoxStreamType.PlainText);
            int charCount = EditingArea.TextLength;
            int lineCount = EditingArea.Lines.Length;
            DocumentLengthInfo = (charCount, lineCount);


        }
        #endregion

        #region Exiting
        private void ExitEvent(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void CloseWindowEvent(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExitConfirm(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(EditingArea.Text))
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before exiting?", "Warning", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    if (!SaveFile())
                    {
                        e.Cancel = true;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        #endregion

        #region Editing area events
        private void EditingArea_MouseWheelEvent(object sender, MouseEventArgs e)
        {
            // Handle the MouseWheel event here
            if (Control.ModifierKeys == Keys.Control)
            {
                // Ctrl key is pressed while scrolling
                Zoom = EditingArea.ZoomFactor;
            }
        }
        private void OnEditingAreaTextChange(object sender, EventArgs e)
        {
            if (CurrentFilePath == "")
            {
                if (EditingArea.Text == "")
                {
                    SaveChangeFlag = FileSaveChangeFlag.NoChange;
                }
                else
                {
                    SaveChangeFlag = FileSaveChangeFlag.Changed;
                }
            }
            else
            {
                if (EditingArea.Text == File.ReadAllText(CurrentFilePath))
                {
                    SaveChangeFlag = FileSaveChangeFlag.NoChange;
                }
                else
                {
                    SaveChangeFlag = FileSaveChangeFlag.Changed;
                }
            }
            ActionUndoMenuItem.Enabled = EditingArea.CanUndo;
            undoToolStripMenuItem1.Enabled = EditingArea.CanUndo;
            ActionRedoMenuItem.Enabled = EditingArea.CanRedo;
            redoToolStripMenuItem1.Enabled = EditingArea.CanRedo;
            bool isPathEmpty = string.IsNullOrEmpty(CurrentFilePath);
            ReOpenMenuItem.Enabled = isPathEmpty;
            OpenInMSNotepadMenuItem.Enabled = isPathEmpty;
            //change change change change change change change change change change change
            // ^ ???
            CopyDirectoryWithFileMenuItem.Enabled = isPathEmpty;
            CopyFileMenuItem.Enabled = isPathEmpty;
            CopyDirectoryOnlyMenuItem.Enabled = isPathEmpty;
            OpenFileFolderSubMenu.Enabled = isPathEmpty;
            CopyToClipboardSubMenu.Enabled = isPathEmpty;
            ActionPasteMenuItem.Enabled = Clipboard.ContainsText() == true;
            pasteToolStripMenuItem1.Enabled = Clipboard.ContainsText() == true;
        }
        private void EditingAreaOnSelectionChange(object sender, EventArgs e)
        {
            int charCounter = 0;
            int lineCounter = 0;
            int lineNowLength = 0;
            char[] texts = EditingArea.Text.ToCharArray();

            for (int i = 0; i < texts.Length && i < EditingArea.SelectionStart; i++)
            {
                charCounter++;
                lineNowLength++;
                char charAt = texts[i];
                if (charAt == '\n')
                {
                    lineCounter++;
                    lineNowLength = 0;
                }
            }

            CursorPosInfo = (++lineCounter, ++lineNowLength, EditingArea.SelectionStart + 1);
            DocumentLengthInfo = (EditingArea.TextLength, EditingArea.Lines.Length);
            if (EditingArea.SelectionLength > 0)
            {
                ActionCopyMenuItem.Enabled = true;
                copyToolStripMenuItem1.Enabled = true;
                ActionDeleteMenuItem.Enabled = true;
                deleteToolStripMenuItem1.Enabled = true;
                ActionCutMenuItem.Enabled = true;
                cutToolStripMenuItem1.Enabled = true;

            }
            else
            {
                ActionCopyMenuItem.Enabled = false;
                copyToolStripMenuItem1.Enabled = false;
                ActionDeleteMenuItem.Enabled = false;
                deleteToolStripMenuItem1.Enabled = false;
                ActionCutMenuItem.Enabled = false;
                cutToolStripMenuItem1.Enabled = false;
            }
        }
        private void OpenLink(object sender, LinkClickedEventArgs e)
        {
            if (EditingArea.DetectUrls)
            {
                var ps = new ProcessStartInfo(e.LinkText)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
        }
        #endregion

        #region Editing actions
        private void UndoMenuItem_Click(object sender, EventArgs e) => EditingArea.Undo();
        private void RedoMenuItem_Click(object sender, EventArgs e) => EditingArea.Redo();
        private void CutMenuItem_Click(object sender, EventArgs e) => EditingArea.Cut();
        private void CopyMenuItem_Click(object sender, EventArgs e) => EditingArea.Copy();
        private void PasteMenuItem_Click(object sender, EventArgs e) => EditingArea.Paste();
        private void DeleteMenuItem_Click(object sender, EventArgs e) => EditingArea.SelectedText = "";
        private void SelectMenuItem_Click(object sender, EventArgs e) => EditingArea.SelectAll();

        private void FindReplaceMenuItem_Click(object sender, EventArgs e)
        {
            FindReplace findReplace = new(this);
            findReplace.Show();
        }
        private void InsertDateTime(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // 格式化日期和時間字串
            string formattedDateTime = $"{GetPeriod(now)} {now:hh:mm tt yyyy/M/d}";

            // 插入到 RichTextBox 中
            EditingArea.SelectedText = formattedDateTime;
        }

        private static string GetPeriod(DateTime dateTime)
        {
            return dateTime.Hour >= 12 ? "P.M." : "A.M.";
        }
        private void CopyDirectoryPath(object sender, EventArgs e)
        {
            Clipboard.SetText(Path.GetDirectoryName(CurrentFilePath));
        }
        #endregion

        #region View operations
        private void ToggleWordWarp(object sender, EventArgs e)
        {
            float previousFontSize = EditingArea.ZoomFactor; // ????
            EditingArea.WordWrap = !EditingArea.WordWrap;
            EditingArea.ZoomFactor = previousFontSize; // ???
        }
        private void ToggleStatus(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }
        private void ToggleFullScreen(object _, EventArgs _1)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                // Switch back to normal mode
                this.WindowState = PreviousWindowState; // Restore the previous window state
                this.FormBorderStyle = FormBorderStyle.Sizable; // Restore window borders
                FullScreenToggleMenuItem.Checked = false;
            }
            else
            {
                // Switch to full-screen mode
                PreviousWindowState = this.WindowState; // Store the previous window state
                this.FormBorderStyle = FormBorderStyle.None; // Hide window borders
                this.WindowState = FormWindowState.Maximized; // Set directly to maximize
                FullScreenToggleMenuItem.Checked = true;
            }
        }
        private void ToggleAlwaysOnTop(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }
        private void ToggleShowLinks(object sender, EventArgs e)
        {
            EditingArea.DetectUrls = !EditingArea.DetectUrls;
        }
        private void ToggleReadOnlyMode(object sender, EventArgs e)
        {
            EditingArea.ReadOnly = !EditingArea.ReadOnly;
        }

        private void ExitFullscreen(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && FullScreenToggleMenuItem.Checked == true)
            {
                ToggleFullScreen(null, null);
            }
        }

        private void ZoomIn(object sender, EventArgs e)
        {
            if (EditingArea.ZoomFactor < 4.95)
            {
                EditingArea.ZoomFactor += 0.1f;
            }
            Zoom = EditingArea.ZoomFactor;
        }
        private void ZoomOut(object sender, EventArgs e)
        {
            if (EditingArea.ZoomFactor > 0.1)
            {
                if (EditingArea.ZoomFactor < 0.2)
                {
                    EditingArea.ZoomFactor = 0.1f;
                }
                else
                {
                    EditingArea.ZoomFactor -= 0.1f;
                }
            }
            Zoom = EditingArea.ZoomFactor;
        }
        private void ResetZoom(object sender, EventArgs e)
        {
            EditingArea.ZoomFactor = 1f;
            Zoom = EditingArea.ZoomFactor;
        }
        #endregion

        #region Windows
        private void OpenNewWindow(object sender, EventArgs e)
        {
            MainForm newForm = new();
            newForm.Show();
        }
        private void GoToMenuItem_Click(object sender, EventArgs e)
        {
            Goto Goto = new(this)
            {
                Owner = this
            };
            Goto.Show();
        }
        private void GetPHPHelpMenuItem_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://www.php.net/" + EditingArea.SelectedText)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        private void SearchInWikipediaMenuItem_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://.wikipedia.org/wiki/Special:Search?search=" + EditingArea.SelectedText)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        private void SearchInWebsiteMenuItem_Click(object sender, EventArgs e)
        {
            string linkText;
            if (EditingArea.SelectedText == "")
            { // why use a field when local variable is already applicable
                linkText = EditingArea.Lines[EditingArea.GetLineFromCharIndex(EditingArea.SelectionStart)];
            }
            else
            {
                linkText = EditingArea.SelectedText;
            }
            var ps = new ProcessStartInfo("https://www.google.com/search?q=" + linkText)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        private void RunMenuItem_Click(object sender, EventArgs e)
        {
            Run Run = new()
            {
                Owner = this
            };
            Run.Show();
        }
        #endregion

        #region Case operations
        private void UpperCaseMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = EditingArea.SelectionStart;
            int selectionLength = EditingArea.SelectionLength;
            EditingArea.SelectedText = EditingArea.SelectedText.ToUpper();
            EditingArea.Select(selectionStart, selectionLength);

        }
        private void LowerCaseMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = EditingArea.SelectionStart;
            int selectionLength = EditingArea.SelectionLength;
            EditingArea.SelectedText = EditingArea.SelectedText.ToLower();
            EditingArea.Select(selectionStart, selectionLength);
        }
        private void InvertCaseMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = EditingArea.SelectionStart;
            int selectionLength = EditingArea.SelectionLength;
            EditingArea.SelectedText = string.Concat(
                EditingArea.SelectedText.Select(
                    x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)
                )
            );
            EditingArea.Select(selectionStart, selectionLength);
        }
        private void RandomCaseMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = EditingArea.SelectionStart;
            int selectionLength = EditingArea.SelectionLength;
            StringBuilder sb = new();
            Random random = new();
            foreach (char c in EditingArea.SelectedText)
            {
                sb.Append(random.Next(2) == 1 ? char.ToUpper(c) : char.ToLower(c));
            }
            EditingArea.SelectedText = sb.ToString();
            EditingArea.Select(selectionStart, selectionLength);
        }
        private void ProperCaseMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = EditingArea.SelectionStart;
            int selectionLength = EditingArea.SelectionLength;
            TextInfo textInfo = new CultureInfo("en-US", true).TextInfo;
            EditingArea.SelectedText = textInfo.ToTitleCase(EditingArea.SelectedText.ToLower());
            EditingArea.Select(selectionStart, selectionLength);

        }
        private void ProperCaseBlendMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = EditingArea.SelectionStart;
            int selectionLength = EditingArea.SelectionLength;
            string selectedParsed = EditingArea.SelectedText;
            StringBuilder builder = new();
            for (int i = 0; i < selectedParsed.Length; i++)
            {
                char now = selectedParsed[i];
                char last = selectedParsed[Math.Max(0, i - 1)];
                if (char.IsWhiteSpace(last) || i == 0)
                {
                    builder.Append(char.ToUpper(now));
                    continue;
                }
                builder.Append(now);
            }
            EditingArea.SelectedText = builder.ToString();
            EditingArea.Select(selectionStart, selectionLength);
        }
        private void SentenceCaseMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = EditingArea.SelectionStart;
            int selectionLength = EditingArea.SelectionLength;
            string selectedParsed = EditingArea.SelectedText;
            StringBuilder builder = new();
            bool isFirstUpper = false;
            for (int i = 0; i < selectedParsed.Length; i++)
            {
                char last = selectedParsed[Math.Max(0, i - 1)];
                char now = char.ToLower(selectedParsed[i]);
                char next = selectedParsed[Math.Min(selectedParsed.Length - 1, i + 1)];
                if (((char.IsWhiteSpace(next) || next == '\'') && char.IsWhiteSpace(last)) || !isFirstUpper)
                {
                    builder.Append(char.ToUpper(now));
                    if (!char.IsWhiteSpace(now)) isFirstUpper = true;
                }
                else builder.Append(now);

                if (now == '.' || now == '?' || now == '!') isFirstUpper = false;
            }
            EditingArea.SelectedText = builder.ToString();
            EditingArea.Select(selectionStart, selectionLength);
        }
        private void SentenceCaseBlendMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = EditingArea.SelectionStart;
            int selectionLength = EditingArea.SelectionLength;
            string selectedParsed = EditingArea.SelectedText;
            StringBuilder builder = new();
            bool isFirstUpper = false;
            for (int i = 0; i < selectedParsed.Length; i++)
            {
                char last = selectedParsed[Math.Max(0, i - 1)];
                char now = selectedParsed[i];
                char next = selectedParsed[Math.Min(selectedParsed.Length - 1, i + 1)];
                if (((char.IsWhiteSpace(next) || next == '\'') && char.IsWhiteSpace(last)) || !isFirstUpper)
                {
                    builder.Append(char.ToUpper(now));
                    if (!char.IsWhiteSpace(now)) isFirstUpper = true;
                }
                else builder.Append(now);

                if (now == '.' || now == '?' || now == '!') isFirstUpper = false;
            }
            EditingArea.SelectedText = builder.ToString();
            EditingArea.Select(selectionStart, selectionLength);
        }
        #endregion

        private void DuplicateLineMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
