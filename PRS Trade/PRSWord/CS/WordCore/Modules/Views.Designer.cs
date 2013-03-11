namespace DevExpress.XtraRichEdit.Demos {
	partial class ViewsModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewsModule));
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rgrpViewType = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.commonBar1 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.clipboardBar1 = new DevExpress.XtraRichEdit.UI.ClipboardBar();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.documentViewsBar1 = new DevExpress.XtraRichEdit.UI.DocumentViewsBar();
            this.switchToSimpleViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem();
            this.switchToDraftViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem();
            this.switchToPrintLayoutViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.showBar1 = new DevExpress.XtraRichEdit.UI.ShowBar();
            this.toggleShowHorizontalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem();
            this.toggleShowVerticalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem();
            this.zoomOutItem1 = new DevExpress.XtraRichEdit.UI.ZoomOutItem();
            this.zoomInItem1 = new DevExpress.XtraRichEdit.UI.ZoomInItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpViewType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.Location = new System.Drawing.Point(2, 33);
            this.richEditControl.MenuManager = this;
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Size = new System.Drawing.Size(841, 316);
            this.richEditControl.TabIndex = 1;
            this.richEditControl.Text = "richEditControl";
            this.richEditControl.ActiveViewChanged += new System.EventHandler(this.richEditControl_ActiveViewChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.richEditControl);
            this.panelControl1.Controls.Add(this.standaloneBarDockControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(845, 351);
            this.panelControl1.TabIndex = 6;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(841, 31);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rgrpViewType);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(845, 38);
            this.panelControl2.TabIndex = 7;
            // 
            // rgrpViewType
            // 
            this.rgrpViewType.Location = new System.Drawing.Point(62, 6);
            this.rgrpViewType.Name = "rgrpViewType";
            this.rgrpViewType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgrpViewType.Properties.Appearance.Options.UseBackColor = true;
            this.rgrpViewType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgrpViewType.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rgrpViewType.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rgrpViewType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraRichEdit.RichEditViewType.Simple, "Simple"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraRichEdit.RichEditViewType.Draft, "Draft"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraRichEdit.RichEditViewType.PrintLayout, "Print Layout")});
            this.rgrpViewType.Size = new System.Drawing.Size(282, 25);
            this.rgrpViewType.TabIndex = 0;
            this.rgrpViewType.SelectedIndexChanged += new System.EventHandler(this.rgrpViewType_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "View type:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.commonBar1,
            this.clipboardBar1,
            this.documentViewsBar1,
            this.showBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.undoItem1,
            this.redoItem1,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteItem1,
            this.switchToSimpleViewItem1,
            this.switchToDraftViewItem1,
            this.switchToPrintLayoutViewItem1,
            this.toggleShowHorizontalRulerItem1,
            this.toggleShowVerticalRulerItem1,
            this.zoomOutItem1,
            this.zoomInItem1});
            this.barManager1.MaxItemId = 26;
            // 
            // commonBar1
            // 
            this.commonBar1.DockCol = 1;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar1.FloatLocation = new System.Drawing.Point(291, 185);
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.fileNewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fileOpenItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fileSaveItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.fileSaveAsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.undoItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoItem1)});
            this.commonBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileNewItem1.Glyph")));
            this.fileNewItem1.Id = 12;
            this.fileNewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileNewItem1.LargeGlyph")));
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileOpenItem1.Glyph")));
            this.fileOpenItem1.Id = 13;
            this.fileOpenItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileOpenItem1.LargeGlyph")));
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem1.Glyph")));
            this.fileSaveItem1.Id = 14;
            this.fileSaveItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem1.LargeGlyph")));
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveAsItem1.Glyph")));
            this.fileSaveAsItem1.Id = 15;
            this.fileSaveAsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveAsItem1.LargeGlyph")));
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
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
            // clipboardBar1
            // 
            this.clipboardBar1.DockCol = 2;
            this.clipboardBar1.DockRow = 0;
            this.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.clipboardBar1.FloatLocation = new System.Drawing.Point(479, 182);
            this.clipboardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.copyItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pasteItem1)});
            this.clipboardBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // cutItem1
            // 
            this.cutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.Glyph")));
            this.cutItem1.Id = 16;
            this.cutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.LargeGlyph")));
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.Glyph")));
            this.copyItem1.Id = 17;
            this.copyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.LargeGlyph")));
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteItem1
            // 
            this.pasteItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.Glyph")));
            this.pasteItem1.Id = 18;
            this.pasteItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.LargeGlyph")));
            this.pasteItem1.Name = "pasteItem1";
            // 
            // documentViewsBar1
            // 
            this.documentViewsBar1.DockCol = 0;
            this.documentViewsBar1.DockRow = 0;
            this.documentViewsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.documentViewsBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToSimpleViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToDraftViewItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.switchToPrintLayoutViewItem1)});
            this.documentViewsBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // switchToSimpleViewItem1
            // 
            this.switchToSimpleViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToSimpleViewItem1.Glyph")));
            this.switchToSimpleViewItem1.Id = 19;
            this.switchToSimpleViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToSimpleViewItem1.LargeGlyph")));
            this.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1";
            // 
            // switchToDraftViewItem1
            // 
            this.switchToDraftViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToDraftViewItem1.Glyph")));
            this.switchToDraftViewItem1.Id = 20;
            this.switchToDraftViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToDraftViewItem1.LargeGlyph")));
            this.switchToDraftViewItem1.Name = "switchToDraftViewItem1";
            // 
            // switchToPrintLayoutViewItem1
            // 
            this.switchToPrintLayoutViewItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("switchToPrintLayoutViewItem1.Glyph")));
            this.switchToPrintLayoutViewItem1.Id = 21;
            this.switchToPrintLayoutViewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("switchToPrintLayoutViewItem1.LargeGlyph")));
            this.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(845, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 389);
            this.barDockControlBottom.Size = new System.Drawing.Size(845, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 389);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(845, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 389);
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.fileNewItem1);
            this.richEditBarController1.BarItems.Add(this.fileOpenItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.BarItems.Add(this.switchToSimpleViewItem1);
            this.richEditBarController1.BarItems.Add(this.switchToDraftViewItem1);
            this.richEditBarController1.BarItems.Add(this.switchToPrintLayoutViewItem1);
            this.richEditBarController1.BarItems.Add(this.toggleShowHorizontalRulerItem1);
            this.richEditBarController1.BarItems.Add(this.toggleShowVerticalRulerItem1);
            this.richEditBarController1.BarItems.Add(this.zoomOutItem1);
            this.richEditBarController1.BarItems.Add(this.zoomInItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
            // 
            // showBar1
            // 
            this.showBar1.DockCol = 3;
            this.showBar1.DockRow = 0;
            this.showBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.showBar1.FloatLocation = new System.Drawing.Point(540, 195);
            this.showBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleShowHorizontalRulerItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleShowVerticalRulerItem1)});
            this.showBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // toggleShowHorizontalRulerItem1
            // 
            this.toggleShowHorizontalRulerItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleShowHorizontalRulerItem1.Glyph")));
            this.toggleShowHorizontalRulerItem1.Id = 22;
            this.toggleShowHorizontalRulerItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleShowHorizontalRulerItem1.LargeGlyph")));
            this.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1";
            // 
            // toggleShowVerticalRulerItem1
            // 
            this.toggleShowVerticalRulerItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("toggleShowVerticalRulerItem1.Glyph")));
            this.toggleShowVerticalRulerItem1.Id = 23;
            this.toggleShowVerticalRulerItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("toggleShowVerticalRulerItem1.LargeGlyph")));
            this.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1";
            // 
            // zoomOutItem1
            // 
            this.zoomOutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("zoomOutItem1.Glyph")));
            this.zoomOutItem1.Id = 24;
            this.zoomOutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("zoomOutItem1.LargeGlyph")));
            this.zoomOutItem1.Name = "zoomOutItem1";
            // 
            // zoomInItem1
            // 
            this.zoomInItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("zoomInItem1.Glyph")));
            this.zoomInItem1.Id = 25;
            this.zoomInItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("zoomInItem1.LargeGlyph")));
            this.zoomInItem1.Name = "zoomInItem1";
            // 
            // ViewsModule
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ViewsModule";
            this.Size = new System.Drawing.Size(845, 389);
            this.Load += new System.EventHandler(this.ViewsModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgrpViewType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private RichEditControl richEditControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.RadioGroup rgrpViewType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.XtraRichEdit.UI.ClipboardBar clipboardBar1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.DocumentViewsBar documentViewsBar1;
        private DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem switchToSimpleViewItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem switchToDraftViewItem1;
        private DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem switchToPrintLayoutViewItem1;
        private DevExpress.XtraRichEdit.UI.ShowBar showBar1;
        private DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem toggleShowHorizontalRulerItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem toggleShowVerticalRulerItem1;
        private DevExpress.XtraRichEdit.UI.ZoomOutItem zoomOutItem1;
        private DevExpress.XtraRichEdit.UI.ZoomInItem zoomInItem1;
	}
}
