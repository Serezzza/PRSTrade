using System;
using DevExpress.Tutorials;
using System.Drawing;
using DevExpress.Utils.About;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class About : ucAboutPage {
		public About() {
			InitializeComponent();
		}

        #region Properies
        protected override string ProductText { get { return "Microsoft Word® Style Rich Text Editor for WinForms.\r\n\r\nThe DevExpress Rich Text Editor allows you to introduce Microsoft Word like text editing capabilities into your next Windows Forms application with ease. The XtraRichEdit provides advanced text formatting capabilities and delivers numerous end-user options helping you deliver compelling business solutions for the Windows Forms platform."; } }
        protected override Image ProductImage { get { return DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraRichEdit.Demos.Images.XtraRichEdit.png", typeof(frmMain).Assembly); } }
        protected override Image ProductImageLight { get { return DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraRichEdit.Demos.Images.XtraRichEdit_light.png", typeof(frmMain).Assembly); } }
        protected override ProductKind ProductKind { get { return ProductKind.XtraRichEdit; } }
        #endregion
	}
}

