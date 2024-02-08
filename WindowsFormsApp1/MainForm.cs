using Dark.Net;
using darknet_demo_winforms;
using Microsoft.VisualBasic.FileIO;
using NetDiscordRpc;
using NetDiscordRpc.Core.Logger;
using NetDiscordRpc.RPC;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


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
        private int _selectlength = 0;
        private int _selectlines = 0;
        private FileSaveChangeFlag _saveChangeFlag = FileSaveChangeFlag.NoChange;
        private string _currentFilePath = "";
        private MainFormContainer _container;
        #endregion

        #region Properties
        public static ToolStripProfessionalRenderer? ToolStripRender { get; set; }
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
                Console.Write(value);
                if (RPCShowFileName.Checked == true)
                {
                    if (string.IsNullOrEmpty(_currentFilePath))
                    {
                        DiscordRpc.UpdateDetails("Editing File: Unnamed");
                    }
                    else
                    {
                        DiscordRpc.UpdateDetails($"Editing File: {Path.GetFileName(value)}");
                    }
                }
                else
                {
                    DiscordRpc.UpdateDetails("Editing File");
                }
                DiscordRpc.UpdateTimestamps(new Timestamps() { Start = DateTime.UtcNow, });
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
        public (int Length, int Sum) SelectionInfo
        {
            get
            {
                return (_selectlength, _selectlines);
            }
            set
            {
                (_selectlength, _selectlines) = value;
                SelectionInfoText.Text = string.Format("Select Length: {0}, Select Lines: {1}", _selectlength, _selectlines);
            }
        }
        public bool WordWrap
        {
            get
            {
                return ConfigManager.Config.WordWrap;
            }
            set
            {
                ConfigManager.Config.WordWrap = value;
                EditingArea.WordWrap = value;
                ConfigManager.Config.WordWrap = value;
                WordWarpToggleMenuItem.Checked = value;
            }
        }

        public bool Status
        {
            get
            {
                return ConfigManager.Config.Status;
            }
            set
            {
                ConfigManager.Config.Status = value;
                BottomToolStrip.Visible = value;
                ConfigManager.Config.Status = value;
                StatusToggleMenuItem.Checked = value;
            }
        }

        public bool ShowLinks
        {
            get
            {
                return ConfigManager.Config.ShowLinks;
            }
            set
            {
                ConfigManager.Config.ShowLinks = value;
                EditingArea.DetectUrls = value;
                ConfigManager.Config.ShowLinks = value;
                ShowLinksToggleItem.Checked = value;
            }
        }

        public bool AutoSave
        {
            get
            {
                return ConfigManager.Config.AutoSave;
            }
            set
            {
                ConfigManager.Config.AutoSave = value;
                AutoSaveMenuItem.Checked = value;
            }
        }
        public bool DiscordRPC
        {
            get
            {
                return ConfigManager.Config.DiscordRPC;
            }
            set
            {
                ConfigManager.Config.DiscordRPC = value;
                RPCEnable.Checked = value;
                if (ConfigManager.Config.DiscordRPC == true)
                {
                    RPC();
                }
                else
                {
                    DiscordRpc.ClearPresence();
                }
            }
        }
        public bool showfileRPC
        {
            get
            {
                return ConfigManager.Config.RPCShowFileName;
            }
            set
            {
                ConfigManager.Config.RPCShowFileName = value;
                RPCShowFileName.Checked = value;
                if (RPCEnable.Checked)
                {
                    if (value)
                    {
                        if (string.IsNullOrEmpty(_currentFilePath))
                        {
                            DiscordRpc.UpdateDetails("Editing File: Unnamed");
                        }
                        else
                        {
                            DiscordRpc.UpdateDetails($"Editing File: {Path.GetFileName(_currentFilePath)}");
                        }
                    }
                    else
                    {
                        DiscordRpc.UpdateDetails("Editing File");
                    }
                }
            }
        }
        public bool ShowCharacterRPC
        {
            get
            {
                return ConfigManager.Config.RPCShowCharacters;
            }
            set
            {
                ConfigManager.Config.RPCShowCharacters = value;
                ShowCharacterCount.Checked = value;
                if (RPCEnable.Checked)
                {
                    if (value)
                    {
                        DiscordRpc.UpdateState($"{EditingArea.TextLength} characters");
                    }
                    else
                    {
                        DiscordRpc.UpdateState();
                    }
                }
            }
        }

        public static DiscordRPC DiscordRpc;
        #endregion

        #region Constructor
        static MainForm()
        {
            DiscordRpc = new DiscordRPC("1199263314107179071");
            DiscordRpc.Logger = new ConsoleLogger();
            DiscordRpc.Initialize();
        }

        public MainForm(MainFormContainer container)
        {
            InitializeComponent();
            _container = container;
            DarkNet.Instance.EffectiveCurrentProcessThemeIsDarkChanged += (_, isDarkTheme) => RenderTheme(isDarkTheme);
            RenderTheme(DarkNet.Instance.EffectiveCurrentProcessThemeIsDark);
            CursorPosInfo = (1, 1, 1);
            SelectionInfo = (0, 0);
            DocumentLengthInfo = (0, 0);
            Zoom = 1;
            WordWrap = ConfigManager.Config.WordWrap;
            Status = ConfigManager.Config.Status;
            ShowLinks = ConfigManager.Config.ShowLinks;
            AutoSave = ConfigManager.Config.AutoSave;
            DiscordRPC = ConfigManager.Config.DiscordRPC;
            showfileRPC = ConfigManager.Config.RPCShowFileName;
            ShowCharacterRPC = ConfigManager.Config.RPCShowCharacters;

            EditingArea.MouseWheel += new MouseEventHandler(EditingArea_MouseWheelEvent);
            ActionUndoMenuItem.Enabled = false;
            undoToolStripMenuItem1.Enabled = false;
            ActionRedoMenuItem.Enabled = false;
            redoToolStripMenuItem1.Enabled = false;

            bool isFilePathEmpty = string.IsNullOrEmpty(CurrentFilePath);
            OpenFileFolderSubMenu.Enabled = isFilePathEmpty;
            ReOpenMenuItem.Enabled = isFilePathEmpty;
            OpenInMSNotepadMenuItem.Enabled = isFilePathEmpty;
            DeleteFileSubMenu.Enabled = isFilePathEmpty;
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
            DeleteFileSubMenu.Enabled = false;
            OpenFileFolderSubMenu.Enabled = false;
            CopyToClipboardSubMenu.Enabled = false;
            this.FormClosed += (_, _2) => _container.OnCloseFormChecking(this);

            SetTitle();

            IDarkNet darkNet = DarkNet.Instance;
            if (ConfigManager.IsFirstLaunch)
            {
                ConfigManager.Config.DarkMode = "auto";
                autotheme();
                AutoSub.Checked = true;
            }
            else
            {
                if (ConfigManager.Config.DarkMode == "auto")
                {
                    autotheme();
                    AutoSub.Checked = true;
                }
                else
                {
                    DarkModeSetting(ConfigManager.Config.DarkMode);
                    if (ConfigManager.Config.DarkMode == "dark")
                    {
                        darkModeSub.Checked = true;
                    }
                    else
                    {
                        lightModeSub.Checked = true;
                    }
                }
            };
            darkNet.UserDefaultAppThemeIsDarkChanged += (_, isSystemDarkTheme) => { autotheme(); };
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
        private void updateRPC()
        {
            if (ShowCharacterCount.Checked)
            {
                DiscordRpc.UpdateState($"{EditingArea.TextLength} characters");
            }
            else
            {
                DiscordRpc.UpdateState();
            }
        }
        private void RenderTheme(bool isDarkTheme)
        {
            BackColor = isDarkTheme ? Color.FromArgb(19, 19, 19) : Color.White;
            ForeColor = isDarkTheme ? Color.White : Color.Black;
        }

        private void DarkModeSetting(string mode)
        {
            // 調整dark mode: ConfigManager.Config.DarkMode = true/false
            // 然後呼叫 DarkModeSetting(), ok?
            // 舉個例子 line 897 DisableDarkMode_Click()
            if (mode == "dark")
            {
                Theme theme = Theme.Dark;
                DarkNet.Instance.SetCurrentProcessTheme(theme, Program.ThemeOptions);
                ThemeHelper.ChangeControlTheme(this, ThemeHelper.DarkDefault, new ToolStripProfessionalRenderer(new DarkToolStripItemColors()));
                ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
            }
            else if (mode == "light")
            {
                Theme theme = Theme.Light;
                DarkNet.Instance.SetCurrentProcessTheme(theme, Program.ThemeOptions);
                ThemeHelper.ChangeControlTheme(this, ThemeHelper.WhiteDefault, null);
                ToolStripRender = null;
                ToolStripManager.Renderer = null;
            }
            else
            {
                Theme theme = Theme.Auto;
                DarkNet.Instance.SetCurrentProcessTheme(theme, Program.ThemeOptions);
            }
        }

        private void autotheme()
        {
            IDarkNet darkNet = DarkNet.Instance;
            if (ConfigManager.Config.DarkMode == "auto")
            {
                if ((darkNet.UserDefaultAppThemeIsDark ? "Dark" : "Light") == "Dark")
                {
                    DarkModeSetting("dark");
                }
                else
                {
                    DarkModeSetting("light");
                }
                DarkModeSetting("auto");
            }
        }

        public void RPC()
        {

            DiscordRpc.SetPresence(new RichPresence()
            {

                Details = "Editing File: " + (string.IsNullOrEmpty(CurrentFilePath) ? "Unnamed" : Path.GetFileName(CurrentFilePath)),
                State = $"{EditingArea.TextLength} characters",

                Assets = new Assets()
                {
                    LargeImageKey = "notepadfull",
                    LargeImageText = "Notepad--",
                    SmallImageKey = "oig4_-_",
                    SmallImageText = "OWO"
                },

                Timestamps = Timestamps.Now,

                Buttons = new NetDiscordRpc.RPC.Button[]
                {
                new() { Label = "Notepad-- Github", Url = "https://github.com/syesjohnny/notepad-minus-minus" }
                }
            });

            DiscordRpc.Invoke();
            if (!ShowCharacterCount.Checked)
            {
                DiscordRpc.UpdateState();
            }
            if (!RPCShowFileName.Checked)
            {
                DiscordRpc.UpdateDetails("Editing File");
            }
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
                OpenFileFolderSubMenu.Enabled = true;
                ReOpenMenuItem.Enabled = true;
                OpenInMSNotepadMenuItem.Enabled = true;
                DeleteFileSubMenu.Enabled = true;
                CopyToClipboardSubMenu.Enabled = true;
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
                updateRPC();
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
                        OpenFileFolderSubMenu.Enabled = true;
                        ReOpenMenuItem.Enabled = true;
                        OpenInMSNotepadMenuItem.Enabled = true;
                        DeleteFileSubMenu.Enabled = true;
                        CopyToClipboardSubMenu.Enabled = true;
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
            updateRPC();
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
            updateRPC();
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
            updateRPC();

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
            if (Control.ModifierKeys == Keys.Control)
            {
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
                    if (AutoSaveMenuItem.Checked == true)
                    {
                        SaveFile();
                        SaveChangeFlag = FileSaveChangeFlag.NoChange;
                    }
                    else
                    {
                        SaveChangeFlag = FileSaveChangeFlag.Changed;
                    }
                }
            }
            ActionUndoMenuItem.Enabled = EditingArea.CanUndo;
            undoToolStripMenuItem1.Enabled = EditingArea.CanUndo;
            ActionRedoMenuItem.Enabled = EditingArea.CanRedo;
            redoToolStripMenuItem1.Enabled = EditingArea.CanRedo;
            bool isPathEmpty = string.IsNullOrEmpty(CurrentFilePath);
            OpenFileFolderSubMenu.Enabled = !isPathEmpty;
            ReOpenMenuItem.Enabled = !isPathEmpty;
            OpenInMSNotepadMenuItem.Enabled = !isPathEmpty;
            DeleteFileSubMenu.Enabled = !isPathEmpty;
            CopyToClipboardSubMenu.Enabled = !isPathEmpty;
            ActionPasteMenuItem.Enabled = Clipboard.ContainsText() == true;
            pasteToolStripMenuItem1.Enabled = Clipboard.ContainsText() == true;
            updateRPC();
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
            SelectionInfo = (EditingArea.SelectionLength, 1);
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
            DarkNet.Instance.SetWindowThemeForms(findReplace, Theme.Auto);
            findReplace.Show();
        }
        private void InsertDateTime(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = $"{GetPeriod(now)} {now:hh:mm tt yyyy/M/d}";
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
            float previousFontSize = EditingArea.ZoomFactor; // !!!!
            WordWrap = !WordWrap;
            EditingArea.ZoomFactor = previousFontSize; // !!!
        }
        private void ToggleStatus(object sender, EventArgs e)
        {
            Status = !Status;
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
            ShowLinks = !ShowLinks;
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
            MainForm newForm = new(_container);
            DarkNet.Instance.SetWindowThemeForms(newForm, Theme.Auto);
            _container.AddNewForm(newForm);
            newForm.Show();
        }
        private void GoToMenuItem_Click(object sender, EventArgs e)
        {
            Goto Goto = new(this)
            {
                Owner = this
            };
            DarkNet.Instance.SetWindowThemeForms(Goto, Theme.Auto);
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
            DarkNet.Instance.SetWindowThemeForms(Run, Theme.Auto);
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

        #region Line operations
        private void DuplicateLineMenuItem_Click(object sender, EventArgs e)
        {
            int currentLine = EditingArea.GetLineFromCharIndex(EditingArea.SelectionStart);
            int lineCharIndex = EditingArea.SelectionStart;
            string[] lines = EditingArea.Lines;
            string[] newLines = new string[lines.Length + 1];
            for (int i = 0; i < newLines.Length; i++)
            {
                if (i == currentLine) lineCharIndex += lines[i].Length + 1;
                if (i > currentLine)
                {
                    newLines[i] = lines[i - 1];
                    continue;
                }
                newLines[i] = lines[i];
            }
            EditingArea.Lines = newLines;
            EditingArea.SelectionStart = lineCharIndex;
        }

        private void removeDuplicateLinesMenuItem_Click(object sender, EventArgs e)
        {
            EditingArea.Text = string.Join(Environment.NewLine, EditingArea.Lines.Distinct());
            EditingArea.Font = new System.Drawing.Font("Calibri", 12, System.Drawing.FontStyle.Regular);
        }
        #endregion
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences Preferences = new(this);
            DarkNet.Instance.SetWindowThemeForms(Preferences, Theme.Auto);
            Preferences.Show();
        }

        private void EnableDarkMode_Click(object sender, EventArgs e)
        {
            darkModeSub.Checked = true;
            lightModeSub.Checked = false;
            AutoSub.Checked = false;
            ConfigManager.Config.DarkMode = "dark";
            DarkModeSetting("dark");
        }

        private void DisableDarkMode_Click(object sender, EventArgs e)
        {
            darkModeSub.Checked = false;
            lightModeSub.Checked = true;
            AutoSub.Checked = false;
            ConfigManager.Config.DarkMode = "light";
            DarkModeSetting("light");
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darkModeSub.Checked = false;
            lightModeSub.Checked = false;
            AutoSub.Checked = true;
            ConfigManager.Config.DarkMode = "auto";
            autotheme();
        }

        private void autoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoSave = !AutoSave;
            if (AutoSaveMenuItem.Checked = true && !(string.IsNullOrEmpty(CurrentFilePath)))
            {
                SaveFile();
            }
        }

        private void RPCEnable_Click(object sender, EventArgs e)
        {
            DiscordRPC = !DiscordRPC;
        }

        private void RPCShowFileName_Click(object sender, EventArgs e)
        {
            showfileRPC = !showfileRPC;
        }

        private void ShowCharacterCount_Click(object sender, EventArgs e)
        {
            ShowCharacterRPC = !ShowCharacterRPC;
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            About About = new();
            DarkNet.Instance.SetWindowThemeForms(About, Theme.Auto);
            About.Show();
        }

        private void WhatNewMenuItem_Click(object sender, EventArgs e)
        {
            What_s_New What_s_New = new();
            DarkNet.Instance.SetWindowThemeForms(What_s_New, Theme.Auto);
            What_s_New.Show();
        }
    }
    public class CustomColorTable : ProfessionalColorTable
	{
		public override Color ImageMarginGradientBegin
		{
			get
			{
				return Color.FromArgb(39, 39, 39);
			}
		}

		public override Color ImageMarginGradientMiddle
		{
			get
			{
				return Color.FromArgb(39, 39, 39);
			}
		}

		public override Color ImageMarginGradientEnd
		{
			get
			{
				return Color.FromArgb(39, 39, 39);
			}
		}

		public override Color ToolStripDropDownBackground
		{
			get
			{
				return Color.FromArgb(39, 39, 39);
			}
		}
	}
}
