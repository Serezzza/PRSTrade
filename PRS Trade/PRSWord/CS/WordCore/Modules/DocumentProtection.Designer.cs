namespace DevExpress.XtraRichEdit.Demos {
    partial class DocumentProtectionModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentProtectionModule));
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.pnlAlert = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLoggedInAs = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbUsers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.documentProtectionBar1 = new DevExpress.XtraRichEdit.UI.DocumentProtectionBar();
            this.protectDocumentItem1 = new DevExpress.XtraRichEdit.UI.ProtectDocumentItem();
            this.changeRangeEditingPermissionsItem1 = new DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem();
            this.unprotectDocumentItem1 = new DevExpress.XtraRichEdit.UI.UnprotectDocumentItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.pnlAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.Location = new System.Drawing.Point(0, 95);
            this.richEditControl.MenuManager = this;
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Size = new System.Drawing.Size(738, 332);
            this.richEditControl.TabIndex = 0;
            this.richEditControl.Text = "richEditControl1";
            // 
            // pnlAlert
            // 
            this.pnlAlert.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnlAlert.Controls.Add(this.label2);
            this.pnlAlert.Controls.Add(this.label1);
            this.pnlAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlert.Location = new System.Drawing.Point(0, 31);
            this.pnlAlert.Name = "pnlAlert";
            this.pnlAlert.Size = new System.Drawing.Size(738, 32);
            this.pnlAlert.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Permission is currently restricted. Only specified users can edit part of this co" +
                "ntent.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Restricted Access";
            // 
            // lbLoggedInAs
            // 
            this.lbLoggedInAs.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLoggedInAs.Location = new System.Drawing.Point(2, 5);
            this.lbLoggedInAs.Name = "lbLoggedInAs";
            this.lbLoggedInAs.Padding = new System.Windows.Forms.Padding(3, 3, 5, 0);
            this.lbLoggedInAs.Size = new System.Drawing.Size(108, 21);
            this.lbLoggedInAs.TabIndex = 1;
            this.lbLoggedInAs.Text = "You are logged in as ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cbUsers);
            this.panelControl2.Controls.Add(this.lbLoggedInAs);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panelControl2.Size = new System.Drawing.Size(738, 31);
            this.panelControl2.TabIndex = 5;
            // 
            // cbUsers
            // 
            this.cbUsers.Location = new System.Drawing.Point(107, 7);
            this.cbUsers.MenuManager = this;
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsers.Size = new System.Drawing.Size(173, 20);
            this.cbUsers.TabIndex = 2;
            this.cbUsers.SelectedValueChanged += new System.EventHandler(this.cbUsers_SelectedValueChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.documentProtectionBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.protectDocumentItem1,
            this.changeRangeEditingPermissionsItem1,
            this.unprotectDocumentItem1});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // documentProtectionBar1
            // 
            this.documentProtectionBar1.DockCol = 0;
            this.documentProtectionBar1.DockRow = 0;
            this.documentProtectionBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.documentProtectionBar1.FloatLocation = new System.Drawing.Point(353, 154);
            this.documentProtectionBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.protectDocumentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeRangeEditingPermissionsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.unprotectDocumentItem1)});
            this.documentProtectionBar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            // 
            // protectDocumentItem1
            // 
            this.protectDocumentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("protectDocumentItem1.Glyph")));
            this.protectDocumentItem1.Id = 0;
            this.protectDocumentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("protectDocumentItem1.LargeGlyph")));
            this.protectDocumentItem1.Name = "protectDocumentItem1";
            // 
            // changeRangeEditingPermissionsItem1
            // 
            this.changeRangeEditingPermissionsItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("changeRangeEditingPermissionsItem1.Glyph")));
            this.changeRangeEditingPermissionsItem1.Id = 1;
            this.changeRangeEditingPermissionsItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("changeRangeEditingPermissionsItem1.LargeGlyph")));
            this.changeRangeEditingPermissionsItem1.Name = "changeRangeEditingPermissionsItem1";
            // 
            // unprotectDocumentItem1
            // 
            this.unprotectDocumentItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("unprotectDocumentItem1.Glyph")));
            this.unprotectDocumentItem1.Id = 2;
            this.unprotectDocumentItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("unprotectDocumentItem1.LargeGlyph")));
            this.unprotectDocumentItem1.Name = "unprotectDocumentItem1";
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 63);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(738, 32);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(738, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Size = new System.Drawing.Size(738, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(738, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.protectDocumentItem1);
            this.richEditBarController1.BarItems.Add(this.changeRangeEditingPermissionsItem1);
            this.richEditBarController1.BarItems.Add(this.unprotectDocumentItem1);
            this.richEditBarController1.RichEditControl = this.richEditControl;
            // 
            // DocumentProtectionModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richEditControl);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.pnlAlert);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DocumentProtectionModule";
            this.Size = new System.Drawing.Size(738, 450);
            this.pnlAlert.ResumeLayout(false);
            this.pnlAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RichEditControl richEditControl;
        private DevExpress.XtraEditors.LabelControl lbLoggedInAs;
        private System.Windows.Forms.Panel pnlAlert;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraRichEdit.UI.DocumentProtectionBar documentProtectionBar1;
        private DevExpress.XtraRichEdit.UI.ProtectDocumentItem protectDocumentItem1;
        private DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem changeRangeEditingPermissionsItem1;
        private DevExpress.XtraRichEdit.UI.UnprotectDocumentItem unprotectDocumentItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraEditors.ComboBoxEdit cbUsers;
    }
}
