namespace DevExpress.XtraNavBar.Demos {
    partial class GroupStyles {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupStyles));
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbContactImage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbLocalImage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbContactStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbLocalStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ceAllowSelectedLink = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbContactImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocalImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbContactStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocalStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowSelectedLink.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Inbox";
            this.navBarItem1.LargeImageIndex = 0;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImageIndex = 0;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Outbox";
            this.navBarItem2.LargeImageIndex = 1;
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImageIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Local";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup1.LargeImageIndex = 5;
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImageIndex = 5;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Sent Items";
            this.navBarItem3.Enabled = false;
            this.navBarItem3.LargeImageIndex = 2;
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImageIndex = 2;
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Deleted Items";
            this.navBarItem4.Enabled = false;
            this.navBarItem4.LargeImageIndex = 3;
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImageIndex = 3;
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Report";
            this.navBarItem5.LargeImageIndex = 4;
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImageIndex = 4;
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Calendar";
            this.navBarItem6.LargeImageIndex = 7;
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImageIndex = 7;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7});
            this.navBarControl1.LargeImages = this.imageList1;
            this.navBarControl1.Location = new System.Drawing.Point(4, 4);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(140, 368);
            this.navBarControl1.SmallImages = this.imageList2;
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 21;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Contacts";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup2.LargeImageIndex = 6;
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImageIndex = 6;
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Task";
            this.navBarItem7.LargeImageIndex = 8;
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImageIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbContactImage);
            this.groupControl1.Controls.Add(this.cbLocalImage);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cbContactStyle);
            this.groupControl1.Controls.Add(this.cbLocalStyle);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.ceAllowSelectedLink);
            this.groupControl1.Location = new System.Drawing.Point(160, 16);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 200);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Properties";
            // 
            // cbContactImage
            // 
            this.cbContactImage.Location = new System.Drawing.Point(160, 160);
            this.cbContactImage.Name = "cbContactImage";
            this.cbContactImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbContactImage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbContactImage.Size = new System.Drawing.Size(136, 20);
            this.cbContactImage.TabIndex = 8;
            this.cbContactImage.SelectedIndexChanged += new System.EventHandler(this.cbContactImage_SelectedIndexChanged);
            // 
            // cbLocalImage
            // 
            this.cbLocalImage.Location = new System.Drawing.Point(160, 128);
            this.cbLocalImage.Name = "cbLocalImage";
            this.cbLocalImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLocalImage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLocalImage.Size = new System.Drawing.Size(136, 20);
            this.cbLocalImage.TabIndex = 7;
            this.cbLocalImage.SelectedIndexChanged += new System.EventHandler(this.cbLocalImage_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "\'Contacts\' group image:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "\'Local\' group image:";
            // 
            // cbContactStyle
            // 
            this.cbContactStyle.Location = new System.Drawing.Point(160, 96);
            this.cbContactStyle.Name = "cbContactStyle";
            this.cbContactStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbContactStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbContactStyle.Size = new System.Drawing.Size(136, 20);
            this.cbContactStyle.TabIndex = 4;
            this.cbContactStyle.SelectedIndexChanged += new System.EventHandler(this.cbContactStyle_SelectedIndexChanged);
            // 
            // cbLocalStyle
            // 
            this.cbLocalStyle.Location = new System.Drawing.Point(160, 64);
            this.cbLocalStyle.Name = "cbLocalStyle";
            this.cbLocalStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLocalStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLocalStyle.Size = new System.Drawing.Size(136, 20);
            this.cbLocalStyle.TabIndex = 3;
            this.cbLocalStyle.SelectedIndexChanged += new System.EventHandler(this.cbLocalStyle_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "\'Contacts\' group style:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "\'Local\' group style:";
            // 
            // ceAllowSelectedLink
            // 
            this.ceAllowSelectedLink.Location = new System.Drawing.Point(16, 32);
            this.ceAllowSelectedLink.Name = "ceAllowSelectedLink";
            this.ceAllowSelectedLink.Properties.Caption = "Allow Selected Link";
            this.ceAllowSelectedLink.Size = new System.Drawing.Size(144, 18);
            this.ceAllowSelectedLink.TabIndex = 0;
            this.ceAllowSelectedLink.CheckedChanged += new System.EventHandler(this.ceAllowSelectedLink_CheckedChanged);
            // 
            // GroupStyles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.navBarControl1);
            this.Name = "GroupStyles";
            this.Size = new System.Drawing.Size(571, 376);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbContactImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocalImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbContactStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocalStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowSelectedLink.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit ceAllowSelectedLink;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbLocalStyle;
        private DevExpress.XtraEditors.ComboBoxEdit cbContactStyle;
        private DevExpress.XtraEditors.ComboBoxEdit cbContactImage;
        private DevExpress.XtraEditors.ComboBoxEdit cbLocalImage;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.ComponentModel.IContainer components;

    }
}
