namespace DevExpress.XtraRichEdit.Demos.Forms {
    partial class MergeSimpleDataForm {
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
            this.rgMergeRecords = new DevExpress.XtraEditors.RadioGroup();
            this.txtFrom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.rgMergeTo = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rgMergeRecords.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMergeTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rgMergeRecords
            // 
            this.rgMergeRecords.Location = new System.Drawing.Point(13, 31);
            this.rgMergeRecords.Name = "rgMergeRecords";
            this.rgMergeRecords.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgMergeRecords.Properties.Appearance.Options.UseBackColor = true;
            this.rgMergeRecords.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgMergeRecords.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Current record"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "From:")});
            this.rgMergeRecords.Size = new System.Drawing.Size(205, 72);
            this.rgMergeRecords.TabIndex = 0;
            this.rgMergeRecords.SelectedIndexChanged += new System.EventHandler(this.rgMergeRecords_SelectedIndexChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.EditValue = "1";
            this.txtFrom.Enabled = false;
            this.txtFrom.Location = new System.Drawing.Point(67, 79);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(56, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(140, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(16, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.EditValue = "10";
            this.txtTo.Enabled = false;
            this.txtTo.Location = new System.Drawing.Point(162, 79);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(56, 20);
            this.txtTo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(205, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Merge records";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(143, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(62, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rgMergeTo
            // 
            this.rgMergeTo.Location = new System.Drawing.Point(13, 128);
            this.rgMergeTo.Name = "rgMergeTo";
            this.rgMergeTo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgMergeTo.Properties.Appearance.Options.UseBackColor = true;
            this.rgMergeTo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgMergeTo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Window"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "File")});
            this.rgMergeTo.Size = new System.Drawing.Size(205, 22);
            this.rgMergeTo.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(205, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Merge to";
            // 
            // MergeSimpleDataForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(228, 193);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.rgMergeTo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.rgMergeRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MergeSimpleDataForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Options";
            ((System.ComponentModel.ISupportInitialize)(this.rgMergeRecords.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgMergeTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rgMergeRecords;
        private DevExpress.XtraEditors.TextEdit txtFrom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.RadioGroup rgMergeTo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
