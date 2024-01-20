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
			EditingArea = new RichTextBox();
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
			SearchInWebsiteMenuItem = new ToolStripMenuItem();
			EditMenuSeparator4 = new ToolStripSeparator();
			ReadonlyModeMenuItem = new ToolStripMenuItem();
			ViewMenu = new ToolStripMenuItem();
			zoomToolStripMenuItem = new ToolStripMenuItem();
			zoomInToolStripMenuItem = new ToolStripMenuItem();
			zoomOutToolStripMenuItem = new ToolStripMenuItem();
			resetZoomToolStripMenuItem = new ToolStripMenuItem();
			wordWrapToolStripMenuItem = new ToolStripMenuItem();
			statusToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator8 = new ToolStripSeparator();
			showLinksToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator9 = new ToolStripSeparator();
			fullScreenToolStripMenuItem = new ToolStripMenuItem();
			alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
			RunMenu = new ToolStripMenuItem();
			runToolStripMenuItem1 = new ToolStripMenuItem();
			toolStripSeparator10 = new ToolStripSeparator();
			getPHPHelpToolStripMenuItem = new ToolStripMenuItem();
			wikipediaSearchToolStripMenuItem = new ToolStripMenuItem();
			toolStrip1 = new ToolStrip();
			CursorPosInfoText = new ToolStripLabel();
			ZoomInfoText = new ToolStripLabel();
			BottomToolStripSperatorLeft = new ToolStripSeparator();
			DocInfoText = new ToolStripLabel();
			contextMenuStrip1.SuspendLayout();
			TopMenuStrip.SuspendLayout();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// EditingArea
			// 
			EditingArea.AcceptsTab = true;
			EditingArea.ContextMenuStrip = contextMenuStrip1;
			EditingArea.DetectUrls = false;
			EditingArea.Dock = DockStyle.Fill;
			EditingArea.Location = new System.Drawing.Point(0, 24);
			EditingArea.Margin = new Padding(2, 3, 2, 3);
			EditingArea.Name = "EditingArea";
			EditingArea.Size = new System.Drawing.Size(609, 283);
			EditingArea.TabIndex = 0;
			EditingArea.Text = "";
			EditingArea.LinkClicked += processlink;
			EditingArea.SelectionChanged += textuasview;
			EditingArea.TextChanged += savechange;
			EditingArea.KeyDown += exitfull;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { undoToolStripMenuItem1, redoToolStripMenuItem1, cutToolStripMenuItem1, copyToolStripMenuItem1, pasteToolStripMenuItem1, deleteToolStripMenuItem1, selectAllToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(123, 158);
			// 
			// undoToolStripMenuItem1
			// 
			undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
			undoToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			undoToolStripMenuItem1.Text = "Undo";
			undoToolStripMenuItem1.Click += undoToolStripMenuItem_Click;
			// 
			// redoToolStripMenuItem1
			// 
			redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
			redoToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			redoToolStripMenuItem1.Text = "Redo";
			redoToolStripMenuItem1.Click += redoToolStripMenuItem_Click;
			// 
			// cutToolStripMenuItem1
			// 
			cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
			cutToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			cutToolStripMenuItem1.Text = "Cut";
			cutToolStripMenuItem1.Click += cutToolStripMenuItem_Click;
			// 
			// copyToolStripMenuItem1
			// 
			copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
			copyToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			copyToolStripMenuItem1.Text = "Copy";
			copyToolStripMenuItem1.Click += copyToolStripMenuItem_Click;
			// 
			// pasteToolStripMenuItem1
			// 
			pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
			pasteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			pasteToolStripMenuItem1.Text = "Paste";
			pasteToolStripMenuItem1.Click += pasteToolStripMenuItem_Click;
			// 
			// deleteToolStripMenuItem1
			// 
			deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			deleteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			deleteToolStripMenuItem1.Text = "Delete";
			deleteToolStripMenuItem1.Click += deleteToolStripMenuItem_Click;
			// 
			// selectAllToolStripMenuItem
			// 
			selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			selectAllToolStripMenuItem.Text = "Select All";
			selectAllToolStripMenuItem.Click += seleteAllToolStripMenuItem_Click;
			// 
			// TopMenuStrip
			// 
			TopMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileMenu, EditMenu, ViewMenu, RunMenu });
			TopMenuStrip.Location = new System.Drawing.Point(0, 0);
			TopMenuStrip.Name = "TopMenuStrip";
			TopMenuStrip.Padding = new Padding(5, 2, 0, 2);
			TopMenuStrip.Size = new System.Drawing.Size(609, 24);
			TopMenuStrip.TabIndex = 1;
			TopMenuStrip.Text = "menuStrip1";
			// 
			// FileMenu
			// 
			FileMenu.DropDownItems.AddRange(new ToolStripItem[] { NewFileMenuItem, OpenFileMenuItem, SaveFileMenuItem, SaveAsMenuItem, FileMenuSperator1, OpenFileFolderSubMenu, FileMenuSeparator2, NewWindowMenuItem, CloseWindowMenuItem, ExitMenuItem, ReOpenMenuItem, OpenInMSNotepadMenuItem, DeleteFileSubMenu });
			FileMenu.Name = "FileMenu";
			FileMenu.Size = new System.Drawing.Size(37, 20);
			FileMenu.Text = "File";
			// 
			// NewFileMenuItem
			// 
			NewFileMenuItem.Name = "NewFileMenuItem";
			NewFileMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			NewFileMenuItem.Size = new System.Drawing.Size(227, 22);
			NewFileMenuItem.Text = "New";
			NewFileMenuItem.Click += newToolStripMenuItem_Click;
			// 
			// OpenFileMenuItem
			// 
			OpenFileMenuItem.Name = "OpenFileMenuItem";
			OpenFileMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			OpenFileMenuItem.Size = new System.Drawing.Size(227, 22);
			OpenFileMenuItem.Text = "Open";
			OpenFileMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// SaveFileMenuItem
			// 
			SaveFileMenuItem.Name = "SaveFileMenuItem";
			SaveFileMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			SaveFileMenuItem.Size = new System.Drawing.Size(227, 22);
			SaveFileMenuItem.Text = "Save";
			SaveFileMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// SaveAsMenuItem
			// 
			SaveAsMenuItem.Name = "SaveAsMenuItem";
			SaveAsMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
			SaveAsMenuItem.Size = new System.Drawing.Size(227, 22);
			SaveAsMenuItem.Text = "Save As";
			SaveAsMenuItem.Click += saveAsToolStripMenuItem1_Click;
			// 
			// FileMenuSperator1
			// 
			FileMenuSperator1.Name = "FileMenuSperator1";
			FileMenuSperator1.Size = new System.Drawing.Size(224, 6);
			// 
			// OpenFileFolderSubMenu
			// 
			OpenFileFolderSubMenu.DropDownItems.AddRange(new ToolStripItem[] { OpenInExplorerMenuItem, OpenInCMDMenuItem });
			OpenFileFolderSubMenu.Name = "OpenFileFolderSubMenu";
			OpenFileFolderSubMenu.Size = new System.Drawing.Size(227, 22);
			OpenFileFolderSubMenu.Text = "Open File Folder";
			// 
			// OpenInExplorerMenuItem
			// 
			OpenInExplorerMenuItem.Name = "OpenInExplorerMenuItem";
			OpenInExplorerMenuItem.Size = new System.Drawing.Size(117, 22);
			OpenInExplorerMenuItem.Text = "Explorer";
			OpenInExplorerMenuItem.Click += inExplorerToolStripMenuItem_Click;
			// 
			// OpenInCMDMenuItem
			// 
			OpenInCMDMenuItem.Name = "OpenInCMDMenuItem";
			OpenInCMDMenuItem.Size = new System.Drawing.Size(117, 22);
			OpenInCMDMenuItem.Text = "CMD";
			OpenInCMDMenuItem.Click += cMDToolStripMenuItem_Click;
			// 
			// FileMenuSeparator2
			// 
			FileMenuSeparator2.Name = "FileMenuSeparator2";
			FileMenuSeparator2.Size = new System.Drawing.Size(224, 6);
			// 
			// NewWindowMenuItem
			// 
			NewWindowMenuItem.Name = "NewWindowMenuItem";
			NewWindowMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
			NewWindowMenuItem.Size = new System.Drawing.Size(227, 22);
			NewWindowMenuItem.Text = "New Window";
			NewWindowMenuItem.Click += newWindowsToolStripMenuItem_Click;
			// 
			// CloseWindowMenuItem
			// 
			CloseWindowMenuItem.Name = "CloseWindowMenuItem";
			CloseWindowMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.W;
			CloseWindowMenuItem.Size = new System.Drawing.Size(227, 22);
			CloseWindowMenuItem.Text = "Close Window";
			CloseWindowMenuItem.Click += closeWindowsToolStripMenuItem_Click;
			// 
			// ExitMenuItem
			// 
			ExitMenuItem.Name = "ExitMenuItem";
			ExitMenuItem.ShortcutKeys = Keys.Control | Keys.W;
			ExitMenuItem.Size = new System.Drawing.Size(227, 22);
			ExitMenuItem.Text = "Exit";
			ExitMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// ReOpenMenuItem
			// 
			ReOpenMenuItem.Name = "ReOpenMenuItem";
			ReOpenMenuItem.Size = new System.Drawing.Size(227, 22);
			ReOpenMenuItem.Text = "Re-Open";
			ReOpenMenuItem.Click += reopenToolStripMenuItem_Click;
			// 
			// OpenInMSNotepadMenuItem
			// 
			OpenInMSNotepadMenuItem.Name = "OpenInMSNotepadMenuItem";
			OpenInMSNotepadMenuItem.Size = new System.Drawing.Size(227, 22);
			OpenInMSNotepadMenuItem.Text = "Open In Deafult Notepad";
			OpenInMSNotepadMenuItem.Click += openInDeafultNotepadToolStripMenuItem_Click;
			// 
			// DeleteFileSubMenu
			// 
			DeleteFileSubMenu.DropDownItems.AddRange(new ToolStripItem[] { DeletePermanentlyMenuItem, MoveToRecycleBinMenuItem });
			DeleteFileSubMenu.Name = "DeleteFileSubMenu";
			DeleteFileSubMenu.Size = new System.Drawing.Size(227, 22);
			DeleteFileSubMenu.Text = "Delete File";
			// 
			// DeletePermanentlyMenuItem
			// 
			DeletePermanentlyMenuItem.Name = "DeletePermanentlyMenuItem";
			DeletePermanentlyMenuItem.Size = new System.Drawing.Size(182, 22);
			DeletePermanentlyMenuItem.Text = "Delete";
			DeletePermanentlyMenuItem.Click += toolStripMenuItem1_Click;
			// 
			// MoveToRecycleBinMenuItem
			// 
			MoveToRecycleBinMenuItem.Name = "MoveToRecycleBinMenuItem";
			MoveToRecycleBinMenuItem.Size = new System.Drawing.Size(182, 22);
			MoveToRecycleBinMenuItem.Text = "Move To Recycle Bin";
			MoveToRecycleBinMenuItem.Click += moveToTrashcanToolStripMenuItem_Click;
			// 
			// EditMenu
			// 
			EditMenu.DropDownItems.AddRange(new ToolStripItem[] { ActionUndoMenuItem, ActionRedoMenuItem, EditMenuSeparator1, ActionCutMenuItem, ActionCopyMenuItem, ActionPasteMenuItem, ActionDeleteMenuItem, ActionSelectAllMenuItem, EditMenuSeparator2, InsertDateTimeMenuItem, CopyToClipboardSubMenu, EditMenuSeparator3, GoToMenuItem, SearchInWebsiteMenuItem, EditMenuSeparator4, ReadonlyModeMenuItem });
			EditMenu.Name = "EditMenu";
			EditMenu.Size = new System.Drawing.Size(39, 20);
			EditMenu.Text = "Edit";
			// 
			// ActionUndoMenuItem
			// 
			ActionUndoMenuItem.Name = "ActionUndoMenuItem";
			ActionUndoMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
			ActionUndoMenuItem.Size = new System.Drawing.Size(180, 22);
			ActionUndoMenuItem.Text = "Undo";
			ActionUndoMenuItem.Click += undoToolStripMenuItem_Click;
			// 
			// ActionRedoMenuItem
			// 
			ActionRedoMenuItem.Name = "ActionRedoMenuItem";
			ActionRedoMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
			ActionRedoMenuItem.Size = new System.Drawing.Size(180, 22);
			ActionRedoMenuItem.Text = "Redo";
			ActionRedoMenuItem.Click += redoToolStripMenuItem_Click;
			// 
			// EditMenuSeparator1
			// 
			EditMenuSeparator1.Name = "EditMenuSeparator1";
			EditMenuSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// ActionCutMenuItem
			// 
			ActionCutMenuItem.Name = "ActionCutMenuItem";
			ActionCutMenuItem.ShortcutKeys = Keys.Control | Keys.X;
			ActionCutMenuItem.Size = new System.Drawing.Size(180, 22);
			ActionCutMenuItem.Text = "Cut";
			ActionCutMenuItem.Click += cutToolStripMenuItem_Click;
			// 
			// ActionCopyMenuItem
			// 
			ActionCopyMenuItem.Name = "ActionCopyMenuItem";
			ActionCopyMenuItem.ShortcutKeys = Keys.Control | Keys.C;
			ActionCopyMenuItem.Size = new System.Drawing.Size(180, 22);
			ActionCopyMenuItem.Text = "Copy";
			ActionCopyMenuItem.Click += copyToolStripMenuItem_Click;
			// 
			// ActionPasteMenuItem
			// 
			ActionPasteMenuItem.Name = "ActionPasteMenuItem";
			ActionPasteMenuItem.ShortcutKeys = Keys.Control | Keys.A;
			ActionPasteMenuItem.Size = new System.Drawing.Size(180, 22);
			ActionPasteMenuItem.Text = "Paste";
			ActionPasteMenuItem.Click += pasteToolStripMenuItem_Click;
			// 
			// ActionDeleteMenuItem
			// 
			ActionDeleteMenuItem.Name = "ActionDeleteMenuItem";
			ActionDeleteMenuItem.ShortcutKeys = Keys.Delete;
			ActionDeleteMenuItem.Size = new System.Drawing.Size(180, 22);
			ActionDeleteMenuItem.Text = "Delete";
			ActionDeleteMenuItem.Click += deleteToolStripMenuItem_Click;
			// 
			// ActionSelectAllMenuItem
			// 
			ActionSelectAllMenuItem.Name = "ActionSelectAllMenuItem";
			ActionSelectAllMenuItem.ShortcutKeys = Keys.Control | Keys.A;
			ActionSelectAllMenuItem.Size = new System.Drawing.Size(180, 22);
			ActionSelectAllMenuItem.Text = "Selete All";
			ActionSelectAllMenuItem.Click += seleteAllToolStripMenuItem_Click;
			// 
			// EditMenuSeparator2
			// 
			EditMenuSeparator2.Name = "EditMenuSeparator2";
			EditMenuSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// InsertDateTimeMenuItem
			// 
			InsertDateTimeMenuItem.Name = "InsertDateTimeMenuItem";
			InsertDateTimeMenuItem.ShortcutKeys = Keys.F5;
			InsertDateTimeMenuItem.Size = new System.Drawing.Size(180, 22);
			InsertDateTimeMenuItem.Text = "Time/Date";
			InsertDateTimeMenuItem.Click += timeDateToolStripMenuItem_Click;
			// 
			// CopyToClipboardSubMenu
			// 
			CopyToClipboardSubMenu.DropDownItems.AddRange(new ToolStripItem[] { CopyDirectoryWithFileMenuItem, CopyDirectoryOnlyMenuItem, CopyFileMenuItem });
			CopyToClipboardSubMenu.Name = "CopyToClipboardSubMenu";
			CopyToClipboardSubMenu.Size = new System.Drawing.Size(180, 22);
			CopyToClipboardSubMenu.Text = "Copy to Clipboard";
			// 
			// CopyDirectoryWithFileMenuItem
			// 
			CopyDirectoryWithFileMenuItem.Name = "CopyDirectoryWithFileMenuItem";
			CopyDirectoryWithFileMenuItem.Size = new System.Drawing.Size(180, 22);
			CopyDirectoryWithFileMenuItem.Text = "Directory With File";
			CopyDirectoryWithFileMenuItem.Click += directoryWithFileToolStripMenuItem_Click;
			// 
			// CopyDirectoryOnlyMenuItem
			// 
			CopyDirectoryOnlyMenuItem.Name = "CopyDirectoryOnlyMenuItem";
			CopyDirectoryOnlyMenuItem.Size = new System.Drawing.Size(180, 22);
			CopyDirectoryOnlyMenuItem.Text = "Directory";
			// 
			// CopyFileMenuItem
			// 
			CopyFileMenuItem.Name = "CopyFileMenuItem";
			CopyFileMenuItem.Size = new System.Drawing.Size(180, 22);
			CopyFileMenuItem.Text = "File";
			// 
			// EditMenuSeparator3
			// 
			EditMenuSeparator3.Name = "EditMenuSeparator3";
			EditMenuSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// GoToMenuItem
			// 
			GoToMenuItem.Name = "GoToMenuItem";
			GoToMenuItem.Size = new System.Drawing.Size(180, 22);
			GoToMenuItem.Text = "Go To";
			GoToMenuItem.Click += goToToolStripMenuItem_Click;
			// 
			// SearchInWebsiteMenuItem
			// 
			SearchInWebsiteMenuItem.Name = "SearchInWebsiteMenuItem";
			SearchInWebsiteMenuItem.Size = new System.Drawing.Size(180, 22);
			SearchInWebsiteMenuItem.Text = "Search In Website";
			SearchInWebsiteMenuItem.Click += searchInWebsiteToolStripMenuItem_Click;
			// 
			// EditMenuSeparator4
			// 
			EditMenuSeparator4.Name = "EditMenuSeparator4";
			EditMenuSeparator4.Size = new System.Drawing.Size(177, 6);
			// 
			// ReadonlyModeMenuItem
			// 
			ReadonlyModeMenuItem.CheckOnClick = true;
			ReadonlyModeMenuItem.Name = "ReadonlyModeMenuItem";
			ReadonlyModeMenuItem.Size = new System.Drawing.Size(180, 22);
			ReadonlyModeMenuItem.Text = "Readonly";
			ReadonlyModeMenuItem.Click += readonlyToolStripMenuItem_Click_1;
			// 
			// ViewMenu
			// 
			ViewMenu.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, wordWrapToolStripMenuItem, statusToolStripMenuItem, toolStripSeparator8, showLinksToolStripMenuItem, toolStripSeparator9, fullScreenToolStripMenuItem, alwaysOnTopToolStripMenuItem });
			ViewMenu.Name = "ViewMenu";
			ViewMenu.Size = new System.Drawing.Size(44, 20);
			ViewMenu.Text = "View";
			// 
			// zoomToolStripMenuItem
			// 
			zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, resetZoomToolStripMenuItem });
			zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
			zoomToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			zoomToolStripMenuItem.Text = "Zoom";
			// 
			// zoomInToolStripMenuItem
			// 
			zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
			zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
			zoomInToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			zoomInToolStripMenuItem.Text = "Zoom In";
			zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click_1;
			// 
			// zoomOutToolStripMenuItem
			// 
			zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
			zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
			zoomOutToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			zoomOutToolStripMenuItem.Text = "Zoom Out";
			zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click_1;
			// 
			// resetZoomToolStripMenuItem
			// 
			resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
			resetZoomToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
			resetZoomToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			resetZoomToolStripMenuItem.Text = "Reset Zoom";
			resetZoomToolStripMenuItem.Click += resetZoomToolStripMenuItem_Click_1;
			// 
			// wordWrapToolStripMenuItem
			// 
			wordWrapToolStripMenuItem.Checked = true;
			wordWrapToolStripMenuItem.CheckOnClick = true;
			wordWrapToolStripMenuItem.CheckState = CheckState.Checked;
			wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
			wordWrapToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			wordWrapToolStripMenuItem.Text = "Word Wrap";
			wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
			// 
			// statusToolStripMenuItem
			// 
			statusToolStripMenuItem.Checked = true;
			statusToolStripMenuItem.CheckOnClick = true;
			statusToolStripMenuItem.CheckState = CheckState.Checked;
			statusToolStripMenuItem.Name = "statusToolStripMenuItem";
			statusToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			statusToolStripMenuItem.Text = "Status ";
			statusToolStripMenuItem.Click += statusToolStripMenuItem_Click;
			// 
			// toolStripSeparator8
			// 
			toolStripSeparator8.Name = "toolStripSeparator8";
			toolStripSeparator8.Size = new System.Drawing.Size(153, 6);
			// 
			// showLinksToolStripMenuItem
			// 
			showLinksToolStripMenuItem.CheckOnClick = true;
			showLinksToolStripMenuItem.Name = "showLinksToolStripMenuItem";
			showLinksToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			showLinksToolStripMenuItem.Text = "Show Links";
			showLinksToolStripMenuItem.Click += showLinksToolStripMenuItem_Click;
			// 
			// toolStripSeparator9
			// 
			toolStripSeparator9.Name = "toolStripSeparator9";
			toolStripSeparator9.Size = new System.Drawing.Size(153, 6);
			// 
			// fullScreenToolStripMenuItem
			// 
			fullScreenToolStripMenuItem.CheckOnClick = true;
			fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
			fullScreenToolStripMenuItem.ShortcutKeys = Keys.F11;
			fullScreenToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			fullScreenToolStripMenuItem.Text = "Full Screen";
			fullScreenToolStripMenuItem.Click += fullScreenToolStripMenuItem_Click;
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			alwaysOnTopToolStripMenuItem.CheckOnClick = true;
			alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			alwaysOnTopToolStripMenuItem.Text = "Always On top";
			alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
			// 
			// RunMenu
			// 
			RunMenu.DropDownItems.AddRange(new ToolStripItem[] { runToolStripMenuItem1, toolStripSeparator10, getPHPHelpToolStripMenuItem, wikipediaSearchToolStripMenuItem });
			RunMenu.Name = "RunMenu";
			RunMenu.Size = new System.Drawing.Size(40, 20);
			RunMenu.Text = "Run";
			// 
			// runToolStripMenuItem1
			// 
			runToolStripMenuItem1.Name = "runToolStripMenuItem1";
			runToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
			runToolStripMenuItem1.Text = "Run";
			runToolStripMenuItem1.Click += runToolStripMenuItem1_Click;
			// 
			// toolStripSeparator10
			// 
			toolStripSeparator10.Name = "toolStripSeparator10";
			toolStripSeparator10.Size = new System.Drawing.Size(161, 6);
			// 
			// getPHPHelpToolStripMenuItem
			// 
			getPHPHelpToolStripMenuItem.Name = "getPHPHelpToolStripMenuItem";
			getPHPHelpToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			getPHPHelpToolStripMenuItem.Text = "Get PHP Help";
			getPHPHelpToolStripMenuItem.Click += getPHPHelpToolStripMenuItem_Click;
			// 
			// wikipediaSearchToolStripMenuItem
			// 
			wikipediaSearchToolStripMenuItem.Name = "wikipediaSearchToolStripMenuItem";
			wikipediaSearchToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			wikipediaSearchToolStripMenuItem.Text = "Wikipedia Search";
			wikipediaSearchToolStripMenuItem.Click += wikipediaSearchToolStripMenuItem_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.Dock = DockStyle.Bottom;
			toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { CursorPosInfoText, ZoomInfoText, BottomToolStripSperatorLeft, DocInfoText });
			toolStrip1.Location = new System.Drawing.Point(0, 282);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new System.Drawing.Size(609, 25);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "BottomToolStrip";
			// 
			// CursorPosInfoText
			// 
			CursorPosInfoText.Name = "CursorPosInfoText";
			CursorPosInfoText.Size = new System.Drawing.Size(82, 22);
			CursorPosInfoText.Text = "CursorPosInfo";
			// 
			// ZoomInfoText
			// 
			ZoomInfoText.Alignment = ToolStripItemAlignment.Right;
			ZoomInfoText.Name = "ZoomInfoText";
			ZoomInfoText.Size = new System.Drawing.Size(60, 22);
			ZoomInfoText.Text = "ZoomInfo";
			// 
			// BottomToolStripSperatorLeft
			// 
			BottomToolStripSperatorLeft.Name = "BottomToolStripSperatorLeft";
			BottomToolStripSperatorLeft.Size = new System.Drawing.Size(6, 25);
			// 
			// DocInfoText
			// 
			DocInfoText.Alignment = ToolStripItemAlignment.Right;
			DocInfoText.Name = "DocInfoText";
			DocInfoText.Size = new System.Drawing.Size(49, 22);
			DocInfoText.Text = "DocInfo";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(609, 307);
			Controls.Add(toolStrip1);
			Controls.Add(EditingArea);
			Controls.Add(TopMenuStrip);
			MainMenuStrip = TopMenuStrip;
			Margin = new Padding(2, 3, 2, 3);
			Name = "MainForm";
			Text = "MainForm";
			FormClosing += exitconfirm;
			contextMenuStrip1.ResumeLayout(false);
			TopMenuStrip.ResumeLayout(false);
			TopMenuStrip.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.MenuStrip TopMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileMenu;
		private System.Windows.Forms.ToolStripMenuItem NewFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditMenu;
		private System.Windows.Forms.ToolStripMenuItem ViewMenu;
		private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel CursorPosInfoText;
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
		private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewWindowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CloseWindowMenuItem;
		private System.Windows.Forms.ToolStripLabel ZoomInfoText;
		private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetZoomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyToClipboardSubMenu;
		private System.Windows.Forms.ToolStripMenuItem CopyDirectoryWithFileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyDirectoryOnlyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyFileMenuItem;
		private System.Windows.Forms.ToolStripLabel DocInfoText;
		private System.Windows.Forms.ToolStripSeparator BottomToolStripSperatorLeft;
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
		private System.Windows.Forms.ToolStripMenuItem showLinksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GoToMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RunMenu;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem getPHPHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wikipediaSearchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SearchInWebsiteMenuItem;
		public System.Windows.Forms.RichTextBox EditingArea;
		private System.Windows.Forms.ToolStripSeparator FileMenuSperator1;
		private System.Windows.Forms.ToolStripSeparator FileMenuSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ReadonlyModeMenuItem;
		private System.Windows.Forms.ToolStripSeparator EditMenuSeparator3;
		private System.Windows.Forms.ToolStripSeparator EditMenuSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripMenuItem ReOpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenInMSNotepadMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeletePermanentlyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteFileSubMenu;
		private System.Windows.Forms.ToolStripMenuItem MoveToRecycleBinMenuItem;
	}
}

