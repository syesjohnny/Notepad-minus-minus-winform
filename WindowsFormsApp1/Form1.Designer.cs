namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            newWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFileFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            inExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            readOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            seleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            timeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToCliboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            directoryWithFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            searchInWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            resetZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            getPHPHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            wikipediaSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.DetectUrls = false;
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Location = new System.Drawing.Point(0, 29);
            richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(783, 360);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.LinkClicked += processlink;
            richTextBox1.SelectionChanged += textuasview;
            richTextBox1.TextChanged += savechange;
            richTextBox1.KeyDown += exitfull;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem1, redoToolStripMenuItem1, cutToolStripMenuItem1, copyToolStripMenuItem1, pasteToolStripMenuItem1, deleteToolStripMenuItem1, selectAllToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(142, 172);
            // 
            // undoToolStripMenuItem1
            // 
            undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            undoToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            undoToolStripMenuItem1.Text = "Undo";
            undoToolStripMenuItem1.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem1
            // 
            redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            redoToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            redoToolStripMenuItem1.Text = "Redo";
            redoToolStripMenuItem1.Click += redoToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            cutToolStripMenuItem1.Text = "Cut";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += seleteAllToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, runToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(783, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator3, newWindowsToolStripMenuItem, closeWindowsToolStripMenuItem, exitToolStripMenuItem, openFileFolderToolStripMenuItem, readOnlyToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            newToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // newWindowsToolStripMenuItem
            // 
            newWindowsToolStripMenuItem.Name = "newWindowsToolStripMenuItem";
            newWindowsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.N;
            newWindowsToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            newWindowsToolStripMenuItem.Text = "New Window";
            newWindowsToolStripMenuItem.Click += newWindowsToolStripMenuItem_Click;
            // 
            // closeWindowsToolStripMenuItem
            // 
            closeWindowsToolStripMenuItem.Name = "closeWindowsToolStripMenuItem";
            closeWindowsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.W;
            closeWindowsToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            closeWindowsToolStripMenuItem.Text = "Close Window";
            closeWindowsToolStripMenuItem.Click += closeWindowsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W;
            exitToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // openFileFolderToolStripMenuItem
            // 
            openFileFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { inExplorerToolStripMenuItem, cMDToolStripMenuItem });
            openFileFolderToolStripMenuItem.Name = "openFileFolderToolStripMenuItem";
            openFileFolderToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            openFileFolderToolStripMenuItem.Text = "Open File Folder";
            // 
            // inExplorerToolStripMenuItem
            // 
            inExplorerToolStripMenuItem.Name = "inExplorerToolStripMenuItem";
            inExplorerToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            inExplorerToolStripMenuItem.Text = "Explorer";
            inExplorerToolStripMenuItem.Click += inExplorerToolStripMenuItem_Click;
            // 
            // cMDToolStripMenuItem
            // 
            cMDToolStripMenuItem.Name = "cMDToolStripMenuItem";
            cMDToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            cMDToolStripMenuItem.Text = "CMD";
            cMDToolStripMenuItem.Click += cMDToolStripMenuItem_Click;
            // 
            // readOnlyToolStripMenuItem
            // 
            readOnlyToolStripMenuItem.CheckOnClick = true;
            readOnlyToolStripMenuItem.Name = "readOnlyToolStripMenuItem";
            readOnlyToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            readOnlyToolStripMenuItem.Text = "Read Only";
            readOnlyToolStripMenuItem.Click += readOnlyToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator1, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, seleteAllToolStripMenuItem, toolStripSeparator2, timeDateToolStripMenuItem, copyToCliboardToolStripMenuItem, goToToolStripMenuItem, searchInWebsiteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            undoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y;
            redoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            cutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            pasteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // seleteAllToolStripMenuItem
            // 
            seleteAllToolStripMenuItem.Name = "seleteAllToolStripMenuItem";
            seleteAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            seleteAllToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            seleteAllToolStripMenuItem.Text = "Selete All";
            seleteAllToolStripMenuItem.Click += seleteAllToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // timeDateToolStripMenuItem
            // 
            timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            timeDateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            timeDateToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            timeDateToolStripMenuItem.Text = "Time/Date";
            timeDateToolStripMenuItem.Click += timeDateToolStripMenuItem_Click;
            // 
            // copyToCliboardToolStripMenuItem
            // 
            copyToCliboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { directoryWithFileToolStripMenuItem, directoryToolStripMenuItem, fileToolStripMenuItem1 });
            copyToCliboardToolStripMenuItem.Name = "copyToCliboardToolStripMenuItem";
            copyToCliboardToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            copyToCliboardToolStripMenuItem.Text = "Copy to Cliboard";
            // 
            // directoryWithFileToolStripMenuItem
            // 
            directoryWithFileToolStripMenuItem.Name = "directoryWithFileToolStripMenuItem";
            directoryWithFileToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            directoryWithFileToolStripMenuItem.Text = "Directory With File";
            directoryWithFileToolStripMenuItem.Click += directoryWithFileToolStripMenuItem_Click;
            // 
            // directoryToolStripMenuItem
            // 
            directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            directoryToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            directoryToolStripMenuItem.Text = "Directory";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new System.Drawing.Size(221, 26);
            fileToolStripMenuItem1.Text = "File";
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            goToToolStripMenuItem.Text = "Go To";
            goToToolStripMenuItem.Click += goToToolStripMenuItem_Click;
            // 
            // searchInWebsiteToolStripMenuItem
            // 
            searchInWebsiteToolStripMenuItem.Name = "searchInWebsiteToolStripMenuItem";
            searchInWebsiteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            searchInWebsiteToolStripMenuItem.Text = "Search In Website";
            searchInWebsiteToolStripMenuItem.Click += searchInWebsiteToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { zoomToolStripMenuItem, wordWrapToolStripMenuItem, statusToolStripMenuItem, fullScreenToolStripMenuItem, alwaysOnTopToolStripMenuItem, showLinksToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, resetZoomToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus;
            zoomInToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            zoomInToolStripMenuItem.Text = "Zoom In";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click_1;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus;
            zoomOutToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click_1;
            // 
            // resetZoomToolStripMenuItem
            // 
            resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            resetZoomToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0;
            resetZoomToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            resetZoomToolStripMenuItem.Text = "Reset Zoom";
            resetZoomToolStripMenuItem.Click += resetZoomToolStripMenuItem_Click_1;
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Checked = true;
            wordWrapToolStripMenuItem.CheckOnClick = true;
            wordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            wordWrapToolStripMenuItem.Text = "Word Wrap";
            wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.Checked = true;
            statusToolStripMenuItem.CheckOnClick = true;
            statusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            statusToolStripMenuItem.Text = "Status ";
            statusToolStripMenuItem.Click += statusToolStripMenuItem_Click;
            // 
            // fullScreenToolStripMenuItem
            // 
            fullScreenToolStripMenuItem.CheckOnClick = true;
            fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            fullScreenToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            fullScreenToolStripMenuItem.Text = "Full Screen";
            fullScreenToolStripMenuItem.Click += fullScreenToolStripMenuItem_Click;
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            alwaysOnTopToolStripMenuItem.Text = "Always On top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // showLinksToolStripMenuItem
            // 
            showLinksToolStripMenuItem.CheckOnClick = true;
            showLinksToolStripMenuItem.Name = "showLinksToolStripMenuItem";
            showLinksToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            showLinksToolStripMenuItem.Text = "Show Links";
            showLinksToolStripMenuItem.Click += showLinksToolStripMenuItem_Click;
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { runToolStripMenuItem1, getPHPHelpToolStripMenuItem, wikipediaSearchToolStripMenuItem });
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            runToolStripMenuItem.Text = "Run";
            // 
            // runToolStripMenuItem1
            // 
            runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            runToolStripMenuItem1.Size = new System.Drawing.Size(213, 26);
            runToolStripMenuItem1.Text = "Run";
            runToolStripMenuItem1.Click += runToolStripMenuItem1_Click;
            // 
            // getPHPHelpToolStripMenuItem
            // 
            getPHPHelpToolStripMenuItem.Name = "getPHPHelpToolStripMenuItem";
            getPHPHelpToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            getPHPHelpToolStripMenuItem.Text = "Get PHP Help";
            getPHPHelpToolStripMenuItem.Click += getPHPHelpToolStripMenuItem_Click;
            // 
            // wikipediaSearchToolStripMenuItem
            // 
            wikipediaSearchToolStripMenuItem.Name = "wikipediaSearchToolStripMenuItem";
            wikipediaSearchToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            wikipediaSearchToolStripMenuItem.Text = "Wikipedia Search";
            wikipediaSearchToolStripMenuItem.Click += wikipediaSearchToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripSeparator4, toolStripLabel3 });
            toolStrip1.Location = new System.Drawing.Point(0, 364);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(783, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(115, 22);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(115, 22);
            toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new System.Drawing.Size(115, 22);
            toolStripLabel3.Text = "toolStripLabel3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(783, 389);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToCliboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryWithFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem openFileFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMDToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getPHPHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikipediaSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchInWebsiteToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}

