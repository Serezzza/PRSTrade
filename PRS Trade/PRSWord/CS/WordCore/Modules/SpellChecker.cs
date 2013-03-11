using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraSpellChecker.Native;
using DevExpress.XtraSpellChecker.Parser;
using DevExpress.XtraRichEdit.SpellChecker;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class SpellCheckerModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public SpellCheckerModule() {
            InitializeComponent();
            RtfLoadHelper.Load("SpellChecker.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        private void SpellCheckerModule_Load(object sender, EventArgs e) {
            if (DesignMode)
                return;

            SpellCheckerHelper.AddDictionaries(sharedDictionaryStorage1);

            spellChecker1.SpellCheckMode = checkEdit1.Checked ? SpellCheckMode.AsYouType : SpellCheckMode.OnDemand;
        }
        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
        private void checkSpellingItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            spellChecker1.Check(richEditControl);
        }
        private void richEditControl_ReadOnlyChanged(object sender, EventArgs e) {
            this.checkSpellingItem.Enabled = !richEditControl.ReadOnly;
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            if (checkEdit1.Checked)
                spellChecker1.SpellCheckMode = SpellCheckMode.AsYouType;
            else
                spellChecker1.SpellCheckMode = SpellCheckMode.OnDemand;
        }
    }
}
