using Clean.Win.Apps;
using Clean.Win.AppUI.UICommon;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Shared.Constants;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Features.Logins
{
    public partial class LoginForm : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        public bool isTimeout = false;
        private readonly Clean.Win.AppUI.UICommon.UICommon uiCommon = Clean.Win.AppUI.UICommon.UICommon.Instance;
        public LoginForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_1_Icon);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UIUtility.userLogin))
                Application.Exit();
            else
                this.Close();
        }

        private void DoClosingForm()
        {
            OnFormClose.Invoke(this);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DoLogin(this.txtUserID.Text.Trim(), this.txtPassword.Text.Trim()))
            {
                UIUtility.userLogin = txtUserID.Text.Trim();
                _mainForm.btnOpenClose.Text = "Close";
                _mainForm.btnOpenClose.BackColor = Color.Green;
                if (!_mainForm.timerNow.Enabled)
                {
                    _mainForm.timerNow.Enabled = true;
                    _mainForm.timerNow.Start();
                }
                uiCommon.ActivateMainTopMenu(_mainForm, true);
                this.Close();
            }
            else
            {
                UIUtility.AppShowMsg("User name or password are incorrect please check again.", UIConstants.MSGBOX_ICON_ERROR_STYLE);
            }
        }

        private bool DoLogin(String userId, String password)
        {
            bool ret = false;
            var encryptKey = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionKey];
            var encryptIV = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionIV];
            password = EncryptUtility.EncryptString(password, encryptKey, encryptIV);
            var findUser = this._mainForm._userCommandServices.login(userId, password).Result;
            if (findUser != null)
                ret = true;
            return ret;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = true;
            this.txtUserID.Focus();
            InitializeLanguages();
            if (isTimeout)
            {
                _mainForm.timerNow.Enabled = false;
                _mainForm.timerNow.Stop();
                this.btnCancel.Enabled = false;
            }
        }

        private void InitializeLanguages()
        {
            uiCommon.ProcessMultipleLanguages(_mainForm, this, UIConstants.Login_GUI_Config, _mainForm.Tag.ToString().Trim());
        }
    }
}
