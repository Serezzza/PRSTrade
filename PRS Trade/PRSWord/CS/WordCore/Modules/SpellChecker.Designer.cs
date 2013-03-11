namespace DevExpress.XtraRichEdit.Demos {
	partial class SpellCheckerModule {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellCheckerModule));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bottomDockArea = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.checkSpellingItem = new DevExpress.XtraBars.BarButtonItem();
            this.topDockArea = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.commonBar1 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.clipboardBar1 = new DevExpress.XtraRichEdit.UI.ClipboardBar();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sharedDictionaryStorage1 = new DevExpress.XtraSpellChecker.SharedDictionaryStorage(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.Location = new System.Drawing.Point(2, 29);
            this.richEditControl.MenuManager = this;
            this.richEditControl.Name = "richEditControl";
            this.spellChecker1.SetShowSpellCheckMenu(this.richEditControl, false);
            this.richEditControl.Size = new System.Drawing.Size(841, 295);
            this.richEditControl.SpellChecker = this.spellChecker1;
            this.spellChecker1.SetSpellCheckerOptions(this.richEditControl, optionsSpelling1);
            this.richEditControl.TabIndex = 1;
            this.richEditControl.Text = "richEditControl";
            this.richEditControl.ReadOnlyChanged += new System.EventHandler(this.richEditControl_ReadOnlyChanged);
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en-US");
            this.spellChecker1.ParentContainer = null;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.commonBar1,
            this.clipboardBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.topDockArea);
            this.barManager1.DockControls.Add(this.bottomDockArea);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.checkSpellingItem,
            this.undoItem1,
            this.redoItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteItem1});
            this.barManager1.MaxItemId = 31;
            // 
            // bottomDockArea
            // 
            this.bottomDockArea.AutoSize = true;
            this.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomDockArea.Location = new System.Drawing.Point(2, 324);
            this.bottomDockArea.Name = "bottomDockArea";
            this.bottomDockArea.Size = new System.Drawing.Size(841, 25);
            this.bottomDockArea.Text = "standaloneBarDockControl2";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 5";
            this.bar1.DockCol = 2;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.checkSpellingItem)});
            this.bar1.StandaloneBarDockControl = this.topDockArea;
            this.bar1.Text = "Check spelling";
            // 
            // checkSpellingItem
            // 
            this.checkSpellingItem.Caption = "Spelling";
            this.checkSpellingItem.Glyph = ((System.Drawing.Image)(resources.GetObject("checkSpellingItem.Glyph")));
            this.checkSpellingItem.Id = 18;
            this.checkSpellingItem.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7);
            this.checkSpellingItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("checkSpellingItem.LargeGlyph")));
            this.checkSpellingItem.Name = "checkSpellingItem";
            toolTipTitleItem1.Text = "Spelling (F7)";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Check the spelling of text in the document.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.checkSpellingItem.SuperTip = superToolTip1;
            this.checkSpellingItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.checkSpellingItem_ItemClick);
            // 
            // topDockArea
            // 
            this.topDockArea.AutoSize = true;
            this.topDockArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.topDockArea.Location = new System.Drawing.Point(2, 2);
            this.topDockArea.Name = "topDockArea";
            this.topDockArea.Size = new System.Drawing.Size(841, 27);
            this.topDockArea.Text = "standaloneBarDockControl1";
            // 
            // commonBar1
            // 
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar1.FloatLocation = new System.Drawing.Point(315, 184);
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.undoItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoItem1)});
            this.commonBar1.StandaloneBarDockControl = this.topDockArea;
            // 
            // undoItem1
            // 
            this.undoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.Glyph")));
            this.undoItem1.Id = 26;
            this.undoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.undoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.LargeGlyph")));
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.Glyph")));
            this.redoItem1.Id = 27;
            this.redoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
            this.redoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.LargeGlyph")));
            this.redoItem1.Name = "redoItem1";
            // 
            // clipboardBar1
            // 
            this.clipboardBar1.DockCol = 1;
            this.clipboardBar1.DockRow = 0;
            this.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.clipboardBar1.FloatLocation = new System.Drawing.Point(388, 178);
            this.clipboardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.copyItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pasteItem1)});
            this.clipboardBar1.StandaloneBarDockControl = this.topDockArea;
            // 
            // cutItem1
            // 
            this.cutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.Glyph")));
            this.cutItem1.Id = 28;
            this.cutItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.cutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.LargeGlyph")));
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.Glyph")));
            this.copyItem1.Id = 29;
            this.copyItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.copyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.LargeGlyph")));
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteItem1
            // 
            this.pasteItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.Glyph")));
            this.pasteItem1.Id = 30;
            this.pasteItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.pasteItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.LargeGlyph")));
            this.pasteItem1.Name = "pasteItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.richEditControl);
            this.panelControl1.Controls.Add(this.bottomDockArea);
            this.panelControl1.Controls.Add(this.topDockArea);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(845, 351);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.checkEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(845, 38);
            this.panelControl2.TabIndex = 6;
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(5, 11);
            this.checkEdit1.MenuManager = this;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.AutoWidth = true;
            this.checkEdit1.Properties.Caption = "Check spelling as you type";
            this.checkEdit1.Size = new System.Drawing.Size(150, 19);
            this.checkEdit1.TabIndex = 1;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
            // 
            // SpellCheckerModule
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SpellCheckerModule";
            this.Size = new System.Drawing.Size(845, 389);
            this.Load += new System.EventHandler(this.SpellCheckerModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RichEditControl richEditControl;
        private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.BarButtonItem checkSpellingItem;
		private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
		private DevExpress.XtraSpellChecker.SharedDictionaryStorage sharedDictionaryStorage1;
		private DevExpress.XtraBars.StandaloneBarDockControl topDockArea;
		private DevExpress.XtraBars.StandaloneBarDockControl bottomDockArea;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.ClipboardBar clipboardBar1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
	}
}
