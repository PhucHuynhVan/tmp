using Clean.Win.Apps;
using Clean.Win.AppUI.UICommon;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Shared.Constants;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Installers.LicenseKey
{
    public partial class LicenseKeysForm : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        private readonly Clean.Win.AppUI.UICommon.UICommon uiCommon = Clean.Win.AppUI.UICommon.UICommon.Instance;
        bool isSuccessProcess = false;
        public bool isCalledFromMenu = false;
        bool isLoadForm = false;
        public LicenseKeysForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void LicenseKeysForm_Load(object sender, EventArgs e)
        {
            isLoadForm = true;
            var encryptKey = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionKey];
            var encryptIV = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionIV];//vector key value
            if (RegUtility.IsExistingLicenseKey(encryptKey, encryptIV))
            {
                radTrialKey.Enabled = false;
                radTrialKey.Checked = false;
                radLicenseKey.Checked = true;
                lblDayOfUsage.Visible = false;
                cboTrialDays.Visible = false;
                txtLicenseKey.Visible = true;
                txtLicenseKey.Focus();
                var remainingDay = RegUtility.GetRemainingDaysTrial(encryptKey, encryptIV);
                this.lblStatus.Text = "Your license: " + remainingDay + " remaining day(s).";
            }

            if (!RegUtility.IsTrialLicenseKey(encryptKey, encryptIV))
            {
                txtLicenseKey.Text = RegUtility.GetLicenseKey(encryptKey, encryptIV);
                txtLicenseKey.ReadOnly = true;
                btnProcess.Enabled = false;
            }
            isLoadForm = false;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidInput())
                    return;
                var encryptKey = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionKey];
                var encryptIV = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionIV];//vector key value
                var parentKey = @"SOFTWARE\\" + RegistryKeyConstants.OrganizationName + "\\" + RegistryKeyConstants.ProductName;
                CreateRegistryKey(parentKey, encryptKey, encryptIV);
                _mainForm.DisplayStatusBarInformation();
                isSuccessProcess = true;
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CreateRegistryKey(string parentKey, string encryptKey, string encryptIV)
        {
            var key = Registry.CurrentUser.OpenSubKey(parentKey, true);
            if (key is null)
            {
                key = Registry.CurrentUser.CreateSubKey(parentKey, true);
            }

            var registeredDate = DateTime.Now.ToString();
            key.SetValue(RegistryKeyConstants.RegisteredDate, EncryptUtility.EncryptString(registeredDate, encryptKey, encryptIV));
            if (radTrialKey.Checked)
            {
                key.SetValue(RegistryKeyConstants.IsTrial, EncryptUtility.EncryptString("1", encryptKey, encryptIV), RegistryValueKind.String);
                key.SetValue(RegistryKeyConstants.UsageOfDays, EncryptUtility.EncryptString(cboTrialDays.SelectedItem.ToString().Trim(), encryptKey, encryptIV), RegistryValueKind.String);
                key.SetValue(RegistryKeyConstants.AllowingTrialCount, EncryptUtility.EncryptString("100", encryptKey, encryptIV), RegistryValueKind.String);
                key.SetValue(RegistryKeyConstants.LicenseKey, EncryptUtility.EncryptString("", encryptKey, encryptIV), RegistryValueKind.String);
            }
            else
            {
                key.SetValue(RegistryKeyConstants.IsTrial, EncryptUtility.EncryptString("0", encryptKey, encryptIV), RegistryValueKind.String);
                key.SetValue(RegistryKeyConstants.LicenseKey, EncryptUtility.EncryptString(txtLicenseKey.Text.Trim(), encryptKey, encryptIV), RegistryValueKind.String);
                key.SetValue(RegistryKeyConstants.UsageOfDays, EncryptUtility.EncryptString("360", encryptKey, encryptIV), RegistryValueKind.String);
                key.SetValue(RegistryKeyConstants.AllowingTrialCount, EncryptUtility.EncryptString("0", encryptKey, encryptIV), RegistryValueKind.String);
            }
            key.Close();
        }
        private bool IsValidInput()
        {
            var result = true;
            if (radTrialKey.Checked)
            {
                if (cboTrialDays.SelectedItem is null || string.IsNullOrEmpty(cboTrialDays.SelectedItem.ToString()))
                {
                    UIUtility.AppShowMsg("Please select day value which you like to use for trial");
                    result = false;
                }
            }

            if (radLicenseKey.Checked)
            {
                if (string.IsNullOrEmpty(txtLicenseKey.Text))
                {
                    UIUtility.AppShowMsg("Please enter your valid license key to activate your license");
                    result = false;
                }
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radLicenseKey_CheckedChanged(object sender, EventArgs e)
        {
            cboTrialDays.Visible = false;
            txtLicenseKey.Visible = true;
            txtLicenseKey.ReadOnly = false;
            lblDayOfUsage.Visible = false;
        }

        private void radTrialKey_CheckedChanged(object sender, EventArgs e)
        {
            txtLicenseKey.Visible = false;
            cboTrialDays.Visible = true;
            lblDayOfUsage.Visible = true;
        }

        private void DoClosingForm()
        {
            if (isSuccessProcess || isCalledFromMenu)
                OnFormClose.Invoke(this);
            else
                Application.Exit();
        }

        private void LicenseKeysForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void InitializeLanguages()
        {
            uiCommon.ProcessMultipleLanguages(_mainForm, this, UIConstants.Backup_GUI, _mainForm.Tag.ToString().Trim());
        }

        private void cboTrialDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnProcess.Enabled = true;
        }

        private void txtLicenseKey_TextChanged(object sender, EventArgs e)
        {
            if (!isLoadForm)
            {
                btnProcess.Enabled = true;
            }
        }
    }
}
