using System;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class RibbonModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        UserService userService;
        public RibbonModule() {
            InitializeComponent();
            RegisterUserListService();
            OpenXmlLoadHelper.Load("MovieRentals.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
            ribbonControl1.SelectedPage = homeRibbonPage1;
        }

        void RibbonModule_Load(object sender, EventArgs e) {
            if (DesignMode)
                return;

            SpellCheckerHelper.AddDictionaries(sharedDictionaryStorage1);
        }

        private void richEditControl_StartHeaderFooterEditing(object sender, HeaderFooterEditingEventArgs e) {
            headerFooterToolsRibbonPageCategory1.Visible = true;
            ribbonControl1.SelectedPage = headerFooterToolsDesignRibbonPage1;
        }

        private void richEditControl_FinishHeaderFooterEditing(object sender, HeaderFooterEditingEventArgs e) {
            headerFooterToolsRibbonPageCategory1.Visible = false;
        }

        private void richEditControl_SelectionChanged(object sender, EventArgs e) {
            tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable();
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected;
        }
        void RegisterUserListService() {
            this.richEditControl.RemoveService(typeof(IUserListService));
            this.userService = new UserService();
            this.userService.Users.Add("lawyer@somecompany.com");
            this.userService.Users.Add("projectmanager@somecompany.com");
            this.userService.Users.Add("senior@somecompany.com");
            this.userService.Users.Add("novice@somecompany.com");
            this.richEditControl.AddService(typeof(IUserListService), this.userService);
        }
    }
}
