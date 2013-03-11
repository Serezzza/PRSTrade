namespace DevExpress.XtraRichEdit.Demos {
	partial class SearchCapabilitiesModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCapabilitiesModule));
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.commonBar1 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.editingBar1 = new DevExpress.XtraRichEdit.UI.EditingBar();
            this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
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
            this.richEditControl.Location = new System.Drawing.Point(2, 32);
            this.richEditControl.MenuManager = this;
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Size = new System.Drawing.Size(841, 355);
            this.richEditControl.TabIndex = 1;
            this.richEditControl.Text = "richEditControl";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.richEditControl);
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
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(841, 30);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.commonBar1,
            this.editingBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.undoItem1,
            this.redoItem1,
            this.findItem1,
            this.replaceItem1});
            this.barManager1.MaxItemId = 11;
            // 
            // commonBar1
            // 
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar1.FloatLocation = new System.Drawing.Point(276, 183);
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.undoItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoItem1)});
            this.commonBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // undoItem1
            // 
            this.undoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.Glyph")));
            this.undoItem1.Id = 7;
            this.undoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.undoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("undoItem1.LargeGlyph")));
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.Glyph")));
            this.redoItem1.Id = 8;
            this.redoItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
            this.redoItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("redoItem1.LargeGlyph")));
            this.redoItem1.Name = "redoItem1";
            // 
            // editingBar1
            // 
            this.editingBar1.DockCol = 1;
            this.editingBar1.DockRow = 0;
            this.editingBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.editingBar1.FloatLocation = new System.Drawing.Point(391, 144);
            this.editingBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.findItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.replaceItem1)});
            this.editingBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // findItem1
            // 
            this.findItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("findItem1.Glyph")));
            this.findItem1.Id = 9;
            this.findItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.findItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("findItem1.LargeGlyph")));
            this.findItem1.Name = "findItem1";
            // 
            // replaceItem1
            // 
            this.replaceItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("replaceItem1.Glyph")));
            this.replaceItem1.Id = 10;
            this.replaceItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H));
            this.replaceItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("replaceItem1.LargeGlyph")));
            this.replaceItem1.Name = "replaceItem1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.findItem1);
            this.richEditBarController1.BarItems.Add(this.replaceItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
            // 
            // SearchCapabilitiesModule
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SearchCapabilitiesModule";
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
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.UI.EditingBar editingBar1;
        private DevExpress.XtraRichEdit.UI.FindItem findItem1;
        private DevExpress.XtraRichEdit.UI.ReplaceItem replaceItem1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
	}
}
