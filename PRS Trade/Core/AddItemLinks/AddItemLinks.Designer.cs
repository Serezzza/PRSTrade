namespace DevExpress.XtraNavBar.Demos {
    partial class AddItemLinks {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemLinks));
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.button3 = new DevExpress.XtraEditors.SimpleButton();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add New ItemLink to the Active Group";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.AllowSelectedLink = true;
            this.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.EachGroupHasSelectedLink = true;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1});
            this.navBarControl1.LargeImages = this.imageCollection1;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 172;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(172, 352);
            this.navBarControl1.SmallImages = this.imageCollection2;
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 8;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl1_ActiveGroupChanged);
            this.navBarControl1.SelectedLinkChanged += new DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(this.navBarControl1_SelectedLinkChanged);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Small Links";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Home";
            this.navBarItem1.LargeImageIndex = 0;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImageIndex = 0;
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Large Links";
            this.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete Selected ItemLink from the Active Group";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(318, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "New Item Image:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete Item for the Selected Link";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(416, 112);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(64, 20);
            this.imageComboBoxEdit1.TabIndex = 13;
            // 
            // AddItemLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageComboBoxEdit1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.navBarControl1);
            this.Name = "AddItemLinks";
            this.Size = new System.Drawing.Size(511, 352);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.AddItemLinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraEditors.SimpleButton button2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.SimpleButton button3;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private System.ComponentModel.IContainer components;
    }
}
