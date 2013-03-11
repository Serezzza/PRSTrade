using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class StylesModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public StylesModule() {
            InitializeComponent();
            RtfLoadHelper.Load("Styles.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
            ribbonControl1.SelectedPage = homeRibbonPage1;
        }
    }
}
