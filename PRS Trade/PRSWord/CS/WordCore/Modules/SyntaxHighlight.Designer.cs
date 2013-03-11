namespace DevExpress.XtraRichEdit.Demos {
    partial class SyntaxHighlightModule {
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyntaxHighlightModule));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.clipboardBar1 = new DevExpress.XtraRichEdit.UI.ClipboardBar();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.zoomBar1 = new DevExpress.XtraRichEdit.UI.ZoomBar();
            this.zoomOutItem1 = new DevExpress.XtraRichEdit.UI.ZoomOutItem();
            this.zoomInItem1 = new DevExpress.XtraRichEdit.UI.ZoomInItem();
            this.commonBar2 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            this.printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            this.printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            this.changeStyleItem1 = new DevExpress.XtraRichEdit.UI.ChangeStyleItem();
            this.repositoryItemRichEditStyleEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.sharedDictionaryStorage1 = new DevExpress.XtraSpellChecker.SharedDictionaryStorage(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.richEditControl);
            this.panelControl2.Controls.Add(this.standaloneBarDockControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(691, 429);
            this.panelControl2.TabIndex = 1;
            // 
            // richEditControl
            // 
            this.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEditControl.Location = new System.Drawing.Point(2, 28);
            this.richEditControl.MenuManager = this;
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Options.AutoCorrect.DetectUrls = false;
            this.richEditControl.Options.AutoCorrect.ReplaceTextAsYouType = false;
            this.richEditControl.Options.DocumentCapabilities.Bookmarks = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.CharacterStyle = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.Hyperlinks = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.InlinePictures = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.Numbering.Bulleted = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.Numbering.MultiLevel = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.Numbering.Simple = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.ParagraphFormatting = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.Paragraphs = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.richEditControl.Options.DocumentCapabilities.ParagraphStyle = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.Sections = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.Tables = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.DocumentCapabilities.TableStyle = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.spellChecker1.SetShowSpellCheckMenu(this.richEditControl, false);
            this.richEditControl.Size = new System.Drawing.Size(687, 399);
            this.richEditControl.SpellChecker = this.spellChecker1;
            this.spellChecker1.SetSpellCheckerOptions(this.richEditControl, optionsSpelling1);
            this.richEditControl.TabIndex = 1;
            this.richEditControl.Text = "richEditControl1";
            this.richEditControl.Views.DraftView.AllowDisplayLineNumbers = true;
            this.richEditControl.Views.DraftView.Padding = new System.Windows.Forms.Padding(80, 4, 0, 0);
            this.richEditControl.Views.SimpleView.Padding = new System.Windows.Forms.Padding(50, 4, 4, 0);
            this.richEditControl.InitializeDocument += new System.EventHandler(this.richEditControl_InitializeDocument);
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en-US");
            this.spellChecker1.ParentContainer = null;
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(687, 26);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.clipboardBar1,
            this.zoomBar1,
            this.commonBar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl2);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cutItem1,
            this.copyItem1,
            this.pasteItem1,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.quickPrintItem1,
            this.printItem1,
            this.printPreviewItem1,
            this.undoItem1,
            this.redoItem1,
            this.findItem1,
            this.replaceItem1,
            this.changeStyleItem1,
            this.zoomOutItem1,
            this.zoomInItem1});
            this.barManager1.MaxItemId = 34;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRichEditStyleEdit1});
            // 
            // clipboardBar1
            // 
            this.clipboardBar1.DockCol = 1;
            this.clipboardBar1.DockRow = 0;
            this.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.clipboardBar1.FloatLocation = new System.Drawing.Point(41, 296);
            this.clipboardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.copyItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pasteItem1)});
            this.clipboardBar1.StandaloneBarDockControl = this.standaloneBarDockControl2;
            // 
            // cutItem1
            // 
            this.cutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.Glyph")));
            this.cutItem1.Id = 0;
            this.cutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.LargeGlyph")));
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.Glyph")));
            this.copyItem1.Id = 1;
            this.copyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.LargeGlyph")));
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteItem1
            // 
            this.pasteItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.Glyph")));
            this.pasteItem1.Id = 2;
            this.pasteItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.LargeGlyph")));
            this.pasteItem1.Name = "pasteItem1";
            // 
            // zoomBar1
            // 
            this.zoomBar1.DockCol = 2;
            this.zoomBar1.DockRow = 0;
            this.zoomBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.zoomBar1.FloatLocation = new System.Drawing.Point(147, 240);
            this.zoomBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.zoomOutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.zoomInItem1)});
            this.zoomBar1.Offset = 332;
            this.zoomBar1.StandaloneBarDockControl = this.standaloneBarDockControl2;
            // 
            // zoomOutItem1
            // 
            this.zoomOutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("zoomOutItem1.Glyph")));
            this.zoomOutItem1.Id = 9;
            this.zoomOutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("zoomOutItem1.LargeGlyph")));
            this.zoomOutItem1.Name = "zoomOutItem1";
            // 
            // zoomInItem1
            // 
            this.zoomInItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("zoomInItem1.Glyph")));
            this.zoomInItem1.Id = 10;
            this.zoomInItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("zoomInItem1.LargeGlyph")));
            this.zoomInItem1.Name = "zoomInItem1";
            // 
            // commonBar2
            // 
            this.commonBar2.DockCol = 0;
            this.commonBar2.DockRow = 0;
            this.commonBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar2.FloatLocation = new System.Drawing.Point(46, 275);
            this.commonBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.fileNewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fileOpenItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fileSaveItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fileSaveAsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.quickPrintItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.undoItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoItem1)});
            this.commonBar2.StandaloneBarDockControl = this.standaloneBarDockControl2;
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileNewItem1.Glyph")));
            this.fileNewItem1.Id = 3;
            this.fileNewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileNewItem1.LargeGlyph")));
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileOpenItem1.Glyph")));
            this.fileOpenItem1.Id = 4;
            this.fileOpenItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileOpenItem1.LargeGlyph")));
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem1.Glyph")));
            this.fileSaveItem1.Id = 5;
            this.fileSaveItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem1.LargeGlyph")));
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveAsItem1.Glyph")));
            this.fileSaveAsItem1.Id = 6;
            this.fileSaveAsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveAsItem1.LargeGlyph")));
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // quickPrintItem1
            // 
            this.quickPrintItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("quickPrintItem1.Glyph")));
            this.quickPrintItem1.Id = 11;
            this.quickPrintItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("quickPrintItem1.LargeGlyph")));
            this.quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            this.printItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("printItem1.Glyph")));
            this.printItem1.Id = 12;
            this.printItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printItem1.LargeGlyph")));
            this.printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("printPreviewItem1.Glyph")));
            this.printPreviewItem1.Id = 13;
            this.printPreviewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printPreviewItem1.LargeGlyph")));
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // undoItem1
            // 
            this.undoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.Glyph")));
            this.undoItem1.Id = 7;
            this.undoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.LargeGlyph")));
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.Glyph")));
            this.redoItem1.Id = 8;
            this.redoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.LargeGlyph")));
            this.redoItem1.Name = "redoItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(691, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 429);
            this.barDockControlBottom.Size = new System.Drawing.Size(691, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 429);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(691, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 429);
            // 
            // findItem1
            // 
            this.findItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("findItem1.Glyph")));
            this.findItem1.Id = 14;
            this.findItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("findItem1.LargeGlyph")));
            this.findItem1.Name = "findItem1";
            // 
            // replaceItem1
            // 
            this.replaceItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("replaceItem1.Glyph")));
            this.replaceItem1.Id = 15;
            this.replaceItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("replaceItem1.LargeGlyph")));
            this.replaceItem1.Name = "replaceItem1";
            // 
            // changeStyleItem1
            // 
            this.changeStyleItem1.Edit = this.repositoryItemRichEditStyleEdit1;
            this.changeStyleItem1.Id = 16;
            this.changeStyleItem1.Name = "changeStyleItem1";
            // 
            // repositoryItemRichEditStyleEdit1
            // 
            this.repositoryItemRichEditStyleEdit1.AutoHeight = false;
            this.repositoryItemRichEditStyleEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditStyleEdit1.Control = this.richEditControl;
            this.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.BarItems.Add(this.fileNewItem1);
            this.richEditBarController1.BarItems.Add(this.fileOpenItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.richEditBarController1.BarItems.Add(this.quickPrintItem1);
            this.richEditBarController1.BarItems.Add(this.printItem1);
            this.richEditBarController1.BarItems.Add(this.printPreviewItem1);
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.findItem1);
            this.richEditBarController1.BarItems.Add(this.replaceItem1);
            this.richEditBarController1.BarItems.Add(this.changeStyleItem1);
            this.richEditBarController1.BarItems.Add(this.zoomOutItem1);
            this.richEditBarController1.BarItems.Add(this.zoomInItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
            // 
            // SyntaxHighlightModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SyntaxHighlightModule";
            this.Size = new System.Drawing.Size(691, 429);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private RichEditControl richEditControl;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraRichEdit.UI.ClipboardBar clipboardBar1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.ZoomBar zoomBar1;
        private DevExpress.XtraRichEdit.UI.ZoomOutItem zoomOutItem1;
        private DevExpress.XtraRichEdit.UI.ZoomInItem zoomInItem1;
        private DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
        private DevExpress.XtraRichEdit.UI.PrintItem printItem1;
        private DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraRichEdit.UI.FindItem findItem1;
        private DevExpress.XtraRichEdit.UI.ReplaceItem replaceItem1;
        private DevExpress.XtraRichEdit.UI.ChangeStyleItem changeStyleItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit repositoryItemRichEditStyleEdit1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar2;
        private DevExpress.XtraSpellChecker.SharedDictionaryStorage sharedDictionaryStorage1;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
    }
}
