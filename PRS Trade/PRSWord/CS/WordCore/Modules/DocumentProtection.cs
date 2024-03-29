using System;
using System.Collections.Generic;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class DocumentProtectionModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        UserService userService;
        string activeUser = String.Empty;

        public DocumentProtectionModule() {
            InitializeComponent();
            richEditControl.RemoveService(typeof(IUserListService));
            this.userService = new UserService();
            richEditControl.AddService(typeof(IUserListService), this.userService);
            richEditControl.DocumentLoaded += new EventHandler(OnRichEditControl1DocumentLoaded);
            richEditControl.DocumentProtectionChanged += new EventHandler(OnRichEditControlDocumentProtectionChanged);
            OpenXmlLoadHelper.Load("DocumentProtection.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        void OnRichEditControlDocumentProtectionChanged(object sender, EventArgs e) {
            ShowAlert(richEditControl.Document.IsDocumentProtected);
            richEditControl.ClearUndo();
        }
        void ShowAlert(bool show) {
            pnlAlert.Visible = show;
        }
        void OnRichEditControl1DocumentLoaded(object sender, EventArgs e) {
            RangePermissionCollection rangePermissions = richEditControl.Document.BeginUpdateRangePermissions();
            cbUsers.Properties.Items.Clear();
            richEditControl.Document.CancelUpdateRangePermissions(rangePermissions);
            List<String> users = FetchUsers(rangePermissions);
            foreach (String user in users)
                cbUsers.Properties.Items.Add(user);

            userService.Update(users);
            if (users.Count > 0) {
                SetActiveUser(users[0]);
                this.cbUsers.Visible = true;
            }
            else {
                SetActiveUser("guest");
                this.cbUsers.Properties.Items.Add("guest");
                this.cbUsers.Visible = false;
            }
            cbUsers.SelectedIndex = 0;
            ShowAlert(richEditControl.Document.IsDocumentProtected);
        }
        List<String> FetchUsers(RangePermissionCollection rangePermissions) {
            List<String> users = new List<string>();
            foreach (RangePermission rangePermission in rangePermissions) {
                string userName = rangePermission.UserName;
                if (users.Contains(userName))
                    continue;
                if (!String.IsNullOrEmpty(userName))
                    users.Add(userName);
            }
            return users;
        }
        void SetActiveUser(string user) {
            richEditControl.Options.Authentication.EMail = user;
            this.activeUser = user;
        }

        private void cbUsers_SelectedValueChanged(object sender, EventArgs e) {
            SetActiveUser(cbUsers.SelectedItem.ToString());
        }
    }
    public class UserService : IUserListService {
        List<string> users = new List<string>();

        public List<string> Users { get { return users; } }

        #region IUserListService Members
        public IList<string> GetUsers() {
            return Users;
        }
        #endregion
        public void Update(List<String> userList) {
            this.users.Clear();
            this.users.AddRange(userList);
        }
    }
}
