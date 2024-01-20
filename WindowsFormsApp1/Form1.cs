using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        public static string currentFilePath = "";
        private int saveChangeFlag = 0;
        private float currentFontSize = 0;
        private FormWindowState previousWindowState;
        private int horizontalScrollPosition = 0;
        private bool showLink = false;
        private string linktext = "";
        private int exitapp = 0;
        public Form1()
        {

            InitializeComponent();
            toolStripLabel1.Text = "Ln: 1, Col: 1, Pos: 1";
            toolStripLabel3.Text = "Length: 0, Lines: 0";
            toolStripLabel2.Text = "100%";
            richTextBox1.WordWrap = true;
            richTextBox1.MouseWheel += new MouseEventHandler(richTextBox1_MouseWheel);
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem1.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem1.Enabled = false;
            directoryWithFileToolStripMenuItem.Enabled = (currentFilePath != "");
            fileToolStripMenuItem1.Enabled = (currentFilePath != "");
            directoryToolStripMenuItem.Enabled = (currentFilePath != "");
            openFileFolderToolStripMenuItem.Enabled = (currentFilePath != "");
            copyToCliboardToolStripMenuItem.Enabled = (currentFilePath != "");

            pasteToolStripMenuItem.Enabled = (Clipboard.ContainsText() == true);
            pasteToolStripMenuItem1.Enabled = (Clipboard.ContainsText() == true);
            copyToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem1.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem1.Enabled = false;
            cutToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem1.Enabled = false;
            reopenToolStripMenuItem.Enabled = false;
            openInDeafultNotepadToolStripMenuItem.Enabled = false;


            this.Text = "Unnamed";


        }
        private void richTextBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            // Handle the MouseWheel event here
            if (Control.ModifierKeys == Keys.Control)
            {
                // Ctrl key is pressed while scrolling
                toolStripLabel2.Text = $"{(int)(richTextBox1.ZoomFactor * 100)}%";
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveChangeFlag == 1)
                if (!string.IsNullOrEmpty(richTextBox1.Text) && (string.IsNullOrEmpty(currentFilePath) || File.Exists(currentFilePath)))
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

            // Reset the currentFilePath and clear the RichTextBox
            currentFilePath = "";
            richTextBox1.Clear();
            this.Text = "Unnamed";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                saveChangeFlag = 0;
                directoryWithFileToolStripMenuItem.Enabled = (currentFilePath != "");
                fileToolStripMenuItem1.Enabled = (currentFilePath != "");
                directoryToolStripMenuItem.Enabled = (currentFilePath != "");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveChangeFlag == 1)
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                this.Text = Path.GetFileName(currentFilePath) + " (" + currentFilePath + ")";
                int charCount = richTextBox1.TextLength;
                int lineCount = richTextBox1.Lines.Length;
                toolStripLabel3.Text = $"Length: {charCount}, Lines: {lineCount}";
            }
        }

        private bool SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    using (StreamWriter streamWriter = new StreamWriter(currentFilePath))
                    {
                        streamWriter.Write(richTextBox1.Text);
                        saveChangeFlag = 0;
                        this.Text = Path.GetFileName(saveFileDialog.FileName) + " (" + saveFileDialog.FileName + ")";
                        directoryWithFileToolStripMenuItem.Enabled = (currentFilePath != "");
                        fileToolStripMenuItem1.Enabled = (currentFilePath != "");
                        directoryToolStripMenuItem.Enabled = (currentFilePath != "");

                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(currentFilePath))
                {
                    streamWriter.Write(richTextBox1.Text);
                    saveChangeFlag = 0;
                    this.Text = Path.GetFileName(currentFilePath) + " (" + currentFilePath + ")";
                }
            }
            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitapp = 1;
            this.Close();
        }
        private void exitconfirm(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
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

        private void savechange(object sender, EventArgs e)
        {
            if (currentFilePath == "")
            {
                if (richTextBox1.Text == "")
                {
                    saveChangeFlag = 0;
                }
                else
                {
                    saveChangeFlag = 1;
                }
            }
            else
            {
                if (richTextBox1.Text == File.ReadAllText(currentFilePath))
                {
                    saveChangeFlag = 0;
                }
                else
                {
                    saveChangeFlag = 1;
                }
            }
            undoToolStripMenuItem.Enabled = richTextBox1.CanUndo;
            undoToolStripMenuItem1.Enabled = richTextBox1.CanUndo;
            redoToolStripMenuItem.Enabled = richTextBox1.CanRedo;
            redoToolStripMenuItem1.Enabled = richTextBox1.CanRedo;
            //change change change change change change change change change change change
            if (currentFilePath != "")
            {
                if (saveChangeFlag == 1)
                {
                    this.Text = "*" + Path.GetFileName(currentFilePath) + " (" + currentFilePath + ")";
                }
                else
                {
                    this.Text = Path.GetFileName(currentFilePath) + " (" + currentFilePath + ")";
                }

            }
            else
            {
                if (richTextBox1.Text == "")
                {
                    this.Text = "Unnamed";
                }
                else
                {
                    this.Text = "*Unnamed";
                }
            }
            directoryWithFileToolStripMenuItem.Enabled = (currentFilePath != "");
            fileToolStripMenuItem1.Enabled = (currentFilePath != "");
            directoryToolStripMenuItem.Enabled = (currentFilePath != "");
            openFileFolderToolStripMenuItem.Enabled = (currentFilePath != "");
            copyToCliboardToolStripMenuItem.Enabled = (currentFilePath != "");
            pasteToolStripMenuItem.Enabled = (Clipboard.ContainsText() == true);
            pasteToolStripMenuItem1.Enabled = (Clipboard.ContainsText() == true);
            reopenToolStripMenuItem.Enabled = (currentFilePath != "");
            openInDeafultNotepadToolStripMenuItem.Enabled = (currentFilePath != "");
        }

        private void textuasview(object sender, EventArgs e)
        {
            // Update the label to show the current caret position
            int caretPosition = richTextBox1.SelectionStart + 1; // Caret position is zero-based
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1;
            int column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;

            toolStripLabel1.Text = $"Ln: {line}, Col: {column}, Pos: {caretPosition}";
            int charCount = richTextBox1.TextLength;
            int lineCount = richTextBox1.Lines.Length;
            toolStripLabel3.Text = $"Length: {charCount}, Lines: {lineCount}";
            if (richTextBox1.SelectionLength > 0)
            {
                copyToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem1.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem1.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem1.Enabled = true;

            }
            else
            {
                copyToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem1.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem1.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem1.Enabled = false;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void seleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }


        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float previousFontSize = richTextBox1.ZoomFactor;
            richTextBox1.WordWrap = !richTextBox1.WordWrap;
            richTextBox1.ZoomFactor = previousFontSize;
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // 格式化日期和時間字串
            string formattedDateTime = $"{GetPeriod(now)} {now.ToString("hh:mm tt yyyy/M/d")}";

            // 插入到 RichTextBox 中
            richTextBox1.SelectedText = formattedDateTime;
        }
        private string GetPeriod(DateTime dateTime)
        {
            return dateTime.Hour >= 12 ? "p.m." : "a.m.";
        }

        private void newWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
        private void ToggleFullScreen()
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                // Switch back to normal mode
                this.WindowState = previousWindowState; // Restore the previous window state
                this.FormBorderStyle = FormBorderStyle.Sizable; // Restore window borders
                fullScreenToolStripMenuItem.Checked = false;
            }
            else
            {
                // Switch to full-screen mode
                previousWindowState = this.WindowState; // Store the previous window state
                this.FormBorderStyle = FormBorderStyle.None; // Hide window borders
                this.WindowState = FormWindowState.Maximized; // Set directly to maximize
                fullScreenToolStripMenuItem.Checked = true;
            }
        }

        private void exitfull(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && fullScreenToolStripMenuItem.Checked == true)
            {
                ToggleFullScreen();
            }
        }


        private void directoryWithFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Path.GetDirectoryName(currentFilePath));
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFullScreen();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void inExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath) && File.Exists(currentFilePath))
            {
                string folderPath = Path.GetDirectoryName(currentFilePath);
                Process.Start("explorer.exe", folderPath);
            }
        }

        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath) && File.Exists(currentFilePath))
            {
                // Get the directory containing the current file
                string folderPath = Path.GetDirectoryName(currentFilePath);

                // Open a new Command Prompt window and set its current directory
                Process.Start("cmd", $"/k cd /d \"{folderPath}\"");
            }
        }

        private void zoomInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 4.95)
            {
                richTextBox1.ZoomFactor = richTextBox1.ZoomFactor + 0.1f;
            }
            toolStripLabel2.Text = $"{(int)(richTextBox1.ZoomFactor * 100)}%";
        }

        private void zoomOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.1)
            {
                if (richTextBox1.ZoomFactor < 0.2)
                {
                    richTextBox1.ZoomFactor = 0.1f;
                }
                else
                {
                    richTextBox1.ZoomFactor = richTextBox1.ZoomFactor - 0.1f;
                }
            }
            toolStripLabel2.Text = $"{(int)(richTextBox1.ZoomFactor * 100)}%";
        }

        private void resetZoomToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1f;
            toolStripLabel2.Text = $"{(int)(richTextBox1.ZoomFactor * 100)}%";
        }

        private void processlink(object sender, LinkClickedEventArgs e)
        {
            if (showLink)
            {
                var ps = new ProcessStartInfo(e.LinkText)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
        }

        private void showLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLink = !showLink;
            richTextBox1.DetectUrls = !richTextBox1.DetectUrls;
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goto Goto = new Goto(this);
            Goto.Owner = this;
            Goto.Show();




        }

        private void getPHPHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://www.php.net/" + richTextBox1.SelectedText)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void wikipediaSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("https://.wikipedia.org/wiki/Special:Search?search=" + richTextBox1.SelectedText)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void searchInWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectedText == "")
            {
                linktext = richTextBox1.Lines[richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart)];
            }
            else
            {
                linktext = richTextBox1.SelectedText;
            }
            var ps = new ProcessStartInfo("https://www.google.com/search?q=" + linktext)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void runToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Run Run = new Run();
            Run.Owner = this;
            Run.Show();
        }

        private void readonlyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = !richTextBox1.ReadOnly;
        }

        private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveChangeFlag == 1)
            {
                if (!string.IsNullOrEmpty(richTextBox1.Text) && (string.IsNullOrEmpty(currentFilePath) || File.Exists(currentFilePath)))
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
            richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
            this.Text = Path.GetFileName(currentFilePath) + " (" + currentFilePath + ")";
            int charCount = richTextBox1.TextLength;
            int lineCount = richTextBox1.Lines.Length;
            toolStripLabel3.Text = $"Length: {charCount}, Lines: {lineCount}";


        }

        private void openInDeafultNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = currentFilePath,
                UseShellExecute = true
            });
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Really? You can't get back your file after you delete it", "Warning", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                File.Delete(currentFilePath);
            }
            richTextBox1.Text = "";
            currentFilePath = "";
            this.Text = "Unnamed";
            int charCount = richTextBox1.TextLength;
            int lineCount = richTextBox1.Lines.Length;
            toolStripLabel3.Text = $"Length: {charCount}, Lines: {lineCount}";
        }

        private void moveToTrashcanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Really?", "Warning", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                FileSystem.DeleteFile(currentFilePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            }
            richTextBox1.Text="";
            currentFilePath = "";
            this.Text = "Unnamed";
            int charCount = richTextBox1.TextLength;
            int lineCount = richTextBox1.Lines.Length;
            toolStripLabel3.Text = $"Length: {charCount}, Lines: {lineCount}";
        }
    }
}
