namespace DevExpress.XtraRichEdit.Demos {
	partial class ZoomModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomModule));
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblZoom = new DevExpress.XtraBars.BarStaticItem();
            this.zoomTrackBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.bottomDockArea = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.commonBar1 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.clipboardBar1 = new DevExpress.XtraRichEdit.UI.ClipboardBar();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.zoomBar1 = new DevExpress.XtraRichEdit.UI.ZoomBar();
            this.zoomOutItem1 = new DevExpress.XtraRichEdit.UI.ZoomOutItem();
            this.zoomInItem1 = new DevExpress.XtraRichEdit.UI.ZoomInItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            this.richEditControl.Size = new System.Drawing.Size(841, 333);
            this.richEditControl.TabIndex = 1;
            this.richEditControl.Text = "richEditControl";
            this.richEditControl.ZoomChanged += new System.EventHandler(this.richEditControl_ZoomChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.commonBar1,
            this.clipboardBar1,
            this.zoomBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.bottomDockArea);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.zoomTrackBar,
            this.lblZoom,
            this.undoItem1,
            this.redoItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteItem1,
            this.zoomOutItem1,
            this.zoomInItem1});
            this.barManager1.MaxItemId = 37;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemZoomTrackBar1});
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblZoom),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.zoomTrackBar, "", false, true, true, 206)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.StandaloneBarDockControl = this.bottomDockArea;
            this.bar3.Text = "Status bar";
            // 
            // lblZoom
            // 
            this.lblZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblZoom.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblZoom.Caption = "lblZoom";
            this.lblZoom.Id = 21;
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.zoomTrackBar.Caption = "barEditItem1";
            this.zoomTrackBar.Edit = this.repositoryItemZoomTrackBar1;
            this.zoomTrackBar.Id = 20;
            this.zoomTrackBar.Name = "zoomTrackBar";
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.LargeChange = 10;
            this.repositoryItemZoomTrackBar1.Maximum = 500;
            this.repositoryItemZoomTrackBar1.Minimum = 10;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            // 
            // bottomDockArea
            // 
            this.bottomDockArea.AutoSize = true;
            this.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomDockArea.Location = new System.Drawing.Point(2, 362);
            this.bottomDockArea.Name = "bottomDockArea";
            this.bottomDockArea.Size = new System.Drawing.Size(841, 25);
            this.bottomDockArea.Text = "standaloneBarDockControl2";
            // 
            // commonBar1
            // 
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar1.FloatLocation = new System.Drawing.Point(268, 184);
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.undoItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoItem1)});
            this.commonBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // undoItem1
            // 
            this.undoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.Glyph")));
            this.undoItem1.Id = 30;
            this.undoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.undoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.LargeGlyph")));
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.Glyph")));
            this.redoItem1.Id = 31;
            this.redoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
            this.redoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.LargeGlyph")));
            this.redoItem1.Name = "redoItem1";
            // 
            // clipboardBar1
            // 
            this.clipboardBar1.DockCol = 1;
            this.clipboardBar1.DockRow = 0;
            this.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.clipboardBar1.FloatLocation = new System.Drawing.Point(360, 179);
            this.clipboardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.copyItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pasteItem1)});
            this.clipboardBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // cutItem1
            // 
            this.cutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.Glyph")));
            this.cutItem1.Id = 32;
            this.cutItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.cutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.LargeGlyph")));
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.Glyph")));
            this.copyItem1.Id = 33;
            this.copyItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.copyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.LargeGlyph")));
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteItem1
            // 
            this.pasteItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.Glyph")));
            this.pasteItem1.Id = 34;
            this.pasteItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.pasteItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.LargeGlyph")));
            this.pasteItem1.Name = "pasteItem1";
            // 
            // zoomBar1
            // 
            this.zoomBar1.DockCol = 2;
            this.zoomBar1.DockRow = 0;
            this.zoomBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.zoomBar1.FloatLocation = new System.Drawing.Point(488, 152);
            this.zoomBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.zoomOutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.zoomInItem1)});
            this.zoomBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // zoomOutItem1
            // 
            this.zoomOutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("zoomOutItem1.Glyph")));
            this.zoomOutItem1.Id = 35;
            this.zoomOutItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Subtract));
            this.zoomOutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("zoomOutItem1.LargeGlyph")));
            this.zoomOutItem1.Name = "zoomOutItem1";
            // 
            // zoomInItem1
            // 
            this.zoomInItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("zoomInItem1.Glyph")));
            this.zoomInItem1.Id = 36;
            this.zoomInItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add));
            this.zoomInItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("zoomInItem1.LargeGlyph")));
            this.zoomInItem1.Name = "zoomInItem1";
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
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.BarItems.Add(this.zoomOutItem1);
            this.richEditBarController1.BarItems.Add(this.zoomInItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
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
            // ZoomModule
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ZoomModule";
            this.Size = new System.Drawing.Size(845, 389);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RichEditControl richEditControl;
		private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarEditItem zoomTrackBar;
		private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraBars.BarStaticItem lblZoom;
		private DevExpress.XtraBars.StandaloneBarDockControl bottomDockArea;
		private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.ClipboardBar clipboardBar1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.ZoomBar zoomBar1;
        private DevExpress.XtraRichEdit.UI.ZoomOutItem zoomOutItem1;
        private DevExpress.XtraRichEdit.UI.ZoomInItem zoomInItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
	}
}
