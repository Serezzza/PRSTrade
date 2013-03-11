namespace DevExpress.XtraNavBar.Demos {
    partial class AddGroups {
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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = null;
            this.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Location = new System.Drawing.Point(4, 4);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(140, 265);
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add New Group";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete Last Group";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.navBarControl1);
            this.Name = "AddGroups";
            this.Size = new System.Drawing.Size(295, 273);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.SimpleButton button2;
        private System.ComponentModel.Container components = null;

    }
}
