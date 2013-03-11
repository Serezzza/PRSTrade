namespace DevExpress.XtraNavBar.Demos {
    partial class DistanceChanger {
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
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.checkBox1 = new DevExpress.XtraEditors.CheckEdit();
            this.trackBar1 = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.EditValue = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Properties.Caption = "Enabled";
            this.checkBox1.Size = new System.Drawing.Size(138, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.EditValue = null;
            this.trackBar1.Location = new System.Drawing.Point(148, 8);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Properties.Maximum = 50;
            this.trackBar1.Size = new System.Drawing.Size(224, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // DistanceChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "DistanceChanger";
            this.Size = new System.Drawing.Size(376, 48);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.CheckEdit checkBox1;
        private DevExpress.XtraEditors.TrackBarControl trackBar1;
        private System.ComponentModel.Container components = null;

    }
}
