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
			EditingArea.LinkClicked += OpenLink;
			EditingArea.SelectionChanged += EditingAreaOnSelectionChange;
			EditingArea.TextChanged += OnEditingAreaTextChange;
			EditingArea.KeyDown += ExitFullscreen;
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
			undoToolStripMenuItem1.Click += UndoMenuItem_Click;
			// 
			// redoToolStripMenuItem1
			// 
			redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
			redoToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			redoToolStripMenuItem1.Text = "Redo";
			redoToolStripMenuItem1.Click += RedoMenuItem_Click;
			// 
			// cutToolStripMenuItem1
			// 
			cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
			cutToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			cutToolStripMenuItem1.Text = "Cut";
			cutToolStripMenuItem1.Click += CutMenuItem_Click;
			// 
			// copyToolStripMenuItem1
			// 
			copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
			copyToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			copyToolStripMenuItem1.Text = "Copy";
			copyToolStripMenuItem1.Click += CopyMenuItem_Click;
			// 
			// pasteToolStripMenuItem1
			// 
			pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
			pasteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			pasteToolStripMenuItem1.Text = "Paste";
			pasteToolStripMenuItem1.Click += PasteMenuItem_Click;
			// 
			// deleteToolStripMenuItem1
			// 
			deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			deleteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			deleteToolStripMenuItem1.Text = "Delete";
			deleteToolStripMenuItem1.Click += DeleteMenuItem_Click;
			// 
			// selectAllToolStripMenuItem
			// 
			selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			selectAllToolStripMenuItem.Text = "Select All";
			selectAllToolStripMenuItem.Click += SelectMenuItem_Click;
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
			NewFileMenuItem.Click += NewFileEvent;
			// 
			// OpenFileMenuItem
			// 
			OpenFileMenuItem.Name = "OpenFileMenuItem";
			OpenFileMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			OpenFileMenuItem.Size = new System.Drawing.Size(227, 22);
			OpenFileMenuItem.Text = "Open";
			OpenFileMenuItem.Click += OpenFileEvent;
			// 
			// SaveFileMenuItem
			// 
			SaveFileMenuItem.Name = "SaveFileMenuItem";
			SaveFileMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			SaveFileMenuItem.Size = new System.Drawing.Size(227, 22);
			SaveFileMenuItem.Text = "Save";
			SaveFileMenuItem.Click += SaveFileEvent;
			// 
			// SaveAsMenuItem
			// 
			SaveAsMenuItem.Name = "SaveAsMenuItem";
			SaveAsMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
			SaveAsMenuItem.Size = new System.Drawing.Size(227, 22);
			SaveAsMenuItem.Text = "Save As";
			SaveAsMenuItem.Click += SaveAsEvent;
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
			OpenInExplorerMenuItem.Click += OpenInExplorer;
			// 
			// OpenInCMDMenuItem
			// 
			OpenInCMDMenuItem.Name = "OpenInCMDMenuItem";
			OpenInCMDMenuItem.Size = new System.Drawing.Size(117, 22);
			OpenInCMDMenuItem.Text = "CMD";
			OpenInCMDMenuItem.Click += OpenInCMD;
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
			NewWindowMenuItem.Click += OpenNewWindow;
			// 
			// CloseWindowMenuItem
			// 
			CloseWindowMenuItem.Name = "CloseWindowMenuItem";
			CloseWindowMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.W;
			CloseWindowMenuItem.Size = new System.Drawing.Size(227, 22);
			CloseWindowMenuItem.Text = "Close Window";
			CloseWindowMenuItem.Click += CloseWindowEvent;
			// 
			// ExitMenuItem
			// 
			ExitMenuItem.Name = "ExitMenuItem";
			ExitMenuItem.ShortcutKeys = Keys.Control | Keys.W;
			ExitMenuItem.Size = new System.Drawing.Size(227, 22);
			ExitMenuItem.Text = "Exit";
			ExitMenuItem.Click += ExitEvent;
			// 
			// ReOpenMenuItem
			// 
			ReOpenMenuItem.Name = "ReOpenMenuItem";
			ReOpenMenuItem.Size = new System.Drawing.Size(227, 22);
			ReOpenMenuItem.Text = "Re-Open";
			ReOpenMenuItem.Click += ReOpenMenuItem_Click;
			// 
			// OpenInMSNotepadMenuItem
			// 
			OpenInMSNotepadMenuItem.Name = "OpenInMSNotepadMenuItem";
			OpenInMSNotepadMenuItem.Size = new System.Drawing.Size(227, 22);
			OpenInMSNotepadMenuItem.Text = "Open In Deafult Notepad";
			OpenInMSNotepadMenuItem.Click += OpenInMSNotepadMenuItem_Click;
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
			DeletePermanentlyMenuItem.Click += DeletePermanentlyMenuItem_Click;
			// 
			// MoveToRecycleBinMenuItem
			// 
			MoveToRecycleBinMenuItem.Name = "MoveToRecycleBinMenuItem";
			MoveToRecycleBinMenuItem.Size = new System.Drawing.Size(182, 22);
			MoveToRecycleBinMenuItem.Text = "Move To Recycle Bin";
			MoveToRecycleBinMenuItem.Click += RemoveFileMenuItem_Click;
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
			ActionUndoMenuItem.Size = new System.Drawing.Size(172, 22);
			ActionUndoMenuItem.Text = "Undo";
			ActionUndoMenuItem.Click += UndoMenuItem_Click;
			// 
			// ActionRedoMenuItem
			// 
			ActionRedoMenuItem.Name = "ActionRedoMenuItem";
			ActionRedoMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
			ActionRedoMenuItem.Size = new System.Drawing.Size(172, 22);
			ActionRedoMenuItem.Text = "Redo";
			ActionRedoMenuItem.Click += RedoMenuItem_Click;
			// 
			// EditMenuSeparator1
			// 
			EditMenuSeparator1.Name = "EditMenuSeparator1";
			EditMenuSeparator1.Size = new System.Drawing.Size(169, 6);
			// 
			// ActionCutMenuItem
			// 
			ActionCutMenuItem.Name = "ActionCutMenuItem";
			ActionCutMenuItem.ShortcutKeys = Keys.Control | Keys.X;
			ActionCutMenuItem.Size = new System.Drawing.Size(172, 22);
			ActionCutMenuItem.Text = "Cut";
			ActionCutMenuItem.Click += CutMenuItem_Click;
			// 
			// ActionCopyMenuItem
			// 
			ActionCopyMenuItem.Name = "ActionCopyMenuItem";
			ActionCopyMenuItem.ShortcutKeys = Keys.Control | Keys.C;
			ActionCopyMenuItem.Size = new System.Drawing.Size(172, 22);
			ActionCopyMenuItem.Text = "Copy";
			ActionCopyMenuItem.Click += CopyMenuItem_Click;
			// 
			// ActionPasteMenuItem
			// 
			ActionPasteMenuItem.Name = "ActionPasteMenuItem";
			ActionPasteMenuItem.ShortcutKeys = Keys.Control | Keys.A;
			ActionPasteMenuItem.Size = new System.Drawing.Size(172, 22);
			ActionPasteMenuItem.Text = "Paste";
			ActionPasteMenuItem.Click += PasteMenuItem_Click;
			// 
			// ActionDeleteMenuItem
			// 
			ActionDeleteMenuItem.Name = "ActionDeleteMenuItem";
			ActionDeleteMenuItem.ShortcutKeys = Keys.Delete;
			ActionDeleteMenuItem.Size = new System.Drawing.Size(172, 22);
			ActionDeleteMenuItem.Text = "Delete";
			ActionDeleteMenuItem.Click += DeleteMenuItem_Click;
			// 
			// ActionSelectAllMenuItem
			// 
			ActionSelectAllMenuItem.Name = "ActionSelectAllMenuItem";
			ActionSelectAllMenuItem.ShortcutKeys = Keys.Control | Keys.A;
			ActionSelectAllMenuItem.Size = new System.Drawing.Size(172, 22);
			ActionSelectAllMenuItem.Text = "Selete All";
			ActionSelectAllMenuItem.Click += SelectMenuItem_Click;
			// 
			// EditMenuSeparator2
			// 
			EditMenuSeparator2.Name = "EditMenuSeparator2";
			EditMenuSeparator2.Size = new System.Drawing.Size(169, 6);
			// 
			// InsertDateTimeMenuItem
			// 
			InsertDateTimeMenuItem.Name = "InsertDateTimeMenuItem";
			InsertDateTimeMenuItem.ShortcutKeys = Keys.F5;
			InsertDateTimeMenuItem.Size = new System.Drawing.Size(172, 22);
			InsertDateTimeMenuItem.Text = "Time/Date";
			InsertDateTimeMenuItem.Click += InsertDateTime;
			// 
			// CopyToClipboardSubMenu
			// 
			CopyToClipboardSubMenu.DropDownItems.AddRange(new ToolStripItem[] { CopyDirectoryWithFileMenuItem, CopyDirectoryOnlyMenuItem, CopyFileMenuItem });
			CopyToClipboardSubMenu.Name = "CopyToClipboardSubMenu";
			CopyToClipboardSubMenu.Size = new System.Drawing.Size(172, 22);
			CopyToClipboardSubMenu.Text = "Copy to Clipboard";
			// 
			// CopyDirectoryWithFileMenuItem
			// 
			CopyDirectoryWithFileMenuItem.Name = "CopyDirectoryWithFileMenuItem";
			CopyDirectoryWithFileMenuItem.Size = new System.Drawing.Size(171, 22);
			CopyDirectoryWithFileMenuItem.Text = "Directory With File";
			CopyDirectoryWithFileMenuItem.Click += CopyDirectoryPath;
			// 
			// CopyDirectoryOnlyMenuItem
			// 
			CopyDirectoryOnlyMenuItem.Name = "CopyDirectoryOnlyMenuItem";
			CopyDirectoryOnlyMenuItem.Size = new System.Drawing.Size(171, 22);
			CopyDirectoryOnlyMenuItem.Text = "Directory";
			// 
			// CopyFileMenuItem
			// 
			CopyFileMenuItem.Name = "CopyFileMenuItem";
			CopyFileMenuItem.Size = new System.Drawing.Size(171, 22);
			CopyFileMenuItem.Text = "File";
			// 
			// EditMenuSeparator3
			// 
			EditMenuSeparator3.Name = "EditMenuSeparator3";
			EditMenuSeparator3.Size = new System.Drawing.Size(169, 6);
			// 
			// GoToMenuItem
			// 
			GoToMenuItem.Name = "GoToMenuItem";
			GoToMenuItem.Size = new System.Drawing.Size(172, 22);
			GoToMenuItem.Text = "Go To";
			GoToMenuItem.Click += GoToMenuItem_Click;
			// 
			// SearchInWebsiteMenuItem
			// 
			SearchInWebsiteMenuItem.Name = "SearchInWebsiteMenuItem";
			SearchInWebsiteMenuItem.Size = new System.Drawing.Size(172, 22);
			SearchInWebsiteMenuItem.Text = "Search In Websites";
			SearchInWebsiteMenuItem.Click += SearchInWebsiteMenuItem_Click;
			// 
			// EditMenuSeparator4
			// 
			EditMenuSeparator4.Name = "EditMenuSeparator4";
			EditMenuSeparator4.Size = new System.Drawing.Size(169, 6);
			// 
			// ReadonlyModeMenuItem
			// 
			ReadonlyModeMenuItem.CheckOnClick = true;
			ReadonlyModeMenuItem.Name = "ReadonlyModeMenuItem";
			ReadonlyModeMenuItem.Size = new System.Drawing.Size(172, 22);
			ReadonlyModeMenuItem.Text = "Readonly";
			ReadonlyModeMenuItem.Click += ToggleReadOnlyMode;
			// 
			// ViewMenu
			// 
			ViewMenu.DropDownItems.AddRange(new ToolStripItem[] { ZoomSubMenu, WordWarpToggleMenuItem, StatusToggleMenuItem, ViewMenuSeparator1, ShowLinksToggleItem, ViewMenuSeparator2, FullScreenToggleMenuItem, AlwaysOnTopToggleMenuItem });
			ViewMenu.Name = "ViewMenu";
			ViewMenu.Size = new System.Drawing.Size(44, 20);
			ViewMenu.Text = "View";
			// 
			// ZoomSubMenu
			// 
			ZoomSubMenu.DropDownItems.AddRange(new ToolStripItem[] { ZoomInMenuItem, ZoomOutMenuItem, ResetZoomMenuItem });
			ZoomSubMenu.Name = "ZoomSubMenu";
			ZoomSubMenu.Size = new System.Drawing.Size(156, 22);
			ZoomSubMenu.Text = "Zoom";
			// 
			// ZoomInMenuItem
			// 
			ZoomInMenuItem.Name = "ZoomInMenuItem";
			ZoomInMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
			ZoomInMenuItem.Size = new System.Drawing.Size(222, 22);
			ZoomInMenuItem.Text = "Zoom In";
			ZoomInMenuItem.Click += ZoomIn;
			// 
			// ZoomOutMenuItem
			// 
			ZoomOutMenuItem.Name = "ZoomOutMenuItem";
			ZoomOutMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
			ZoomOutMenuItem.Size = new System.Drawing.Size(222, 22);
			ZoomOutMenuItem.Text = "Zoom Out";
			ZoomOutMenuItem.Click += ZoomOut;
			// 
			// ResetZoomMenuItem
			// 
			ResetZoomMenuItem.Name = "ResetZoomMenuItem";
			ResetZoomMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
			ResetZoomMenuItem.Size = new System.Drawing.Size(222, 22);
			ResetZoomMenuItem.Text = "Reset Zoom";
			ResetZoomMenuItem.Click += ResetZoom;
			// 
			// WordWarpToggleMenuItem
			// 
			WordWarpToggleMenuItem.Checked = true;
			WordWarpToggleMenuItem.CheckOnClick = true;
			WordWarpToggleMenuItem.CheckState = CheckState.Checked;
			WordWarpToggleMenuItem.Name = "WordWarpToggleMenuItem";
			WordWarpToggleMenuItem.Size = new System.Drawing.Size(156, 22);
			WordWarpToggleMenuItem.Text = "Word Wrap";
			WordWarpToggleMenuItem.Click += ToggleWordWarp;
			// 
			// StatusToggleMenuItem
			// 
			StatusToggleMenuItem.Checked = true;
			StatusToggleMenuItem.CheckOnClick = true;
			StatusToggleMenuItem.CheckState = CheckState.Checked;
			StatusToggleMenuItem.Name = "StatusToggleMenuItem";
			StatusToggleMenuItem.Size = new System.Drawing.Size(156, 22);
			StatusToggleMenuItem.Text = "Status ";
			StatusToggleMenuItem.Click += ToggleStatus;
			// 
			// ViewMenuSeparator1
			// 
			ViewMenuSeparator1.Name = "ViewMenuSeparator1";
			ViewMenuSeparator1.Size = new System.Drawing.Size(153, 6);
			// 
			// ShowLinksToggleItem
			// 
			ShowLinksToggleItem.CheckOnClick = true;
			ShowLinksToggleItem.Name = "ShowLinksToggleItem";
			ShowLinksToggleItem.Size = new System.Drawing.Size(156, 22);
			ShowLinksToggleItem.Text = "Show Links";
			ShowLinksToggleItem.Click += ToggleShowLinks;
			// 
			// ViewMenuSeparator2
			// 
			ViewMenuSeparator2.Name = "ViewMenuSeparator2";
			ViewMenuSeparator2.Size = new System.Drawing.Size(153, 6);
			// 
			// FullScreenToggleMenuItem
			// 
			FullScreenToggleMenuItem.CheckOnClick = true;
			FullScreenToggleMenuItem.Name = "FullScreenToggleMenuItem";
			FullScreenToggleMenuItem.ShortcutKeys = Keys.F11;
			FullScreenToggleMenuItem.Size = new System.Drawing.Size(156, 22);
			FullScreenToggleMenuItem.Text = "Full Screen";
			FullScreenToggleMenuItem.Click += ToggleFullScreen;
			// 
			// AlwaysOnTopToggleMenuItem
			// 
			AlwaysOnTopToggleMenuItem.CheckOnClick = true;
			AlwaysOnTopToggleMenuItem.Name = "AlwaysOnTopToggleMenuItem";
			AlwaysOnTopToggleMenuItem.Size = new System.Drawing.Size(156, 22);
			AlwaysOnTopToggleMenuItem.Text = "Always On top";
			AlwaysOnTopToggleMenuItem.Click += ToggleAlwaysOnTop;
			// 
			// RunMenu
			// 
			RunMenu.DropDownItems.AddRange(new ToolStripItem[] { RunMenuItem, RunMenuSeparator1, GetPHPHelpMenuItem, WikipediaSearchMenuItem });
			RunMenu.Name = "RunMenu";
			RunMenu.Size = new System.Drawing.Size(40, 20);
			RunMenu.Text = "Run";
			// 
			// RunMenuItem
			// 
			RunMenuItem.Name = "RunMenuItem";
			RunMenuItem.Size = new System.Drawing.Size(164, 22);
			RunMenuItem.Text = "Run";
			RunMenuItem.Click += RunMenuItem_Click;
			// 
			// RunMenuSeparator1
			// 
			RunMenuSeparator1.Name = "RunMenuSeparator1";
			RunMenuSeparator1.Size = new System.Drawing.Size(161, 6);
			// 
			// GetPHPHelpMenuItem
			// 
			GetPHPHelpMenuItem.Name = "GetPHPHelpMenuItem";
			GetPHPHelpMenuItem.Size = new System.Drawing.Size(164, 22);
			GetPHPHelpMenuItem.Text = "Get PHP Help";
			GetPHPHelpMenuItem.Click += GetPHPHelpMenuItem_Click;
			// 
			// WikipediaSearchMenuItem
			// 
			WikipediaSearchMenuItem.Name = "WikipediaSearchMenuItem";
			WikipediaSearchMenuItem.Size = new System.Drawing.Size(164, 22);
			WikipediaSearchMenuItem.Text = "Wikipedia Search";
			WikipediaSearchMenuItem.Click += SearchInWikipediaMenuItem_Click;
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
			FormClosing += ExitConfirm;
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
		private System.Windows.Forms.ToolStripMenuItem WordWarpToggleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem StatusToggleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewWindowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CloseWindowMenuItem;
		private System.Windows.Forms.ToolStripLabel ZoomInfoText;
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
		private System.Windows.Forms.ToolStripMenuItem ShowLinksToggleItem;
		private System.Windows.Forms.ToolStripMenuItem GoToMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RunMenu;
		private System.Windows.Forms.ToolStripMenuItem RunMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GetPHPHelpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem WikipediaSearchMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SearchInWebsiteMenuItem;
		public System.Windows.Forms.RichTextBox EditingArea;
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
	}
}

