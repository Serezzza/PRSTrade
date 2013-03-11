using System;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class ViewsModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public ViewsModule() {
            InitializeComponent();
            RtfLoadHelper.Load("TextWithImages.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        private void ViewsModule_Load(object sender, EventArgs e) {
            rgrpViewType.EditValue = RichEditViewType.PrintLayout;
        }
        private void rgrpViewType_SelectedIndexChanged(object sender, EventArgs e) {
            richEditControl.ActiveViewType = (RichEditViewType)rgrpViewType.EditValue;
        }
        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
        void richEditControl_ActiveViewChanged(object sender, EventArgs e) {
            rgrpViewType.EditValue = richEditControl.ActiveViewType;
        }
    }
}
