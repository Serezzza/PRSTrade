namespace DevExpress.XtraRichEdit.Demos {
    partial class HyperlinkClickHandlingModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HyperlinkClickHandlingModule));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.clipboardBar1 = new DevExpress.XtraRichEdit.UI.ClipboardBar();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.fontBar1 = new DevExpress.XtraRichEdit.UI.FontBar();
            this.changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            this.changeFontBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem();
            this.toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            this.toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            this.toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            this.toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            this.toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            this.toggleFontDoubleStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem();
            this.toggleFontSuperscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem();
            this.toggleFontSubscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem();
            this.fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            this.fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            this.showFontFormItem1 = new DevExpress.XtraRichEdit.UI.ShowFontFormItem();
            this.linksBar1 = new DevExpress.XtraRichEdit.UI.LinksBar();
            this.insertBookmarkItem1 = new DevExpress.XtraRichEdit.UI.InsertBookmarkItem();
            this.insertHyperlinkItem1 = new DevExpress.XtraRichEdit.UI.InsertHyperlinkItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            this.printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            this.printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.insertSymbolItem1 = new DevExpress.XtraRichEdit.UI.InsertSymbolItem();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.clipboardBar1,
            this.fontBar1,
            this.linksBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.quickPrintItem1,
            this.printItem1,
            this.printPreviewItem1,
            this.undoItem1,
            this.redoItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteItem1,
            this.insertSymbolItem1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.changeFontColorItem1,
            this.changeFontBackColorItem1,
            this.toggleFontBoldItem1,
            this.toggleFontItalicItem1,
            this.toggleFontUnderlineItem1,
            this.toggleFontDoubleUnderlineItem1,
            this.toggleFontStrikeoutItem1,
            this.toggleFontDoubleStrikeoutItem1,
            this.toggleFontSuperscriptItem1,
            this.toggleFontSubscriptItem1,
            this.fontSizeIncreaseItem1,
            this.fontSizeDecreaseItem1,
            this.clearFormattingItem1,
            this.showFontFormItem1,
            this.insertBookmarkItem1,
            this.insertHyperlinkItem1});
            this.barManager1.MaxItemId = 32;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemRichEditFontSizeEdit1});
            // 
            // clipboardBar1
            // 
            this.clipboardBar1.DockCol = 1;
            this.clipboardBar1.DockRow = 0;
            this.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.clipboardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.copyItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pasteItem1)});
            this.clipboardBar1.Offset = 489;
            // 
            // cutItem1
            // 
            this.cutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.Glyph")));
            this.cutItem1.Id = 10;
            this.cutItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.cutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.LargeGlyph")));
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.Glyph")));
            this.copyItem1.Id = 11;
            this.copyItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.copyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.LargeGlyph")));
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteItem1
            // 
            this.pasteItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.Glyph")));
            this.pasteItem1.Id = 12;
            this.pasteItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.pasteItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.LargeGlyph")));
            this.pasteItem1.Name = "pasteItem1";
            // 
            // fontBar1
            // 
            this.fontBar1.DockCol = 0;
            this.fontBar1.DockRow = 0;
            this.fontBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.fontBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.changeFontNameItem1, "", false, true, true, 140),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeFontSizeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeFontColorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeFontBackColorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontBoldItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontItalicItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontUnderlineItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontDoubleUnderlineItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontStrikeoutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontDoubleStrikeoutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontSuperscriptItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontSubscriptItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fontSizeIncreaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fontSizeDecreaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.clearFormattingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showFontFormItem1)});
            // 
            // changeFontNameItem1
            // 
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
            this.changeFontNameItem1.Id = 13;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // changeFontSizeItem1
            // 
            this.changeFontSizeItem1.Edit = this.repositoryItemRichEditFontSizeEdit1;
            this.changeFontSizeItem1.Id = 14;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit1.Control = this.richEditControl;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // richEditControl
            // 
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.Location = new System.Drawing.Point(0, 26);
            this.richEditControl.MenuManager = this;
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Options.Hyperlinks.ModifierKeys = System.Windows.Forms.Keys.None;
            this.richEditControl.Size = new System.Drawing.Size(845, 363);
            this.richEditControl.TabIndex = 4;
            this.richEditControl.Text = "richEditControl1";
            // 
            // changeFontColorItem1
            // 
            this.changeFontColorItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeFontColorItem1.Glyph")));
            this.changeFontColorItem1.Id = 15;
            this.changeFontColorItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeFontColorItem1.LargeGlyph")));
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // changeFontBackColorItem1
            // 
            this.changeFontBackColorItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeFontBackColorItem1.Glyph")));
            this.changeFontBackColorItem1.Id = 16;
            this.changeFontBackColorItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeFontBackColorItem1.LargeGlyph")));
            this.changeFontBackColorItem1.Name = "changeFontBackColorItem1";
            // 
            // toggleFontBoldItem1
            // 
            this.toggleFontBoldItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontBoldItem1.Glyph")));
            this.toggleFontBoldItem1.Id = 17;
            this.toggleFontBoldItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.toggleFontBoldItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontBoldItem1.LargeGlyph")));
            this.toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            // 
            // toggleFontItalicItem1
            // 
            this.toggleFontItalicItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontItalicItem1.Glyph")));
            this.toggleFontItalicItem1.Id = 18;
            this.toggleFontItalicItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.toggleFontItalicItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontItalicItem1.LargeGlyph")));
            this.toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            // 
            // toggleFontUnderlineItem1
            // 
            this.toggleFontUnderlineItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontUnderlineItem1.Glyph")));
            this.toggleFontUnderlineItem1.Id = 19;
            this.toggleFontUnderlineItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.toggleFontUnderlineItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontUnderlineItem1.LargeGlyph")));
            this.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            // 
            // toggleFontDoubleUnderlineItem1
            // 
            this.toggleFontDoubleUnderlineItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontDoubleUnderlineItem1.Glyph")));
            this.toggleFontDoubleUnderlineItem1.Id = 20;
            this.toggleFontDoubleUnderlineItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                            | System.Windows.Forms.Keys.D));
            this.toggleFontDoubleUnderlineItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontDoubleUnderlineItem1.LargeGlyph")));
            this.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            // 
            // toggleFontStrikeoutItem1
            // 
            this.toggleFontStrikeoutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontStrikeoutItem1.Glyph")));
            this.toggleFontStrikeoutItem1.Id = 21;
            this.toggleFontStrikeoutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontStrikeoutItem1.LargeGlyph")));
            this.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            // 
            // toggleFontDoubleStrikeoutItem1
            // 
            this.toggleFontDoubleStrikeoutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontDoubleStrikeoutItem1.Glyph")));
            this.toggleFontDoubleStrikeoutItem1.Id = 22;
            this.toggleFontDoubleStrikeoutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontDoubleStrikeoutItem1.LargeGlyph")));
            this.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1";
            // 
            // toggleFontSuperscriptItem1
            // 
            this.toggleFontSuperscriptItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontSuperscriptItem1.Glyph")));
            this.toggleFontSuperscriptItem1.Id = 23;
            this.toggleFontSuperscriptItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                            | System.Windows.Forms.Keys.Oemplus));
            this.toggleFontSuperscriptItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontSuperscriptItem1.LargeGlyph")));
            this.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1";
            // 
            // toggleFontSubscriptItem1
            // 
            this.toggleFontSubscriptItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleFontSubscriptItem1.Glyph")));
            this.toggleFontSubscriptItem1.Id = 24;
            this.toggleFontSubscriptItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus));
            this.toggleFontSubscriptItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleFontSubscriptItem1.LargeGlyph")));
            this.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1";
            // 
            // fontSizeIncreaseItem1
            // 
            this.fontSizeIncreaseItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fontSizeIncreaseItem1.Glyph")));
            this.fontSizeIncreaseItem1.Id = 25;
            this.fontSizeIncreaseItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                            | System.Windows.Forms.Keys.OemPeriod));
            this.fontSizeIncreaseItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fontSizeIncreaseItem1.LargeGlyph")));
            this.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            // 
            // fontSizeDecreaseItem1
            // 
            this.fontSizeDecreaseItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fontSizeDecreaseItem1.Glyph")));
            this.fontSizeDecreaseItem1.Id = 26;
            this.fontSizeDecreaseItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                            | System.Windows.Forms.Keys.Oemcomma));
            this.fontSizeDecreaseItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fontSizeDecreaseItem1.LargeGlyph")));
            this.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            // 
            // clearFormattingItem1
            // 
            this.clearFormattingItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("clearFormattingItem1.Glyph")));
            this.clearFormattingItem1.Id = 27;
            this.clearFormattingItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("clearFormattingItem1.LargeGlyph")));
            this.clearFormattingItem1.Name = "clearFormattingItem1";
            // 
            // showFontFormItem1
            // 
            this.showFontFormItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("showFontFormItem1.Glyph")));
            this.showFontFormItem1.Id = 28;
            this.showFontFormItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.showFontFormItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showFontFormItem1.LargeGlyph")));
            this.showFontFormItem1.Name = "showFontFormItem1";
            // 
            // linksBar1
            // 
            this.linksBar1.DockCol = 2;
            this.linksBar1.DockRow = 0;
            this.linksBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.linksBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.insertBookmarkItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.insertHyperlinkItem1)});
            // 
            // insertBookmarkItem1
            // 
            this.insertBookmarkItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertBookmarkItem1.Glyph")));
            this.insertBookmarkItem1.Id = 30;
            this.insertBookmarkItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertBookmarkItem1.LargeGlyph")));
            this.insertBookmarkItem1.Name = "insertBookmarkItem1";
            // 
            // insertHyperlinkItem1
            // 
            this.insertHyperlinkItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertHyperlinkItem1.Glyph")));
            this.insertHyperlinkItem1.Id = 31;
            this.insertHyperlinkItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertHyperlinkItem1.LargeGlyph")));
            this.insertHyperlinkItem1.Name = "insertHyperlinkItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileNewItem1.Glyph")));
            this.fileNewItem1.Id = 1;
            this.fileNewItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.fileNewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileNewItem1.LargeGlyph")));
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileOpenItem1.Glyph")));
            this.fileOpenItem1.Id = 2;
            this.fileOpenItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.fileOpenItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileOpenItem1.LargeGlyph")));
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem1.Glyph")));
            this.fileSaveItem1.Id = 3;
            this.fileSaveItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.fileSaveItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem1.LargeGlyph")));
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveAsItem1.Glyph")));
            this.fileSaveAsItem1.Id = 4;
            this.fileSaveAsItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.fileSaveAsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveAsItem1.LargeGlyph")));
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // quickPrintItem1
            // 
            this.quickPrintItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("quickPrintItem1.Glyph")));
            this.quickPrintItem1.Id = 5;
            this.quickPrintItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("quickPrintItem1.LargeGlyph")));
            this.quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            this.printItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("printItem1.Glyph")));
            this.printItem1.Id = 6;
            this.printItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.printItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printItem1.LargeGlyph")));
            this.printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("printPreviewItem1.Glyph")));
            this.printPreviewItem1.Id = 7;
            this.printPreviewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printPreviewItem1.LargeGlyph")));
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // undoItem1
            // 
            this.undoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.Glyph")));
            this.undoItem1.Id = 8;
            this.undoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.undoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.LargeGlyph")));
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.Glyph")));
            this.redoItem1.Id = 9;
            this.redoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
            this.redoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.LargeGlyph")));
            this.redoItem1.Name = "redoItem1";
            // 
            // insertSymbolItem1
            // 
            this.insertSymbolItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("insertSymbolItem1.Glyph")));
            this.insertSymbolItem1.Id = 29;
            this.insertSymbolItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("insertSymbolItem1.LargeGlyph")));
            this.insertSymbolItem1.Name = "insertSymbolItem1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.fileNewItem1);
            this.richEditBarController1.BarItems.Add(this.fileOpenItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.richEditBarController1.BarItems.Add(this.quickPrintItem1);
            this.richEditBarController1.BarItems.Add(this.printItem1);
            this.richEditBarController1.BarItems.Add(this.printPreviewItem1);
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.BarItems.Add(this.insertSymbolItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontNameItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontColorItem1);
            this.richEditBarController1.BarItems.Add(this.changeFontBackColorItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontBoldItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontItalicItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontUnderlineItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontDoubleUnderlineItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontStrikeoutItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontDoubleStrikeoutItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontSuperscriptItem1);
            this.richEditBarController1.BarItems.Add(this.toggleFontSubscriptItem1);
            this.richEditBarController1.BarItems.Add(this.fontSizeIncreaseItem1);
            this.richEditBarController1.BarItems.Add(this.fontSizeDecreaseItem1);
            this.richEditBarController1.BarItems.Add(this.clearFormattingItem1);
            this.richEditBarController1.BarItems.Add(this.showFontFormItem1);
            this.richEditBarController1.BarItems.Add(this.insertBookmarkItem1);
            this.richEditBarController1.BarItems.Add(this.insertHyperlinkItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
            // 
            // HyperlinkClickHandlingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richEditControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "HyperlinkClickHandlingModule";
            this.Size = new System.Drawing.Size(845, 389);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
        private DevExpress.XtraRichEdit.UI.PrintItem printItem1;
        private DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.ClipboardBar clipboardBar1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private RichEditControl richEditControl;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.UI.FontBar fontBar1;
        private DevExpress.XtraRichEdit.UI.ChangeFontNameItem changeFontNameItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraRichEdit.UI.ChangeFontSizeItem changeFontSizeItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private DevExpress.XtraRichEdit.UI.ChangeFontColorItem changeFontColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem changeFontBackColorItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontBoldItem toggleFontBoldItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontItalicItem toggleFontItalicItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem toggleFontUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem toggleFontStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem toggleFontDoubleStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem toggleFontSuperscriptItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem toggleFontSubscriptItem1;
        private DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem fontSizeIncreaseItem1;
        private DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem fontSizeDecreaseItem1;
        private DevExpress.XtraRichEdit.UI.ClearFormattingItem clearFormattingItem1;
        private DevExpress.XtraRichEdit.UI.ShowFontFormItem showFontFormItem1;
        private DevExpress.XtraRichEdit.UI.InsertSymbolItem insertSymbolItem1;
        private DevExpress.XtraRichEdit.UI.LinksBar linksBar1;
        private DevExpress.XtraRichEdit.UI.InsertBookmarkItem insertBookmarkItem1;
        private DevExpress.XtraRichEdit.UI.InsertHyperlinkItem insertHyperlinkItem1;
    }
}
