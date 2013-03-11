namespace DevExpress.XtraRichEdit.Demos {
	partial class BulletsAndNumberingModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulletsAndNumberingModule));
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.bottomDockArea = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.clipboardBar1 = new DevExpress.XtraRichEdit.UI.ClipboardBar();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.commonBar1 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.paragraphBar1 = new DevExpress.XtraRichEdit.UI.ParagraphBar();
            this.toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            this.toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            this.toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            this.decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            this.increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            this.toggleShowWhitespaceItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.richEditControl.Size = new System.Drawing.Size(841, 357);
            this.richEditControl.TabIndex = 1;
            this.richEditControl.Text = "richEditControl";
            // 
            // bottomDockArea
            // 
            this.bottomDockArea.AutoSize = true;
            this.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomDockArea.Location = new System.Drawing.Point(2, 386);
            this.bottomDockArea.Name = "bottomDockArea";
            this.bottomDockArea.Size = new System.Drawing.Size(841, 1);
            this.bottomDockArea.Text = "standaloneBarDockControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.richEditControl);
            this.panelControl1.Controls.Add(this.bottomDockArea);
            this.panelControl1.Controls.Add(this.standaloneBarDockControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(845, 389);
            this.panelControl1.TabIndex = 4;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(841, 27);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.clipboardBar1,
            this.commonBar1,
            this.paragraphBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.bottomDockArea);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cutItem1,
            this.copyItem1,
            this.pasteItem1,
            this.undoItem1,
            this.redoItem1,
            this.toggleNumberingListItem1,
            this.toggleBulletedListItem1,
            this.toggleMultiLevelListItem1,
            this.decreaseIndentItem1,
            this.increaseIndentItem1,
            this.toggleShowWhitespaceItem1});
            this.barManager1.MaxItemId = 24;
            // 
            // clipboardBar1
            // 
            this.clipboardBar1.DockCol = 1;
            this.clipboardBar1.DockRow = 0;
            this.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.clipboardBar1.FloatLocation = new System.Drawing.Point(361, 175);
            this.clipboardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.copyItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pasteItem1)});
            this.clipboardBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // cutItem1
            // 
            this.cutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.Glyph")));
            this.cutItem1.Id = 7;
            this.cutItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.cutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.LargeGlyph")));
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.Glyph")));
            this.copyItem1.Id = 8;
            this.copyItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.copyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.LargeGlyph")));
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteItem1
            // 
            this.pasteItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.Glyph")));
            this.pasteItem1.Id = 9;
            this.pasteItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.pasteItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.LargeGlyph")));
            this.pasteItem1.Name = "pasteItem1";
            // 
            // commonBar1
            // 
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar1.FloatLocation = new System.Drawing.Point(273, 180);
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.undoItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoItem1)});
            this.commonBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // undoItem1
            // 
            this.undoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.Glyph")));
            this.undoItem1.Id = 10;
            this.undoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.undoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.LargeGlyph")));
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.Glyph")));
            this.redoItem1.Id = 11;
            this.redoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
            this.redoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.LargeGlyph")));
            this.redoItem1.Name = "redoItem1";
            // 
            // paragraphBar1
            // 
            this.paragraphBar1.DockCol = 2;
            this.paragraphBar1.DockRow = 0;
            this.paragraphBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.paragraphBar1.FloatLocation = new System.Drawing.Point(492, 151);
            this.paragraphBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleBulletedListItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleNumberingListItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleMultiLevelListItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.decreaseIndentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.increaseIndentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleShowWhitespaceItem1)});
            this.paragraphBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // toggleNumberingListItem1
            // 
            this.toggleNumberingListItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleNumberingListItem1.Glyph")));
            this.toggleNumberingListItem1.Id = 16;
            this.toggleNumberingListItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleNumberingListItem1.LargeGlyph")));
            this.toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            // 
            // toggleBulletedListItem1
            // 
            this.toggleBulletedListItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleBulletedListItem1.Glyph")));
            this.toggleBulletedListItem1.Id = 17;
            this.toggleBulletedListItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleBulletedListItem1.LargeGlyph")));
            this.toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            // 
            // toggleMultiLevelListItem1
            // 
            this.toggleMultiLevelListItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleMultiLevelListItem1.Glyph")));
            this.toggleMultiLevelListItem1.Id = 18;
            this.toggleMultiLevelListItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleMultiLevelListItem1.LargeGlyph")));
            this.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            // 
            // decreaseIndentItem1
            // 
            this.decreaseIndentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("decreaseIndentItem1.Glyph")));
            this.decreaseIndentItem1.Id = 19;
            this.decreaseIndentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("decreaseIndentItem1.LargeGlyph")));
            this.decreaseIndentItem1.Name = "decreaseIndentItem1";
            // 
            // increaseIndentItem1
            // 
            this.increaseIndentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("increaseIndentItem1.Glyph")));
            this.increaseIndentItem1.Id = 20;
            this.increaseIndentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("increaseIndentItem1.LargeGlyph")));
            this.increaseIndentItem1.Name = "increaseIndentItem1";
            // 
            // toggleShowWhitespaceItem1
            // 
            this.toggleShowWhitespaceItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleShowWhitespaceItem1.Glyph")));
            this.toggleShowWhitespaceItem1.Id = 21;
            this.toggleShowWhitespaceItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                            | System.Windows.Forms.Keys.D8));
            this.toggleShowWhitespaceItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleShowWhitespaceItem1.LargeGlyph")));
            this.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.toggleNumberingListItem1);
            this.richEditBarController1.BarItems.Add(this.toggleBulletedListItem1);
            this.richEditBarController1.BarItems.Add(this.toggleMultiLevelListItem1);
            this.richEditBarController1.BarItems.Add(this.decreaseIndentItem1);
            this.richEditBarController1.BarItems.Add(this.increaseIndentItem1);
            this.richEditBarController1.BarItems.Add(this.toggleShowWhitespaceItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
            // 
            // BulletsAndNumberingModule
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BulletsAndNumberingModule";
            this.Size = new System.Drawing.Size(845, 389);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private RichEditControl richEditControl;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraBars.StandaloneBarDockControl bottomDockArea;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraRichEdit.UI.ClipboardBar clipboardBar1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.ParagraphBar paragraphBar1;
        private DevExpress.XtraRichEdit.UI.ToggleNumberingListItem toggleNumberingListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleBulletedListItem toggleBulletedListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem toggleMultiLevelListItem1;
        private DevExpress.XtraRichEdit.UI.DecreaseIndentItem decreaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.IncreaseIndentItem increaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem toggleShowWhitespaceItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
	}
}
