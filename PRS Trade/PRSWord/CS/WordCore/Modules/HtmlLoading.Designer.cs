namespace DevExpress.XtraRichEdit.Demos {
    partial class HtmlLoadingModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HtmlLoadingModule));
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grpXtraRichEdit = new DevExpress.XtraEditors.GroupControl();
            this.grpWebBrowser = new DevExpress.XtraEditors.GroupControl();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.grpPlainHtml = new DevExpress.XtraEditors.GroupControl();
            this.edtPlainHtml = new DevExpress.XtraEditors.MemoEdit();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpXtraRichEdit)).BeginInit();
            this.grpXtraRichEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpWebBrowser)).BeginInit();
            this.grpWebBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPlainHtml)).BeginInit();
            this.grpPlainHtml.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtPlainHtml.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.Location = new System.Drawing.Point(2, 22);
            this.richEditControl.MenuManager = this;
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Size = new System.Drawing.Size(405, 184);
            this.richEditControl.TabIndex = 1;
            this.richEditControl.EmptyDocumentCreated += new System.EventHandler(this.richEditControl_EmptyDocumentCreated);
            this.richEditControl.DocumentLoaded += new System.EventHandler(this.richEditControl_DocumentLoaded);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl2);
            this.panelControl1.Controls.Add(this.standaloneBarDockControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(845, 389);
            this.panelControl1.TabIndex = 4;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(2, 28);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.splitContainerControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.grpPlainHtml);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(841, 359);
            this.splitContainerControl2.SplitterPosition = 208;
            this.splitContainerControl2.TabIndex = 7;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.grpXtraRichEdit);
            this.splitContainerControl1.Panel1.ShowCaption = true;
            this.splitContainerControl1.Panel1.Text = "XtraRichEdit control:";
            this.splitContainerControl1.Panel2.Controls.Add(this.grpWebBrowser);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(841, 208);
            this.splitContainerControl1.SplitterPosition = 409;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // grpXtraRichEdit
            // 
            this.grpXtraRichEdit.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpXtraRichEdit.AppearanceCaption.Options.UseFont = true;
            this.grpXtraRichEdit.Controls.Add(this.richEditControl);
            this.grpXtraRichEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpXtraRichEdit.Location = new System.Drawing.Point(0, 0);
            this.grpXtraRichEdit.Name = "grpXtraRichEdit";
            this.grpXtraRichEdit.Size = new System.Drawing.Size(409, 208);
            this.grpXtraRichEdit.TabIndex = 0;
            this.grpXtraRichEdit.Text = "XtraRichEdit control";
            // 
            // grpWebBrowser
            // 
            this.grpWebBrowser.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpWebBrowser.AppearanceCaption.Options.UseFont = true;
            this.grpWebBrowser.Controls.Add(this.webBrowser);
            this.grpWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.grpWebBrowser.Name = "grpWebBrowser";
            this.grpWebBrowser.Size = new System.Drawing.Size(426, 208);
            this.grpWebBrowser.TabIndex = 9;
            this.grpWebBrowser.Text = "Web browser";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(2, 22);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(422, 184);
            this.webBrowser.TabIndex = 0;
            // 
            // grpPlainHtml
            // 
            this.grpPlainHtml.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpPlainHtml.AppearanceCaption.Options.UseFont = true;
            this.grpPlainHtml.Controls.Add(this.edtPlainHtml);
            this.grpPlainHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPlainHtml.Location = new System.Drawing.Point(0, 0);
            this.grpPlainHtml.Name = "grpPlainHtml";
            this.grpPlainHtml.Size = new System.Drawing.Size(841, 145);
            this.grpPlainHtml.TabIndex = 10;
            this.grpPlainHtml.Text = "Plain HTML";
            // 
            // edtPlainHtml
            // 
            this.edtPlainHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtPlainHtml.Location = new System.Drawing.Point(2, 22);
            this.edtPlainHtml.Name = "edtPlainHtml";
            this.edtPlainHtml.Size = new System.Drawing.Size(837, 121);
            this.edtPlainHtml.TabIndex = 10;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(841, 26);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.commonBar1,
            this.clipboardBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.undoItem1,
            this.redoItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteItem1});
            this.barManager1.MaxItemId = 12;
            // 
            // commonBar1
            // 
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 0;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.commonBar1.FloatLocation = new System.Drawing.Point(269, 179);
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
            this.fileNewItem1.Id = 3;
            this.fileNewItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.fileNewItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileNewItem1.LargeGlyph")));
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileOpenItem1.Glyph")));
            this.fileOpenItem1.Id = 4;
            this.fileOpenItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.fileOpenItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileOpenItem1.LargeGlyph")));
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem1.Glyph")));
            this.fileSaveItem1.Id = 5;
            this.fileSaveItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.fileSaveItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveItem1.LargeGlyph")));
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("fileSaveAsItem1.Glyph")));
            this.fileSaveAsItem1.Id = 6;
            this.fileSaveAsItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
            this.fileSaveAsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("fileSaveAsItem1.LargeGlyph")));
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
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
            // clipboardBar1
            // 
            this.clipboardBar1.DockCol = 1;
            this.clipboardBar1.DockRow = 0;
            this.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.clipboardBar1.FloatLocation = new System.Drawing.Point(470, 156);
            this.clipboardBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.copyItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pasteItem1)});
            this.clipboardBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // cutItem1
            // 
            this.cutItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.Glyph")));
            this.cutItem1.Id = 9;
            this.cutItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.cutItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cutItem1.LargeGlyph")));
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.Glyph")));
            this.copyItem1.Id = 10;
            this.copyItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.copyItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("copyItem1.LargeGlyph")));
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteItem1
            // 
            this.pasteItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.Glyph")));
            this.pasteItem1.Id = 11;
            this.pasteItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.pasteItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("pasteItem1.LargeGlyph")));
            this.pasteItem1.Name = "pasteItem1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.fileNewItem1);
            this.richEditBarController1.BarItems.Add(this.fileOpenItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.cutItem1);
            this.richEditBarController1.BarItems.Add(this.copyItem1);
            this.richEditBarController1.BarItems.Add(this.pasteItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
            // 
            // HtmlLoadingModule
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "HtmlLoadingModule";
            this.Size = new System.Drawing.Size(845, 389);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpXtraRichEdit)).EndInit();
            this.grpXtraRichEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpWebBrowser)).EndInit();
            this.grpWebBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpPlainHtml)).EndInit();
            this.grpPlainHtml.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtPlainHtml.Properties)).EndInit();
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
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.ClipboardBar clipboardBar1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private DevExpress.XtraEditors.GroupControl grpXtraRichEdit;
        private DevExpress.XtraEditors.GroupControl grpWebBrowser;
        private DevExpress.XtraEditors.GroupControl grpPlainHtml;
        private DevExpress.XtraEditors.MemoEdit edtPlainHtml;
	}
}
