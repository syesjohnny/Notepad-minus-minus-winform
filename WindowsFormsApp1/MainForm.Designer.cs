using System.Windows.Forms;

namespace NotePadMinusMinus
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            undoToolStripMenuItem1 = new ToolStripMenuItem();
            redoToolStripMenuItem1 = new ToolStripMenuItem();
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            TopMenuStrip = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            NewFileMenuItem = new ToolStripMenuItem();
            OpenFileMenuItem = new ToolStripMenuItem();
            SaveFileMenuItem = new ToolStripMenuItem();
            SaveAsMenuItem = new ToolStripMenuItem();
            FileMenuSperator1 = new ToolStripSeparator();
            OpenFileFolderSubMenu = new ToolStripMenuItem();
            OpenInExplorerMenuItem = new ToolStripMenuItem();
            OpenInCMDMenuItem = new ToolStripMenuItem();
            FileMenuSeparator2 = new ToolStripSeparator();
            NewWindowMenuItem = new ToolStripMenuItem();
            CloseWindowMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            ReOpenMenuItem = new ToolStripMenuItem();
            OpenInMSNotepadMenuItem = new ToolStripMenuItem();
            DeleteFileSubMenu = new ToolStripMenuItem();
            DeletePermanentlyMenuItem = new ToolStripMenuItem();
            MoveToRecycleBinMenuItem = new ToolStripMenuItem();
            EditMenu = new ToolStripMenuItem();
            ActionUndoMenuItem = new ToolStripMenuItem();
            ActionRedoMenuItem = new ToolStripMenuItem();
            EditMenuSeparator1 = new ToolStripSeparator();
            ActionCutMenuItem = new ToolStripMenuItem();
            ActionCopyMenuItem = new ToolStripMenuItem();
            ActionPasteMenuItem = new ToolStripMenuItem();
            ActionDeleteMenuItem = new ToolStripMenuItem();
            ActionSelectAllMenuItem = new ToolStripMenuItem();
            EditMenuSeparator2 = new ToolStripSeparator();
            InsertDateTimeMenuItem = new ToolStripMenuItem();
            CopyToClipboardSubMenu = new ToolStripMenuItem();
            CopyDirectoryWithFileMenuItem = new ToolStripMenuItem();
            CopyDirectoryOnlyMenuItem = new ToolStripMenuItem();
            CopyFileMenuItem = new ToolStripMenuItem();
            EditMenuSeparator3 = new ToolStripSeparator();
            GoToMenuItem = new ToolStripMenuItem();
            FindReplaceMenuItem = new ToolStripMenuItem();
            SearchInWebsiteMenuItem = new ToolStripMenuItem();
            EditMenuSeparator4 = new ToolStripSeparator();
            ReadonlyModeMenuItem = new ToolStripMenuItem();
            ConvertCaseMenuItem = new ToolStripMenuItem();
            UpperCaseMenuItem = new ToolStripMenuItem();
            LowerCaseMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ProperCaseMenuItem = new ToolStripMenuItem();
            ProperCaseBlendMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            SentenceCaseMenuItem = new ToolStripMenuItem();
            SentenceCaseBlendMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            InvertCaseMenuItem = new ToolStripMenuItem();
            RandomCaseMenuItem = new ToolStripMenuItem();
            LineOperationMenuItem = new ToolStripMenuItem();
            DuplicateLineMenuItem = new ToolStripMenuItem();
            removeDuplicateLinesMenuItem = new ToolStripMenuItem();
            AutoSaveMenuItem = new ToolStripMenuItem();
            ViewMenu = new ToolStripMenuItem();
            ZoomSubMenu = new ToolStripMenuItem();
            ZoomInMenuItem = new ToolStripMenuItem();
            ZoomOutMenuItem = new ToolStripMenuItem();
            ResetZoomMenuItem = new ToolStripMenuItem();
            WordWarpToggleMenuItem = new ToolStripMenuItem();
            StatusToggleMenuItem = new ToolStripMenuItem();
            ViewMenuSeparator1 = new ToolStripSeparator();
            ShowLinksToggleItem = new ToolStripMenuItem();
            ViewMenuSeparator2 = new ToolStripSeparator();
            FullScreenToggleMenuItem = new ToolStripMenuItem();
            AlwaysOnTopToggleMenuItem = new ToolStripMenuItem();
            RunMenu = new ToolStripMenuItem();
            RunMenuItem = new ToolStripMenuItem();
            RunMenuSeparator1 = new ToolStripSeparator();
            GetPHPHelpMenuItem = new ToolStripMenuItem();
            WikipediaSearchMenuItem = new ToolStripMenuItem();
            SettingMenuItem = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            DarkModeMenuItem = new ToolStripMenuItem();
            darkModeSub = new ToolStripMenuItem();
            lightModeSub = new ToolStripMenuItem();
            AutoSub = new ToolStripMenuItem();
            discordRPCToolStripMenuItem = new ToolStripMenuItem();
            RPCEnable = new ToolStripMenuItem();
            RPCShowFileName = new ToolStripMenuItem();
            ShowCharacterCount = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            WhatNewMenuItem = new ToolStripMenuItem();
            EditingArea = new RichTextBox();
            CursorPosInfoText = new ToolStripLabel();
            ZoomInfoText = new ToolStripLabel();
            DocInfoText = new ToolStripLabel();
            BottomToolStrip = new ToolStrip();
            SelectionInfoText = new ToolStripLabel();
            ByteInfoText = new ToolStripLabel();
            MainLayout = new TableLayoutPanel();
            contextMenuStrip1.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            BottomToolStrip.SuspendLayout();
            MainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { undoToolStripMenuItem1, redoToolStripMenuItem1, cutToolStripMenuItem1, copyToolStripMenuItem1, pasteToolStripMenuItem1, deleteToolStripMenuItem1, selectAllToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(142, 172);
            // 
            // undoToolStripMenuItem1
            // 
            undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            undoToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            undoToolStripMenuItem1.Text = "Undo";
            undoToolStripMenuItem1.Click += UndoMenuItem_Click;
            // 
            // redoToolStripMenuItem1
            // 
            redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            redoToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            redoToolStripMenuItem1.Text = "Redo";
            redoToolStripMenuItem1.Click += RedoMenuItem_Click;
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            cutToolStripMenuItem1.Text = "Cut";
            cutToolStripMenuItem1.Click += CutMenuItem_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += CopyMenuItem_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += PasteMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += DeleteMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += SelectMenuItem_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            TopMenuStrip.Dock = DockStyle.Fill;
            TopMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileMenu, EditMenu, ViewMenu, RunMenu, SettingMenuItem, toolStripMenuItem1 });
            TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Padding = new Padding(6, 3, 0, 3);
            TopMenuStrip.Size = new System.Drawing.Size(971, 30);
            TopMenuStrip.TabIndex = 1;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { NewFileMenuItem, OpenFileMenuItem, SaveFileMenuItem, SaveAsMenuItem, FileMenuSperator1, OpenFileFolderSubMenu, FileMenuSeparator2, NewWindowMenuItem, CloseWindowMenuItem, ExitMenuItem, ReOpenMenuItem, OpenInMSNotepadMenuItem, DeleteFileSubMenu });
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new System.Drawing.Size(47, 24);
            FileMenu.Text = "File";
            // 
            // NewFileMenuItem
            // 
            NewFileMenuItem.Name = "NewFileMenuItem";
            NewFileMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            NewFileMenuItem.Size = new System.Drawing.Size(296, 26);
            NewFileMenuItem.Text = "New";
            NewFileMenuItem.Click += NewFileEvent;
            // 
            // OpenFileMenuItem
            // 
            OpenFileMenuItem.Name = "OpenFileMenuItem";
            OpenFileMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenFileMenuItem.Size = new System.Drawing.Size(296, 26);
            OpenFileMenuItem.Text = "Open";
            OpenFileMenuItem.Click += OpenFileEvent;
            // 
            // SaveFileMenuItem
            // 
            SaveFileMenuItem.Name = "SaveFileMenuItem";
            SaveFileMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveFileMenuItem.Size = new System.Drawing.Size(296, 26);
            SaveFileMenuItem.Text = "Save";
            SaveFileMenuItem.Click += SaveFileEvent;
            // 
            // SaveAsMenuItem
            // 
            SaveAsMenuItem.Name = "SaveAsMenuItem";
            SaveAsMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            SaveAsMenuItem.Size = new System.Drawing.Size(296, 26);
            SaveAsMenuItem.Text = "Save As";
            SaveAsMenuItem.Click += SaveAsEvent;
            // 
            // FileMenuSperator1
            // 
            FileMenuSperator1.Name = "FileMenuSperator1";
            FileMenuSperator1.Size = new System.Drawing.Size(293, 6);
            // 
            // OpenFileFolderSubMenu
            // 
            OpenFileFolderSubMenu.DropDownItems.AddRange(new ToolStripItem[] { OpenInExplorerMenuItem, OpenInCMDMenuItem });
            OpenFileFolderSubMenu.Name = "OpenFileFolderSubMenu";
            OpenFileFolderSubMenu.Size = new System.Drawing.Size(296, 26);
            OpenFileFolderSubMenu.Text = "Open File Folder";
            // 
            // OpenInExplorerMenuItem
            // 
            OpenInExplorerMenuItem.Name = "OpenInExplorerMenuItem";
            OpenInExplorerMenuItem.Size = new System.Drawing.Size(149, 26);
            OpenInExplorerMenuItem.Text = "Explorer";
            OpenInExplorerMenuItem.Click += OpenInExplorer;
            // 
            // OpenInCMDMenuItem
            // 
            OpenInCMDMenuItem.Name = "OpenInCMDMenuItem";
            OpenInCMDMenuItem.Size = new System.Drawing.Size(149, 26);
            OpenInCMDMenuItem.Text = "CMD";
            OpenInCMDMenuItem.Click += OpenInCMD;
            // 
            // FileMenuSeparator2
            // 
            FileMenuSeparator2.Name = "FileMenuSeparator2";
            FileMenuSeparator2.Size = new System.Drawing.Size(293, 6);
            // 
            // NewWindowMenuItem
            // 
            NewWindowMenuItem.Name = "NewWindowMenuItem";
            NewWindowMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            NewWindowMenuItem.Size = new System.Drawing.Size(296, 26);
            NewWindowMenuItem.Text = "New Window";
            NewWindowMenuItem.Click += OpenNewWindow;
            // 
            // CloseWindowMenuItem
            // 
            CloseWindowMenuItem.Name = "CloseWindowMenuItem";
            CloseWindowMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.W;
            CloseWindowMenuItem.Size = new System.Drawing.Size(296, 26);
            CloseWindowMenuItem.Text = "Close Window";
            CloseWindowMenuItem.Click += CloseWindowEvent;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            ExitMenuItem.Size = new System.Drawing.Size(296, 26);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitEvent;
            // 
            // ReOpenMenuItem
            // 
            ReOpenMenuItem.Name = "ReOpenMenuItem";
            ReOpenMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            ReOpenMenuItem.Size = new System.Drawing.Size(296, 26);
            ReOpenMenuItem.Text = "Re-Open";
            ReOpenMenuItem.Click += ReOpenMenuItem_Click;
            // 
            // OpenInMSNotepadMenuItem
            // 
            OpenInMSNotepadMenuItem.Name = "OpenInMSNotepadMenuItem";
            OpenInMSNotepadMenuItem.Size = new System.Drawing.Size(296, 26);
            OpenInMSNotepadMenuItem.Text = "Open In Deafult Notepad";
            OpenInMSNotepadMenuItem.Click += OpenInMSNotepadMenuItem_Click;
            // 
            // DeleteFileSubMenu
            // 
            DeleteFileSubMenu.DropDownItems.AddRange(new ToolStripItem[] { DeletePermanentlyMenuItem, MoveToRecycleBinMenuItem });
            DeleteFileSubMenu.Name = "DeleteFileSubMenu";
            DeleteFileSubMenu.Size = new System.Drawing.Size(296, 26);
            DeleteFileSubMenu.Text = "Delete File";
            // 
            // DeletePermanentlyMenuItem
            // 
            DeletePermanentlyMenuItem.Name = "DeletePermanentlyMenuItem";
            DeletePermanentlyMenuItem.Size = new System.Drawing.Size(234, 26);
            DeletePermanentlyMenuItem.Text = "Delete";
            DeletePermanentlyMenuItem.Click += DeletePermanentlyMenuItem_Click;
            // 
            // MoveToRecycleBinMenuItem
            // 
            MoveToRecycleBinMenuItem.Name = "MoveToRecycleBinMenuItem";
            MoveToRecycleBinMenuItem.Size = new System.Drawing.Size(234, 26);
            MoveToRecycleBinMenuItem.Text = "Move To Recycle Bin";
            MoveToRecycleBinMenuItem.Click += RemoveFileMenuItem_Click;
            // 
            // EditMenu
            // 
            EditMenu.DropDownItems.AddRange(new ToolStripItem[] { ActionUndoMenuItem, ActionRedoMenuItem, EditMenuSeparator1, ActionCutMenuItem, ActionCopyMenuItem, ActionPasteMenuItem, ActionDeleteMenuItem, ActionSelectAllMenuItem, EditMenuSeparator2, InsertDateTimeMenuItem, CopyToClipboardSubMenu, EditMenuSeparator3, GoToMenuItem, FindReplaceMenuItem, SearchInWebsiteMenuItem, EditMenuSeparator4, ReadonlyModeMenuItem, ConvertCaseMenuItem, LineOperationMenuItem, AutoSaveMenuItem });
            EditMenu.Name = "EditMenu";
            EditMenu.Size = new System.Drawing.Size(50, 24);
            EditMenu.Text = "Edit";
            // 
            // ActionUndoMenuItem
            // 
            ActionUndoMenuItem.Name = "ActionUndoMenuItem";
            ActionUndoMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            ActionUndoMenuItem.Size = new System.Drawing.Size(232, 26);
            ActionUndoMenuItem.Text = "Undo";
            ActionUndoMenuItem.Click += UndoMenuItem_Click;
            // 
            // ActionRedoMenuItem
            // 
            ActionRedoMenuItem.Name = "ActionRedoMenuItem";
            ActionRedoMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            ActionRedoMenuItem.Size = new System.Drawing.Size(232, 26);
            ActionRedoMenuItem.Text = "Redo";
            ActionRedoMenuItem.Click += RedoMenuItem_Click;
            // 
            // EditMenuSeparator1
            // 
            EditMenuSeparator1.Name = "EditMenuSeparator1";
            EditMenuSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // ActionCutMenuItem
            // 
            ActionCutMenuItem.Name = "ActionCutMenuItem";
            ActionCutMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            ActionCutMenuItem.Size = new System.Drawing.Size(232, 26);
            ActionCutMenuItem.Text = "Cut";
            ActionCutMenuItem.Click += CutMenuItem_Click;
            // 
            // ActionCopyMenuItem
            // 
            ActionCopyMenuItem.Name = "ActionCopyMenuItem";
            ActionCopyMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            ActionCopyMenuItem.Size = new System.Drawing.Size(232, 26);
            ActionCopyMenuItem.Text = "Copy";
            ActionCopyMenuItem.Click += CopyMenuItem_Click;
            // 
            // ActionPasteMenuItem
            // 
            ActionPasteMenuItem.Name = "ActionPasteMenuItem";
            ActionPasteMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            ActionPasteMenuItem.Size = new System.Drawing.Size(232, 26);
            ActionPasteMenuItem.Text = "Paste";
            ActionPasteMenuItem.Click += PasteMenuItem_Click;
            // 
            // ActionDeleteMenuItem
            // 
            ActionDeleteMenuItem.Name = "ActionDeleteMenuItem";
            ActionDeleteMenuItem.ShortcutKeys = Keys.Delete;
            ActionDeleteMenuItem.Size = new System.Drawing.Size(232, 26);
            ActionDeleteMenuItem.Text = "Delete";
            ActionDeleteMenuItem.Click += DeleteMenuItem_Click;
            // 
            // ActionSelectAllMenuItem
            // 
            ActionSelectAllMenuItem.Name = "ActionSelectAllMenuItem";
            ActionSelectAllMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            ActionSelectAllMenuItem.Size = new System.Drawing.Size(232, 26);
            ActionSelectAllMenuItem.Text = "Select All";
            ActionSelectAllMenuItem.Click += SelectMenuItem_Click;
            // 
            // EditMenuSeparator2
            // 
            EditMenuSeparator2.Name = "EditMenuSeparator2";
            EditMenuSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // InsertDateTimeMenuItem
            // 
            InsertDateTimeMenuItem.Name = "InsertDateTimeMenuItem";
            InsertDateTimeMenuItem.ShortcutKeys = Keys.F5;
            InsertDateTimeMenuItem.Size = new System.Drawing.Size(232, 26);
            InsertDateTimeMenuItem.Text = "Time/Date";
            InsertDateTimeMenuItem.Click += InsertDateTime;
            // 
            // CopyToClipboardSubMenu
            // 
            CopyToClipboardSubMenu.DropDownItems.AddRange(new ToolStripItem[] { CopyDirectoryWithFileMenuItem, CopyDirectoryOnlyMenuItem, CopyFileMenuItem });
            CopyToClipboardSubMenu.Name = "CopyToClipboardSubMenu";
            CopyToClipboardSubMenu.Size = new System.Drawing.Size(232, 26);
            CopyToClipboardSubMenu.Text = "Copy to Clipboard";
            // 
            // CopyDirectoryWithFileMenuItem
            // 
            CopyDirectoryWithFileMenuItem.Name = "CopyDirectoryWithFileMenuItem";
            CopyDirectoryWithFileMenuItem.Size = new System.Drawing.Size(221, 26);
            CopyDirectoryWithFileMenuItem.Text = "Directory With File";
            CopyDirectoryWithFileMenuItem.Click += CopyDirectoryPath;
            // 
            // CopyDirectoryOnlyMenuItem
            // 
            CopyDirectoryOnlyMenuItem.Name = "CopyDirectoryOnlyMenuItem";
            CopyDirectoryOnlyMenuItem.Size = new System.Drawing.Size(221, 26);
            CopyDirectoryOnlyMenuItem.Text = "Directory";
            // 
            // CopyFileMenuItem
            // 
            CopyFileMenuItem.Name = "CopyFileMenuItem";
            CopyFileMenuItem.Size = new System.Drawing.Size(221, 26);
            CopyFileMenuItem.Text = "File";
            // 
            // EditMenuSeparator3
            // 
            EditMenuSeparator3.Name = "EditMenuSeparator3";
            EditMenuSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // GoToMenuItem
            // 
            GoToMenuItem.Name = "GoToMenuItem";
            GoToMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            GoToMenuItem.Size = new System.Drawing.Size(232, 26);
            GoToMenuItem.Text = "Go To";
            GoToMenuItem.Click += GoToMenuItem_Click;
            // 
            // FindReplaceMenuItem
            // 
            FindReplaceMenuItem.Name = "FindReplaceMenuItem";
            FindReplaceMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            FindReplaceMenuItem.Size = new System.Drawing.Size(232, 26);
            FindReplaceMenuItem.Text = "Find/replace";
            FindReplaceMenuItem.Click += FindReplaceMenuItem_Click;
            // 
            // SearchInWebsiteMenuItem
            // 
            SearchInWebsiteMenuItem.Name = "SearchInWebsiteMenuItem";
            SearchInWebsiteMenuItem.Size = new System.Drawing.Size(232, 26);
            SearchInWebsiteMenuItem.Text = "Search In Websites";
            SearchInWebsiteMenuItem.Click += SearchInWebsiteMenuItem_Click;
            // 
            // EditMenuSeparator4
            // 
            EditMenuSeparator4.Name = "EditMenuSeparator4";
            EditMenuSeparator4.Size = new System.Drawing.Size(229, 6);
            // 
            // ReadonlyModeMenuItem
            // 
            ReadonlyModeMenuItem.CheckOnClick = true;
            ReadonlyModeMenuItem.Name = "ReadonlyModeMenuItem";
            ReadonlyModeMenuItem.Size = new System.Drawing.Size(232, 26);
            ReadonlyModeMenuItem.Text = "Readonly";
            ReadonlyModeMenuItem.Click += ToggleReadOnlyMode;
            // 
            // ConvertCaseMenuItem
            // 
            ConvertCaseMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UpperCaseMenuItem, LowerCaseMenuItem, toolStripSeparator1, ProperCaseMenuItem, ProperCaseBlendMenuItem, toolStripSeparator2, SentenceCaseMenuItem, SentenceCaseBlendMenuItem, toolStripSeparator3, InvertCaseMenuItem, RandomCaseMenuItem });
            ConvertCaseMenuItem.Name = "ConvertCaseMenuItem";
            ConvertCaseMenuItem.Size = new System.Drawing.Size(232, 26);
            ConvertCaseMenuItem.Text = "Convert Case";
            // 
            // UpperCaseMenuItem
            // 
            UpperCaseMenuItem.Name = "UpperCaseMenuItem";
            UpperCaseMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.U;
            UpperCaseMenuItem.Size = new System.Drawing.Size(375, 26);
            UpperCaseMenuItem.Text = "Upper Case";
            UpperCaseMenuItem.Click += UpperCaseMenuItem_Click;
            // 
            // LowerCaseMenuItem
            // 
            LowerCaseMenuItem.Name = "LowerCaseMenuItem";
            LowerCaseMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            LowerCaseMenuItem.Size = new System.Drawing.Size(375, 26);
            LowerCaseMenuItem.Text = "Lower Case";
            LowerCaseMenuItem.Click += LowerCaseMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(372, 6);
            // 
            // ProperCaseMenuItem
            // 
            ProperCaseMenuItem.Name = "ProperCaseMenuItem";
            ProperCaseMenuItem.ShortcutKeys = Keys.Alt | Keys.U;
            ProperCaseMenuItem.Size = new System.Drawing.Size(375, 26);
            ProperCaseMenuItem.Text = "Proper Case";
            ProperCaseMenuItem.Click += ProperCaseMenuItem_Click;
            // 
            // ProperCaseBlendMenuItem
            // 
            ProperCaseBlendMenuItem.Name = "ProperCaseBlendMenuItem";
            ProperCaseBlendMenuItem.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.U;
            ProperCaseBlendMenuItem.Size = new System.Drawing.Size(375, 26);
            ProperCaseBlendMenuItem.Text = "Proper Case (Blend)";
            ProperCaseBlendMenuItem.Click += ProperCaseBlendMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(372, 6);
            // 
            // SentenceCaseMenuItem
            // 
            SentenceCaseMenuItem.Name = "SentenceCaseMenuItem";
            SentenceCaseMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.U;
            SentenceCaseMenuItem.Size = new System.Drawing.Size(375, 26);
            SentenceCaseMenuItem.Text = "Sentence Case";
            SentenceCaseMenuItem.Click += SentenceCaseMenuItem_Click;
            // 
            // SentenceCaseBlendMenuItem
            // 
            SentenceCaseBlendMenuItem.Name = "SentenceCaseBlendMenuItem";
            SentenceCaseBlendMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.Shift | Keys.U;
            SentenceCaseBlendMenuItem.Size = new System.Drawing.Size(375, 26);
            SentenceCaseBlendMenuItem.Text = "Sentence Case (Blend)";
            SentenceCaseBlendMenuItem.Click += SentenceCaseBlendMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(372, 6);
            // 
            // InvertCaseMenuItem
            // 
            InvertCaseMenuItem.Name = "InvertCaseMenuItem";
            InvertCaseMenuItem.Size = new System.Drawing.Size(375, 26);
            InvertCaseMenuItem.Text = "Invert Case";
            InvertCaseMenuItem.Click += InvertCaseMenuItem_Click;
            // 
            // RandomCaseMenuItem
            // 
            RandomCaseMenuItem.Name = "RandomCaseMenuItem";
            RandomCaseMenuItem.Size = new System.Drawing.Size(375, 26);
            RandomCaseMenuItem.Text = "Random Case";
            RandomCaseMenuItem.Click += RandomCaseMenuItem_Click;
            // 
            // LineOperationMenuItem
            // 
            LineOperationMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DuplicateLineMenuItem, removeDuplicateLinesMenuItem });
            LineOperationMenuItem.Name = "LineOperationMenuItem";
            LineOperationMenuItem.Size = new System.Drawing.Size(232, 26);
            LineOperationMenuItem.Text = "Line Operations";
            // 
            // DuplicateLineMenuItem
            // 
            DuplicateLineMenuItem.Name = "DuplicateLineMenuItem";
            DuplicateLineMenuItem.Size = new System.Drawing.Size(258, 26);
            DuplicateLineMenuItem.Text = "Duplicate Line";
            DuplicateLineMenuItem.Click += DuplicateLineMenuItem_Click;
            // 
            // removeDuplicateLinesMenuItem
            // 
            removeDuplicateLinesMenuItem.Name = "removeDuplicateLinesMenuItem";
            removeDuplicateLinesMenuItem.Size = new System.Drawing.Size(258, 26);
            removeDuplicateLinesMenuItem.Text = "Remove Duplicate Lines";
            removeDuplicateLinesMenuItem.Click += removeDuplicateLinesMenuItem_Click;
            // 
            // AutoSaveMenuItem
            // 
            AutoSaveMenuItem.CheckOnClick = true;
            AutoSaveMenuItem.Name = "AutoSaveMenuItem";
            AutoSaveMenuItem.Size = new System.Drawing.Size(232, 26);
            AutoSaveMenuItem.Text = "Auto Save";
            AutoSaveMenuItem.Click += autoSaveToolStripMenuItem_Click;
            // 
            // ViewMenu
            // 
            ViewMenu.DropDownItems.AddRange(new ToolStripItem[] { ZoomSubMenu, WordWarpToggleMenuItem, StatusToggleMenuItem, ViewMenuSeparator1, ShowLinksToggleItem, ViewMenuSeparator2, FullScreenToggleMenuItem, AlwaysOnTopToggleMenuItem });
            ViewMenu.Name = "ViewMenu";
            ViewMenu.Size = new System.Drawing.Size(57, 24);
            ViewMenu.Text = "View";
            // 
            // ZoomSubMenu
            // 
            ZoomSubMenu.DropDownItems.AddRange(new ToolStripItem[] { ZoomInMenuItem, ZoomOutMenuItem, ResetZoomMenuItem });
            ZoomSubMenu.Name = "ZoomSubMenu";
            ZoomSubMenu.Size = new System.Drawing.Size(252, 26);
            ZoomSubMenu.Text = "Zoom";
            // 
            // ZoomInMenuItem
            // 
            ZoomInMenuItem.Name = "ZoomInMenuItem";
            ZoomInMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            ZoomInMenuItem.Size = new System.Drawing.Size(285, 26);
            ZoomInMenuItem.Text = "Zoom In";
            ZoomInMenuItem.Click += ZoomIn;
            // 
            // ZoomOutMenuItem
            // 
            ZoomOutMenuItem.Name = "ZoomOutMenuItem";
            ZoomOutMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            ZoomOutMenuItem.Size = new System.Drawing.Size(285, 26);
            ZoomOutMenuItem.Text = "Zoom Out";
            ZoomOutMenuItem.Click += ZoomOut;
            // 
            // ResetZoomMenuItem
            // 
            ResetZoomMenuItem.Name = "ResetZoomMenuItem";
            ResetZoomMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            ResetZoomMenuItem.Size = new System.Drawing.Size(285, 26);
            ResetZoomMenuItem.Text = "Reset Zoom";
            ResetZoomMenuItem.Click += ResetZoom;
            // 
            // WordWarpToggleMenuItem
            // 
            WordWarpToggleMenuItem.Checked = true;
            WordWarpToggleMenuItem.CheckOnClick = true;
            WordWarpToggleMenuItem.CheckState = CheckState.Checked;
            WordWarpToggleMenuItem.Name = "WordWarpToggleMenuItem";
            WordWarpToggleMenuItem.Size = new System.Drawing.Size(252, 26);
            WordWarpToggleMenuItem.Text = "Word Wrap";
            WordWarpToggleMenuItem.Click += ToggleWordWarp;
            // 
            // StatusToggleMenuItem
            // 
            StatusToggleMenuItem.Checked = true;
            StatusToggleMenuItem.CheckOnClick = true;
            StatusToggleMenuItem.CheckState = CheckState.Checked;
            StatusToggleMenuItem.Name = "StatusToggleMenuItem";
            StatusToggleMenuItem.Size = new System.Drawing.Size(252, 26);
            StatusToggleMenuItem.Text = "Status ";
            StatusToggleMenuItem.Click += ToggleStatus;
            // 
            // ViewMenuSeparator1
            // 
            ViewMenuSeparator1.Name = "ViewMenuSeparator1";
            ViewMenuSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // ShowLinksToggleItem
            // 
            ShowLinksToggleItem.CheckOnClick = true;
            ShowLinksToggleItem.Name = "ShowLinksToggleItem";
            ShowLinksToggleItem.Size = new System.Drawing.Size(252, 26);
            ShowLinksToggleItem.Text = "Show Links";
            ShowLinksToggleItem.Click += ToggleShowLinks;
            // 
            // ViewMenuSeparator2
            // 
            ViewMenuSeparator2.Name = "ViewMenuSeparator2";
            ViewMenuSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // FullScreenToggleMenuItem
            // 
            FullScreenToggleMenuItem.CheckOnClick = true;
            FullScreenToggleMenuItem.Name = "FullScreenToggleMenuItem";
            FullScreenToggleMenuItem.ShortcutKeys = Keys.F11;
            FullScreenToggleMenuItem.Size = new System.Drawing.Size(252, 26);
            FullScreenToggleMenuItem.Text = "Full Screen";
            FullScreenToggleMenuItem.Click += ToggleFullScreen;
            // 
            // AlwaysOnTopToggleMenuItem
            // 
            AlwaysOnTopToggleMenuItem.CheckOnClick = true;
            AlwaysOnTopToggleMenuItem.Name = "AlwaysOnTopToggleMenuItem";
            AlwaysOnTopToggleMenuItem.ShortcutKeys = Keys.Alt | Keys.Up;
            AlwaysOnTopToggleMenuItem.Size = new System.Drawing.Size(252, 26);
            AlwaysOnTopToggleMenuItem.Text = "Always On top";
            AlwaysOnTopToggleMenuItem.Click += ToggleAlwaysOnTop;
            // 
            // RunMenu
            // 
            RunMenu.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            RunMenu.DropDownItems.AddRange(new ToolStripItem[] { RunMenuItem, RunMenuSeparator1, GetPHPHelpMenuItem, WikipediaSearchMenuItem });
            RunMenu.Name = "RunMenu";
            RunMenu.Size = new System.Drawing.Size(51, 24);
            RunMenu.Text = "Run";
            // 
            // RunMenuItem
            // 
            RunMenuItem.Name = "RunMenuItem";
            RunMenuItem.ShortcutKeys = Keys.F5;
            RunMenuItem.Size = new System.Drawing.Size(213, 26);
            RunMenuItem.Text = "Run";
            RunMenuItem.Click += RunMenuItem_Click;
            // 
            // RunMenuSeparator1
            // 
            RunMenuSeparator1.Name = "RunMenuSeparator1";
            RunMenuSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // GetPHPHelpMenuItem
            // 
            GetPHPHelpMenuItem.Name = "GetPHPHelpMenuItem";
            GetPHPHelpMenuItem.Size = new System.Drawing.Size(213, 26);
            GetPHPHelpMenuItem.Text = "Get PHP Help";
            GetPHPHelpMenuItem.Click += GetPHPHelpMenuItem_Click;
            // 
            // WikipediaSearchMenuItem
            // 
            WikipediaSearchMenuItem.Name = "WikipediaSearchMenuItem";
            WikipediaSearchMenuItem.Size = new System.Drawing.Size(213, 26);
            WikipediaSearchMenuItem.Text = "Wikipedia Search";
            WikipediaSearchMenuItem.Click += SearchInWikipediaMenuItem_Click;
            // 
            // SettingMenuItem
            // 
            SettingMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preferencesToolStripMenuItem, DarkModeMenuItem, discordRPCToolStripMenuItem });
            SettingMenuItem.Name = "SettingMenuItem";
            SettingMenuItem.Size = new System.Drawing.Size(73, 24);
            SettingMenuItem.Text = "Setting";
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            preferencesToolStripMenuItem.Text = "Preferences";
            preferencesToolStripMenuItem.Click += preferencesToolStripMenuItem_Click;
            // 
            // DarkModeMenuItem
            // 
            DarkModeMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkModeSub, lightModeSub, AutoSub });
            DarkModeMenuItem.Name = "DarkModeMenuItem";
            DarkModeMenuItem.Size = new System.Drawing.Size(179, 26);
            DarkModeMenuItem.Text = "Dark Mode";
            // 
            // darkModeSub
            // 
            darkModeSub.Name = "darkModeSub";
            darkModeSub.Size = new System.Drawing.Size(173, 26);
            darkModeSub.Text = "Dark Mode";
            darkModeSub.Click += EnableDarkMode_Click;
            // 
            // lightModeSub
            // 
            lightModeSub.Name = "lightModeSub";
            lightModeSub.Size = new System.Drawing.Size(173, 26);
            lightModeSub.Text = "Light Mode";
            lightModeSub.Click += DisableDarkMode_Click;
            // 
            // AutoSub
            // 
            AutoSub.Name = "AutoSub";
            AutoSub.Size = new System.Drawing.Size(173, 26);
            AutoSub.Text = "Auto";
            AutoSub.Click += autoToolStripMenuItem_Click;
            // 
            // discordRPCToolStripMenuItem
            // 
            discordRPCToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RPCEnable, RPCShowFileName, ShowCharacterCount });
            discordRPCToolStripMenuItem.Name = "discordRPCToolStripMenuItem";
            discordRPCToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            discordRPCToolStripMenuItem.Text = "Discord RPC";
            // 
            // RPCEnable
            // 
            RPCEnable.CheckOnClick = true;
            RPCEnable.Name = "RPCEnable";
            RPCEnable.Size = new System.Drawing.Size(249, 26);
            RPCEnable.Text = "Enable";
            RPCEnable.Click += RPCEnable_Click;
            // 
            // RPCShowFileName
            // 
            RPCShowFileName.CheckOnClick = true;
            RPCShowFileName.Name = "RPCShowFileName";
            RPCShowFileName.Size = new System.Drawing.Size(249, 26);
            RPCShowFileName.Text = "Show File Name";
            RPCShowFileName.Click += RPCShowFileName_Click;
            // 
            // ShowCharacterCount
            // 
            ShowCharacterCount.Name = "ShowCharacterCount";
            ShowCharacterCount.Size = new System.Drawing.Size(249, 26);
            ShowCharacterCount.Text = "Show Charactes Count";
            ShowCharacterCount.Click += ShowCharacterCount_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { AboutMenuItem, WhatNewMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            toolStripMenuItem1.Text = "?";
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new System.Drawing.Size(183, 26);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // WhatNewMenuItem
            // 
            WhatNewMenuItem.Name = "WhatNewMenuItem";
            WhatNewMenuItem.Size = new System.Drawing.Size(183, 26);
            WhatNewMenuItem.Text = "What's New?";
            WhatNewMenuItem.Click += WhatNewMenuItem_Click;
            // 
            // EditingArea
            // 
            EditingArea.AcceptsTab = true;
            EditingArea.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            EditingArea.BorderStyle = BorderStyle.None;
            EditingArea.ContextMenuStrip = contextMenuStrip1;
            EditingArea.DetectUrls = false;
            EditingArea.Dock = DockStyle.Fill;
            EditingArea.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EditingArea.ForeColor = System.Drawing.Color.Black;
            EditingArea.Location = new System.Drawing.Point(3, 34);
            EditingArea.Margin = new Padding(3, 4, 3, 4);
            EditingArea.Name = "EditingArea";
            EditingArea.Size = new System.Drawing.Size(965, 465);
            EditingArea.TabIndex = 0;
            EditingArea.Text = "";
            EditingArea.LinkClicked += OpenLink;
            EditingArea.SelectionChanged += EditingAreaOnSelectionChange;
            EditingArea.TextChanged += OnEditingAreaTextChange;
            EditingArea.KeyDown += ExitFullscreen;
            // 
            // CursorPosInfoText
            // 
            CursorPosInfoText.Name = "CursorPosInfoText";
            CursorPosInfoText.Size = new System.Drawing.Size(108, 27);
            CursorPosInfoText.Text = "CursorPosInfo";
            // 
            // ZoomInfoText
            // 
            ZoomInfoText.Alignment = ToolStripItemAlignment.Right;
            ZoomInfoText.Name = "ZoomInfoText";
            ZoomInfoText.Size = new System.Drawing.Size(77, 27);
            ZoomInfoText.Text = "ZoomInfo";
            // 
            // DocInfoText
            // 
            DocInfoText.Alignment = ToolStripItemAlignment.Right;
            DocInfoText.Name = "DocInfoText";
            DocInfoText.Size = new System.Drawing.Size(63, 27);
            DocInfoText.Text = "DocInfo";
            // 
            // BottomToolStrip
            // 
            BottomToolStrip.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            BottomToolStrip.Dock = DockStyle.Fill;
            BottomToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            BottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            BottomToolStrip.Items.AddRange(new ToolStripItem[] { CursorPosInfoText, ZoomInfoText, DocInfoText, SelectionInfoText, ByteInfoText });
            BottomToolStrip.Location = new System.Drawing.Point(0, 503);
            BottomToolStrip.Name = "BottomToolStrip";
            BottomToolStrip.Size = new System.Drawing.Size(971, 30);
            BottomToolStrip.TabIndex = 2;
            BottomToolStrip.Text = "BottomToolStrip";
            // 
            // SelectionInfoText
            // 
            SelectionInfoText.Name = "SelectionInfoText";
            SelectionInfoText.Size = new System.Drawing.Size(99, 27);
            SelectionInfoText.Text = "SelectionInfo";
            // 
            // ByteInfoText
            // 
            ByteInfoText.Name = "ByteInfoText";
            ByteInfoText.Size = new System.Drawing.Size(66, 27);
            ByteInfoText.Text = "ByteInfo";
            // 
            // MainLayout
            // 
            MainLayout.ColumnCount = 1;
            MainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainLayout.Controls.Add(BottomToolStrip, 0, 2);
            MainLayout.Controls.Add(TopMenuStrip, 0, 0);
            MainLayout.Controls.Add(EditingArea, 0, 1);
            MainLayout.Dock = DockStyle.Fill;
            MainLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            MainLayout.Location = new System.Drawing.Point(0, 0);
            MainLayout.Margin = new Padding(0);
            MainLayout.Name = "MainLayout";
            MainLayout.RowCount = 3;
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            MainLayout.Size = new System.Drawing.Size(971, 533);
            MainLayout.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(971, 533);
            Controls.Add(MainLayout);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = TopMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += ExitConfirm;
            contextMenuStrip1.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            BottomToolStrip.ResumeLayout(false);
            BottomToolStrip.PerformLayout();
            MainLayout.ResumeLayout(false);
            MainLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
		private System.Windows.Forms.ToolStripMenuItem NewFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditMenu;
		private System.Windows.Forms.ToolStripMenuItem ViewMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ActionUndoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ActionRedoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ActionCutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ActionCopyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ActionPasteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ActionDeleteMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ActionSelectAllMenuItem;
		private System.Windows.Forms.ToolStripMenuItem InsertDateTimeMenuItem;
		private System.Windows.Forms.ToolStripSeparator EditMenuSeparator1;
		private System.Windows.Forms.ToolStripSeparator EditMenuSeparator2;
		private System.Windows.Forms.ToolStripMenuItem WordWarpToggleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem StatusToggleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewWindowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CloseWindowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ZoomSubMenu;
		private System.Windows.Forms.ToolStripMenuItem ZoomInMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ZoomOutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ResetZoomMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FullScreenToggleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AlwaysOnTopToggleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyToClipboardSubMenu;
		private System.Windows.Forms.ToolStripMenuItem CopyDirectoryWithFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyDirectoryOnlyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenFileFolderSubMenu;
		private System.Windows.Forms.ToolStripMenuItem OpenInExplorerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenInCMDMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ShowLinksToggleItem;
		private System.Windows.Forms.ToolStripMenuItem GoToMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RunMenu;
		private System.Windows.Forms.ToolStripMenuItem RunMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GetPHPHelpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem WikipediaSearchMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SearchInWebsiteMenuItem;
		private System.Windows.Forms.ToolStripSeparator FileMenuSperator1;
		private System.Windows.Forms.ToolStripSeparator FileMenuSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ReadonlyModeMenuItem;
		private System.Windows.Forms.ToolStripSeparator EditMenuSeparator3;
		private System.Windows.Forms.ToolStripSeparator EditMenuSeparator4;
		private System.Windows.Forms.ToolStripSeparator ViewMenuSeparator1;
		private System.Windows.Forms.ToolStripSeparator ViewMenuSeparator2;
		private System.Windows.Forms.ToolStripSeparator RunMenuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ReOpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenInMSNotepadMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeletePermanentlyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteFileSubMenu;
		private System.Windows.Forms.ToolStripMenuItem MoveToRecycleBinMenuItem;
		private ToolStripMenuItem FindReplaceMenuItem;
		private ToolStripMenuItem ConvertCaseMenuItem;
		private ToolStripMenuItem UpperCaseMenuItem;
		private ToolStripMenuItem LowerCaseMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem ProperCaseMenuItem;
		private ToolStripMenuItem ProperCaseBlendMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem InvertCaseMenuItem;
		private ToolStripMenuItem RandomCaseMenuItem;
		private ToolStripMenuItem SentenceCaseMenuItem;
		private ToolStripMenuItem SentenceCaseBlendMenuItem;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem LineOperationMenuItem;
		private ToolStripMenuItem DuplicateLineMenuItem;
		private ToolStripMenuItem removeDuplicateLinesMenuItem;
		private ToolStripMenuItem SettingMenuItem;
		private ToolStripMenuItem preferencesToolStripMenuItem;
		public MenuStrip TopMenuStrip;
		public RichTextBox EditingArea;
		private ToolStripLabel CursorPosInfoText;
		private ToolStripLabel ZoomInfoText;
		private ToolStripLabel DocInfoText;
		public ToolStrip BottomToolStrip;
		private TableLayoutPanel MainLayout;
        private ToolStripMenuItem DarkModeMenuItem;
        private ToolStripMenuItem darkModeSub;
        private ToolStripMenuItem lightModeSub;
        private ToolStripMenuItem AutoSub;
        private ToolStripMenuItem AutoSaveMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem AboutMenuItem;
        private ToolStripMenuItem WhatNewMenuItem;
        private ToolStripMenuItem discordRPCToolStripMenuItem;
        private ToolStripMenuItem RPCShowFileName;
        private ToolStripMenuItem RPCEnable;
        private ToolStripMenuItem ShowCharacterCount;
        private ToolStripLabel SelectionInfoText;
        private ToolStripLabel ByteInfoText;
    }
}

