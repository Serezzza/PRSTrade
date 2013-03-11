using System;
using System.Windows.Forms;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class HyperlinksModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public HyperlinksModule() {
            InitializeComponent();

            RtfLoadHelper.Load("Hyperlinks.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
            UpdateBookmarkVisibility();
            UpdateBookmarkColor();
        }

        private void chkShowBookmarks_CheckedChanged(object sender, EventArgs e) {
            UpdateBookmarkVisibility();
        }
        private void colorEdit1_ColorChanged(object sender, EventArgs e) {
            UpdateBookmarkColor();
        }
        private void UpdateBookmarkVisibility() {
            this.richEditControl.Options.Bookmarks.Visibility = chkShowBookmarks.Checked ? RichEditBookmarkVisibility.Visible : RichEditBookmarkVisibility.Hidden;
        }
        private void UpdateBookmarkColor() {
            this.richEditControl.Options.Bookmarks.Color = colorEdit1.Color;
        }
        private void chkShowToolTip_CheckedChanged(object sender, EventArgs e) {
            this.richEditControl.Options.Hyperlinks.ShowToolTip = chkShowToolTip.Checked;
        }
        private void chkCtrl_CheckedChanged(object sender, EventArgs e) {
            if (chkCtrl.Checked)
                this.richEditControl.Options.Hyperlinks.ModifierKeys |= Keys.Control;
            else
                this.richEditControl.Options.Hyperlinks.ModifierKeys &= ~Keys.Control;
        }
        private void chkAlt_CheckedChanged(object sender, EventArgs e) {
            if (chkAlt.Checked)
                this.richEditControl.Options.Hyperlinks.ModifierKeys |= Keys.Alt;
            else
                this.richEditControl.Options.Hyperlinks.ModifierKeys &= ~Keys.Alt;
        }
        private void chkShift_CheckedChanged(object sender, EventArgs e) {
            if (chkShift.Checked)
                this.richEditControl.Options.Hyperlinks.ModifierKeys |= Keys.Shift;
            else
                this.richEditControl.Options.Hyperlinks.ModifierKeys &= ~Keys.Shift;
        }
    }
}
