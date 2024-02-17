using BiasysControl.Features;
using BiasysControl.Features.Bobbin;
using BiasysControl.Features.Logins;
using BiasysControl.Features.Order;
using BiasysControl.UICommon;
using Clean.Win.AppUI.Forms;
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
using System.Configuration;
using System.Globalization;

namespace BiasysControl
{
    public partial class MainForm : Form
    {
        public int appID = 2;

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

        public bool isProcessedData = false;
        public bool isUserProcessed = true;
        public Point mousePosition;//will help detect mouse acitvity in the winform applicaton
        int _timeoutCounter = 0;
        int MaxTimoutCounter = 60000;//5 minutes for waiting

        private readonly BiasysControl.UICommon.UICommon uiCommon = BiasysControl.UICommon.UICommon.Instance;

        //Display forms
        LoginForm login = null;
        DebugLogForm debugLogForm = null;
        CustomLogForm customLogForm = null;
        AutomatSelect automatSelect = null;
        BobbinNumberInput bobbinNumberInput = null;
        OrderNumberInput orderNumberInput = null;
        public MainForm(
            //ILanguageCommandServices languageCommandService,
            //ILanguageQueryServices languageQueryService,
            //Clean.WinF.Applications.Features.Menu.Interfaces.IMenuCommandServices menuCommandService,
            //Clean.WinF.Applications.Features.Menu.Interfaces.IMenuQueryServices menuQueryService,
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
            //IUserGroupCommandServices userGroupCommandServices,
            //IUserGroupQueryServices userGroupQueryServices,
            //IPermissionCommandServices permissionCommandServices,
            //IRoleCommandServices roleCommandServices,
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
                //_languageCommandService = languageCommandService;
                //_languageQueryService = languageQueryService;
                //_menuCommandService = menuCommandService;
                //_menuQueryService = menuQueryService;
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
                //_userGroupCommandServices = userGroupCommandServices;
                //_userGroupQueryServicess = userGroupQueryServices;
                //_permissionCommandServices = permissionCommandServices;
                //_roleCommandServices = roleCommandServices;
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
            appID = 0;//_languageQueryService.GetApplicationIDByName(UIConstants.APP_2_Name);
            //uiCommon.ProcessMultipleLanguages(this, this, UIConstants.Main_GUI, this.Tag.ToString());
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
                lblTitle2.Left = (pnlTitle.Width / 2) - (lblTitle.Width / 2);
                lblTitle.Left = (pnlTitle.Width / 2) - (lblTitle.Width / 2);
                uiCommon.DisplayInitialAppInformation(this);
                InitializeMultiLanguages();
                var encryptKey = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionKey];
                var encryptIV = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionIV];
                //if (!RegUtility.IsExistingLicenseKey(encryptKey, encryptIV) || !RegUtility.IsInvalidLicense(encryptKey, encryptIV))
                //DisplayActiveLicenseKeyForm(false);
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
            Form myMainForm = this;
            login.isTimeout = isTimeout;
            login.Owner = myMainForm;
            login.ShowDialog();
        }

        private void OnClosingForm(Control subControl)
        {
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.LOGIN))
                login = null;
            //if (subControl != null && subControl.Name.Equals(UIFormNameConstants.LICENSEKEY))
            //    licenseForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.DEBUGLOG))
                debugLogForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.CUSTOMLOG))
                customLogForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.AUTOMATSELECT))
                automatSelect = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.BOBBINNUMBERINPUT))
                bobbinNumberInput = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.ORDERNUMBERINPUT))
                orderNumberInput = null;
        }

        //License key form
        //private void DisplayActiveLicenseKeyForm(bool isCalledFromTopMenu)
        //{
        //    licenseForm = UIUtility.GetActiveFormOpenning(UIFormNameConstants.LICENSEKEY) as LicenseKeysForm;
        //    if (licenseForm is null || !licenseForm.Visible)
        //    {
        //        DisplayLicenseForm(isCalledFromTopMenu);
        //    }
        //    else
        //    {
        //        licenseForm.Dispose();
        //        DisplayLicenseForm(isCalledFromTopMenu);
        //    }
        //}

        //private void DisplayLicenseForm(bool isCalledFromTopMenu)
        //{
        //    licenseForm = new LicenseKeysForm(this);//constructor injection
        //    licenseForm.isCalledFromMenu = isCalledFromTopMenu;
        //    licenseForm.OnFormClose += OnClosingForm;
        //    licenseForm.Owner = this;
        //    licenseForm.ShowDialog();
        //}

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

        //automat select form
        public void DisplayActiveAutomatForm()
        {
            automatSelect = UIUtility.GetActiveFormOpenning(UIFormNameConstants.AUTOMATSELECT) as AutomatSelect;
            if (automatSelect is null || !automatSelect.Visible)
            {
                if (login != null)
                {
                    login.Dispose();
                    EnableMainButtons(false);
                    InitializeButtonValue();
                    uiCommon.DisplayAppContent(this);
                    btnRestartApp.Enabled = true;
                    btnQuitApp.Enabled = true;
                }
                DisplayAutomatSelectionForm();
            }
            else
            {
                automatSelect.Dispose();
                DisplayAutomatSelectionForm();
            }
        }

        private void DisplayAutomatSelectionForm()
        {
            automatSelect = new AutomatSelect(this);
            automatSelect.OnFormClose += OnClosingForm;
            automatSelect.Owner = this;
            automatSelect.ShowDialog();
        }

        //bobbin number form
        public void DisplayActiveBobbinNumberForm()
        {
            bobbinNumberInput = UIUtility.GetActiveFormOpenning(UIFormNameConstants.BOBBINNUMBERINPUT) as BobbinNumberInput;
            if (bobbinNumberInput is null || !bobbinNumberInput.Visible)
            {
                if (automatSelect != null) automatSelect.Dispose();
                DisplayBobbinNumberInputForm();
            }
            else
            {
                bobbinNumberInput.Dispose();
                DisplayBobbinNumberInputForm();
            }
        }

        private void DisplayBobbinNumberInputForm()
        {
            bobbinNumberInput = new BobbinNumberInput(this);
            bobbinNumberInput.OnFormClose += OnClosingForm;
            bobbinNumberInput.Owner = this;
            bobbinNumberInput.ShowDialog();
        }

        //order number form
        public void DisplayActiveOrderNumberForm()
        {
            orderNumberInput = UIUtility.GetActiveFormOpenning(UIFormNameConstants.BOBBINNUMBERINPUT) as OrderNumberInput;
            if (orderNumberInput is null || !orderNumberInput.Visible)
            {
                //if (bobbinNumberInput != null) bobbinNumberInput.Dispose();
                if (login != null)
                {
                    login.Dispose();
                    EnableMainButtons(false);
                    InitializeButtonValue();
                    uiCommon.DisplayAppContent(this);
                    btnRestartApp.Enabled = true;
                    btnQuitApp.Enabled = true;
                }
                this.lblTitle.Text = "Scan Order or Family";
                DisplayOrderNumberInputForm();
            }
            else
            {
                
                orderNumberInput.Dispose();
                DisplayOrderNumberInputForm();
            }
        }

        private void DisplayOrderNumberInputForm()
        {
            orderNumberInput = new OrderNumberInput(this);
            orderNumberInput.OnFormClose += OnClosingForm;
            orderNumberInput.Owner = this;
            orderNumberInput.ShowDialog();
        }

        //custom log form
        public void DisplayActiveCustomLogForm()
        {
            customLogForm = UIUtility.GetActiveFormOpenning(UIFormNameConstants.CUSTOMLOG) as CustomLogForm;
            if (customLogForm is null || !customLogForm.Visible)
            {
                if (login != null)
                    login.Dispose();
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
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location;
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Height < 839 || this.Width < 1447)
            {
                this.Height = 839;
                this.Width = 1447;
                return;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Left = (pnlTitle.Width / 2) - (lblTitle.Width / 2);
        }

        public void InitializeButtonValue()
        {
            this.btnChangeNeedleThread.Text = "change needle thread";
            this.btnChangeBobbin.Text = "change bobbin";
            this.btnWindingBobbin.Text = "winding a bobbin";
            this.btnChangeStitchLength.Text = "change stitchlength";
            this.btnNewNeedle.Text = "new needle";
            this.btnReprint.Text = "reprint";
            this.btnNewSeam.Text = "new seam";
            this.btnNewArticleAndOrder.Text = "new article/order";
            this.btnStandardSewing.Text = "standard seewing";
            this.btnRestartApp.Text = "restart";
            this.btnQuitApp.Text = "quit";
        }

        public void EnableMainButtons(bool isEnable)
        {
            this.btnWindingBobbin.Enabled = isEnable;
            this.btnChangeBobbin.Enabled = isEnable;
            this.btnChangeNeedleThread.Enabled = isEnable;
            this.btnChangeStitchLength.Enabled = isEnable;
            this.btnNewArticleAndOrder.Enabled = isEnable;
            this.btnNewNeedle.Enabled = isEnable;
            this.btnNewSeam.Enabled = isEnable;
            this.btnQuitApp.Enabled = isEnable;
            this.btnRestartApp.Enabled = isEnable;
            this.btnStandardSewing.Enabled = isEnable;
            this.btnReprint.Enabled = isEnable;
            this.btn01.Enabled = isEnable;
            this.btn02.Enabled = isEnable;
        }

        public void UpdateMassageHeader(string msg1, string msg2)
        {
            this.lblTitle2.Text = msg1;
            this.lblTitle.ForeColor = Color.Red;
            this.lblTitle2.Visible = true;
            this.lblTitle.Text = msg2;
        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestartApp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit(); // close the current instance
        }
    }
}
