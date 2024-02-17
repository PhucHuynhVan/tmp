using Clean.Win.AppUI.About;
using Clean.Win.AppUI.Features;
using Clean.Win.AppUI.Features.BackupDB;
using Clean.Win.AppUI.Features.Logins;
using Clean.Win.AppUI.Installers.LicenseKey;
using Clean.Win.AppUI.UICommon;
using Clean.WinF.Applications.Features.Article.Interfaces;
using Clean.WinF.Applications.Features.Automat.Interfaces;
using Clean.WinF.Applications.Features.Bobbin.Interfaces;
using Clean.WinF.Applications.Features.Computer.Interfaces;
using Clean.WinF.Applications.Features.Language.Interfaces;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using Clean.WinF.Applications.Features.Supplier.Interfaces;
using Clean.WinF.Applications.Features.SystemConfiguration.Interfaces;
using Clean.WinF.Applications.Features.Systems.Log;
using Clean.WinF.Applications.Features.Thread.Interfaces;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Shared.Constants;
using Serilog;
using System;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Clean.Win.Apps
{
    public partial class MainForm : Form
    {
        public int appID = 0;

        public ILanguageCommandServices _languageCommandService;
        public ILanguageQueryServices _languageQueryService;
        public Clean.WinF.Applications.Features.Menu.Interfaces.IMenuCommandServices _menuCommandService;
        public Clean.WinF.Applications.Features.Menu.Interfaces.IMenuQueryServices _menuQueryService;
        public IPartCommandServices _partCommandService;
        public IPartQueryServices _partQueryService;
        public IArticleCommandServices _articleCommandService;
        public IArticleQueryServices _articleQueryService;
        public IUserQueryServices _userQueryServices;
        public IUserCommandServices _userCommandServices;
        public IAutomatCommandServices _automatCommandServices;
        public IAutomatQueryServices _automatQueryServices;
        public IThreadCommandServices _threadCommandServices;
        public IThreadQueryServices _threadQueryServices;
        public ISupplierCommandServices _supplierCommandServices;
        public ISupplierQueryServices _supplierQueryServices;
        public IBobbinCommandServices _bobbinCommandServices;
        public IBobbinQueryServices _bobbinQueryServices;
        public IDBLogQueryServices _dBLogQueryServices;
        public IWindingParamCommandServices _windingParamCommandServices;
        public IUserGroupCommandServices _userGroupCommandServices;
        public IUserGroupQueryServices _userGroupQueryServicess;
        public IPermissionCommandServices _permissionCommandServices;
        public IRoleCommandServices _roleCommandServices;
        public IComputerCommandServices _computerCommandServices;
        public IComputerQueryServices _computerQueryServices;
        public IChangeNeedleRecordCommandServices _changeNeedleCommandServices;
        public IClipSensorActivationCommandServices _clipSensorActivationCommandServices;
        public ISewingMachingConfigurationCommandServices _sewingMachineConfigurationCommandServices;
        public ISystemConfigurationCommandServices _systemConfigurationCommandServices;

        public bool isUserProcessed = true;
        public Point mousePosition;//will help detect mouse acitvity in the winform applicaton
        int _timeoutCounter = 0;
        int MaxTimoutCounter = 60000;//5 minutes for waiting

        private readonly UICommon uiCommon = UICommon.Instance;

        //Display forms
        LoginForm login = null;
        BackupDBForm backup = null;
        LicenseKeysForm licenseForm = null;
        DebugLogForm debugLogForm = null;
        AboutForm aboutForm = null;
        CustomLogForm customLogForm = null;
        public MainForm(
            ILanguageCommandServices languageCommandService,
            ILanguageQueryServices languageQueryService,
            Clean.WinF.Applications.Features.Menu.Interfaces.IMenuCommandServices menuCommandService,
            Clean.WinF.Applications.Features.Menu.Interfaces.IMenuQueryServices menuQueryService,
            IUserQueryServices userQueryServices,
            IUserCommandServices userCommandServices,
            IPartCommandServices partCommandServices,
            IPartQueryServices partQueryServices,
            IArticleCommandServices articleCommandServices,
            IArticleQueryServices articleQueryServices,
            IAutomatCommandServices automatCommandServices,
            IAutomatQueryServices automatQueryServices,
            ISupplierCommandServices supplierCommandServices,
            ISupplierQueryServices supplierQueryServices,
            IThreadCommandServices threadCommandServices,
            IThreadQueryServices threadQueryServices,
            IBobbinCommandServices bobbinCommandServices,
            IBobbinQueryServices bobbinQueryServices,
            IDBLogQueryServices dBLogQueryServices,
            IWindingParamCommandServices windingParamCommandServices,
            IUserGroupCommandServices userGroupCommandServices,
            IUserGroupQueryServices userGroupQueryServices,
            IPermissionCommandServices permissionCommandServices,
            IRoleCommandServices roleCommandServices,
            IComputerCommandServices computerCommandServices,
            IComputerQueryServices computerQueryServices,
            IChangeNeedleRecordCommandServices changeNeedleCommandServices,
            IClipSensorActivationCommandServices clipSensorActivationCommandServices,
            ISewingMachingConfigurationCommandServices sewingMachineConfigurationCommandServices,
            ISystemConfigurationCommandServices systemConfigurationCommandServices
            )
        {
            try
            {
                //DI services in Mainform constructor
                _languageCommandService = languageCommandService;
                _languageQueryService = languageQueryService;
                _menuCommandService = menuCommandService;
                _menuQueryService = menuQueryService;
                _userQueryServices = userQueryServices;
                _userCommandServices = userCommandServices;
                _partCommandService = partCommandServices;
                _partQueryService = partQueryServices;
                _articleCommandService = articleCommandServices;
                _articleQueryService = articleQueryServices;
                _automatCommandServices = automatCommandServices;
                _automatQueryServices = automatQueryServices;
                _supplierCommandServices = supplierCommandServices;
                _supplierQueryServices = supplierQueryServices;
                _threadCommandServices = threadCommandServices;
                _threadQueryServices = threadQueryServices;
                _bobbinCommandServices = bobbinCommandServices;
                _bobbinQueryServices = bobbinQueryServices;
                _dBLogQueryServices = dBLogQueryServices;
                _windingParamCommandServices = windingParamCommandServices;
                _userGroupCommandServices = userGroupCommandServices;
                _userGroupQueryServicess = userGroupQueryServices;
                _permissionCommandServices = permissionCommandServices;
                _roleCommandServices = roleCommandServices;
                _computerCommandServices = computerCommandServices;
                _computerQueryServices = computerQueryServices;
                _changeNeedleCommandServices = changeNeedleCommandServices;
                _clipSensorActivationCommandServices = clipSensorActivationCommandServices;
                _sewingMachineConfigurationCommandServices = sewingMachineConfigurationCommandServices;
                _systemConfigurationCommandServices = systemConfigurationCommandServices;

                InitializeComponent();
                this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_0_Icon);
                WindowState = FormWindowState.Maximized; // Set the form to maximized state                
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            }
            catch (Exception ex)
            {
                Log.Error("MainForm() error:" + ex.ToString());
            }
        }

        private void InitializeMultiLanguages()
        {
            CultureInfo systemCulture = CultureInfo.InstalledUICulture;
            this.Tag = systemCulture.TwoLetterISOLanguageName;
            appID = _languageQueryService.GetApplicationIDByName(UIConstants.APP_0_Name);
            uiCommon.ProcessMultipleLanguages(this, this, UIConstants.Main_GUI, this.Tag.ToString());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Log.Information("Begin MainForm_FormClosing");
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (MessageBox.Show(UIConstants.MSG_MAIN_FORM_CLOSING, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        //do something
                    }
                    else
                    {
                        //exit application as normal
                    }
                }
                Log.CloseAndFlush();
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("Error: MainForm_FormClosing() ", ex.Message, Environment.NewLine, ex.StackTrace));
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeMultiLanguages();
                var encryptKey = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionKey];
                var encryptIV = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionIV];
                if (!RegUtility.IsExistingLicenseKey(encryptKey, encryptIV) || !RegUtility.IsInvalidLicense(encryptKey, encryptIV))
                    DisplayActiveLicenseKeyForm(false);
                DisplayStatusBarInformation();
                DisplayActiveLoginForm(false);
                lblUserLogin.Text = "User id: " + UIUtility.userLogin;
                this.lblSpaceStatus.Width = this.Width - lblComputer.Width - lblLicense.Width - lblCurrentTime.Width - 25;
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("Error: MainForm_Load() ", ex.Message, Environment.NewLine, ex.StackTrace));
            }
        }


        private void mnuThread_Click(object sender, EventArgs e)
        {
            this.displayThreadsForm();
        }

        private void displayThreadsForm()
        {
            lblContentTitle.Text = "Material Threads";
            lblContentTitle.Width = pnlContentTitle.Width;
            uiCommon.DisplayingThreadsInformation(this);
        }
        private void displayBobbinsForm()
        {
            lblContentTitle.Text = "Bobbins";
            lblContentTitle.Width = pnlContentTitle.Width;
            uiCommon.DisplayingBobbinsInformation(this);
        }
        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            this.displaySupplierForm();
        }
        private void displaySupplierForm()
        {
            lblContentTitle.Text = "Material Supplier";
            lblContentTitle.Width = pnlContentTitle.Width;
            uiCommon.DisplayingSupplierInformation(this);
        }

        private void mnuPart_Click(object sender, EventArgs e)
        {
            lblContentTitle.Text = "Material " + mnuPart.Text;
            lblContentTitle.Width = pnlContentTitle.Width;
            uiCommon.DisplayingPartInformation(this, MenuEnums.Parts);
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayLeftMenu(this, pnlLeftMenu, this.btnOthers, this.treeLeftMenu, this.imgLeftMenuList);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text.Equals("Log out"))
                btnLogin.Text = "Log in";
            DisplayActiveLoginForm(false);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayLeftMenu(this, pnlLeftMenu, this.btnLanguage, this.treeLeftMenu, this.imgLeftMenuList);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var marginValue = 6;
            uiCommon.DisplayLeftMenu(this, pnlLeftMenu, this.btnMenu, this.treeLeftMenu, this.imgLeftMenuList);
            treeLeftMenu.Top = btnMenu.Top + btnMenu.Height + marginValue;
            btnReport.Top = treeLeftMenu.Top + treeLeftMenu.Height + marginValue;
            btnBobbin.Top = btnReport.Top + btnReport.Height + marginValue;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayLeftMenu(this, pnlLeftMenu, this.btnReport, this.treeLeftMenu, this.imgLeftMenuList);
        }

        private void btnBobbin_Click(object sender, EventArgs e)
        {
            // uiCommon.DisplayLeftMenu(this, pnlLeftMenu, this.btnBobbin, this.treeLeftMenu, this.imgLeftMenuList);
            displayBobbinsForm();
        }

        #region Display subforms at main form directly
        //Login form
        private void DisplayActiveLoginForm(bool isTimeout)
        {
            login = UIUtility.GetActiveFormOpenning(UIFormNameConstants.LOGIN) as LoginForm;
            if (login is null || !login.Visible)
            {
                DisplayLoginForm(isTimeout);
            }
            else
            {
                login.Dispose();
                DisplayLoginForm(isTimeout);
            }
        }

        private void DisplayLoginForm(bool isTimeout)
        {
            login = new LoginForm(this);//constructor injection
            login.OnFormClose += OnClosingForm;

            Form myMainForm = btnLogin.FindForm();
            login.isTimeout = isTimeout;
            login.Owner = myMainForm;
            login.ShowDialog();
        }

        private void OnClosingForm(Control subControl)
        {
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.LOGIN))
                login = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.BACKUPDB))
                backup = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.LICENSEKEY))
                licenseForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.DEBUGLOG))
                debugLogForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.ABOUT))
                aboutForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.CUSTOMLOG))
                customLogForm = null;
        }

        //Backup database form
        private void DisplayActiveBackupForm()
        {
            backup = UIUtility.GetActiveFormOpenning(UIFormNameConstants.BACKUPDB) as BackupDBForm;
            if (backup is null || !backup.Visible)
            {
                DisplayBackupForm();
            }
            else
            {
                backup.Dispose();
                DisplayBackupForm();
            }
        }

        private void DisplayBackupForm()
        {
            backup = new BackupDBForm(this);//constructor injection
            backup.OnFormClose += OnClosingForm;
            backup.Owner = this;
            backup.ShowDialog();
        }

        //License key form
        private void DisplayActiveLicenseKeyForm(bool isCalledFromTopMenu)
        {
            licenseForm = UIUtility.GetActiveFormOpenning(UIFormNameConstants.LICENSEKEY) as LicenseKeysForm;
            if (licenseForm is null || !licenseForm.Visible)
            {
                DisplayLicenseForm(isCalledFromTopMenu);
            }
            else
            {
                licenseForm.Dispose();
                DisplayLicenseForm(isCalledFromTopMenu);
            }
        }

        private void DisplayLicenseForm(bool isCalledFromTopMenu)
        {
            licenseForm = new LicenseKeysForm(this);//constructor injection
            licenseForm.isCalledFromMenu = isCalledFromTopMenu;
            licenseForm.OnFormClose += OnClosingForm;
            licenseForm.Owner = this;
            licenseForm.ShowDialog();
        }

        public void DisplayStatusBarInformation()
        {
            lblComputer.Text = "Computer: " + Environment.MachineName;

            var encryptKey = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionKey];
            var encryptIV = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionIV];
            if (RegUtility.IsTrialLicenseKey(encryptKey, encryptIV))
                lblLicense.Text = "Trial: " + RegUtility.GetRemainingDaysTrial(encryptKey, encryptIV) + " remaining day(s)";
            else
                lblLicense.Text = "Licensed: " + RegUtility.GetRemainingDaysTrial(encryptKey, encryptIV) + " remaining day(s)";
        }

        //debug log form
        private void DisplayActiveDebugLogForm()
        {
            debugLogForm = UIUtility.GetActiveFormOpenning(UIFormNameConstants.DEBUGLOG) as DebugLogForm;
            if (debugLogForm is null || !debugLogForm.Visible)
            {
                DisplayDebugLogForm();
            }
            else
            {
                debugLogForm.Dispose();
                DisplayDebugLogForm();
            }
        }

        private void DisplayDebugLogForm()
        {
            debugLogForm = new DebugLogForm(this);//constructor injection
            debugLogForm.OnFormClose += OnClosingForm;
            debugLogForm.Owner = this;
            debugLogForm.ShowDialog();
        }

        //about form
        private void DisplayActiveAboutForm()
        {
            aboutForm = UIUtility.GetActiveFormOpenning(UIFormNameConstants.ABOUT) as AboutForm;
            if (aboutForm is null || !aboutForm.Visible)
            {
                DisplayAboutForm();
            }
            else
            {
                aboutForm.Dispose();
                DisplayAboutForm();
            }
        }

        private void DisplayAboutForm()
        {
            aboutForm = new AboutForm(this);
            aboutForm.OnFormClose += OnClosingForm;
            aboutForm.Owner = this;
            aboutForm.ShowDialog();
        }

        //custom log form
        private void DisplayActiveCustomLogForm()
        {
            customLogForm = UIUtility.GetActiveFormOpenning(UIFormNameConstants.CUSTOMLOG) as CustomLogForm;
            if (customLogForm is null || !customLogForm.Visible)
            {
                DisplayCustomLogForm();
            }
            else
            {
                customLogForm.Dispose();
                DisplayCustomLogForm();
            }
        }

        private void DisplayCustomLogForm()
        {
            customLogForm = new CustomLogForm(this);
            customLogForm.OnFormClose += OnClosingForm;
            customLogForm.Owner = this;
            customLogForm.ShowDialog();
        }

        #endregion

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuArticle_Click(object sender, EventArgs e)
        {
            lblContentTitle.Text = "Material " + mnuArticle.Text;
            lblContentTitle.Width = pnlContentTitle.Width;
            uiCommon.DisplayingArticleInformation(this, MenuEnums.Articles);
        }

        private void mnuBackupDatabase_Click(object sender, EventArgs e)
        {
            DisplayActiveBackupForm();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            _timeoutCounter += 1000;
            lblCurrentTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            // Check for keyboard activity
            if (Control.ModifierKeys != Keys.None || Control.MousePosition != mousePosition)
            {
                _timeoutCounter = 0;
                mousePosition = Control.MousePosition;
            }

            // Check if the session has timed out
            if (_timeoutCounter >= MaxTimoutCounter)
            {
                DisplayActiveLoginForm(true);
                _timeoutCounter = 0;
                this.btnLogin.Text = "Login";
            }
        }

        private void mnuLogInformation_Click(object sender, EventArgs e)
        {
            DisplayActiveDebugLogForm();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            DisplayAboutForm();
        }

        private void mnuLicense_Click(object sender, EventArgs e)
        {
            DisplayActiveLicenseKeyForm(true);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location;
        }

        private void mnuAppLanguage_Click(object sender, EventArgs e)
        {
            if (mnuAppLanguage.Text.Equals("EN"))
                mnuAppLanguage.Text = "DE";
            else
                mnuAppLanguage.Text = "EN";
        }
    }
}
