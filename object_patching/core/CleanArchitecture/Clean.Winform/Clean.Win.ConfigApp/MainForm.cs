using Clean.Win.AppUI.About;
using Clean.Win.AppUI.Features;
using Clean.Win.AppUI.Features.Logins;
using Clean.Win.AppUI.UICommon;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Article.Interfaces;
using Clean.WinF.Applications.Features.Automat.Interfaces;
using Clean.WinF.Applications.Features.Bobbin.Interfaces;
using Clean.WinF.Applications.Features.Computer.DTOs;
using Clean.WinF.Applications.Features.Computer.Interfaces;
using Clean.WinF.Applications.Features.Language.Interfaces;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using Clean.WinF.Applications.Features.SerialNumber.Interfaces;
using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using Clean.WinF.Applications.Features.Supplier.Interfaces;
using Clean.WinF.Applications.Features.SystemConfiguration.Interfaces;
using Clean.WinF.Applications.Features.Systems.Log;//Clean.WinF.Applications.Features.DBLog;
using Clean.WinF.Applications.Features.Thread.Interfaces;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Shared.Constants;
using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Clean.WinF.Domain.SeedData;

namespace Clean.Win.Apps
{
    public partial class MainForm : Form
    {
        public int appID = 1;

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

        public IComputerCommandServices _computerCommandServices;
        public ISystemConfigurationCommandServices _systemConfigurationCommandServices;

        public ISewingMachingConfigurationCommandServices _sewingMachineConfigurationCommandServices;
        public IClipSensorActivationCommandServices _clipSensorActivationCommandServices;
        public IPortCommandServices _portCommandServices;
        public IDeviceTypeCommandServices _deviceTypeCommandServices;
        public IDeviceRoutingCommandServices _deviceRoutingeCommandServices;
        public IConnectedDeviceCommandServices _connectedDeviceCommandServices;

        // For Serial Number
        public ISerialNumberCommandServices _serialNumberCommandServices;
        public ICounterTypeCommandServices _counterTypeCommandServices;
        public IResetTypeCommandServices _resetTypeCommandServices;

        public IPermissionCommandServices _permissionCommandServices;

        public bool isUserProcessed = true;
        public Point mousePosition;//will help detect mouse acitvity in the winform applicaton

        int _timeoutCounter = 0;
        int MaxTimeoutCounter = 0;

        private readonly UICommon uiCommon = UICommon.Instance;

        //Display forms
        LoginForm login = null;
        //BackupDBForm backup = null;
        //LicenseKeysForm licenseForm = null;
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
            IComputerCommandServices computerCommandServices,
            ISystemConfigurationCommandServices systemConfigurationCommandServices,
            ISewingMachingConfigurationCommandServices sewingMachineConfigurationCommandServices,
            IClipSensorActivationCommandServices clipSensorActivationCommandServices,
            IPortCommandServices portCommandServices,
            IDeviceTypeCommandServices deviceTypeCommandServices,
            IDeviceRoutingCommandServices deviceRoutingCommandServices,
            IConnectedDeviceCommandServices connectedDeviceCommandServices,
            ISerialNumberCommandServices serialNumberCommandServices,
            ICounterTypeCommandServices counterTypeCommandServices,
            IResetTypeCommandServices resetTypeCommandServices,
            IPermissionCommandServices permissionCommandServices
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
                _computerCommandServices = computerCommandServices;
                _systemConfigurationCommandServices = systemConfigurationCommandServices;
                _sewingMachineConfigurationCommandServices = sewingMachineConfigurationCommandServices;
                _clipSensorActivationCommandServices = clipSensorActivationCommandServices;
                _portCommandServices = portCommandServices;
                _deviceTypeCommandServices = deviceTypeCommandServices;
                _deviceRoutingeCommandServices = deviceRoutingCommandServices;
                _connectedDeviceCommandServices = connectedDeviceCommandServices;
                _serialNumberCommandServices = serialNumberCommandServices;
                _counterTypeCommandServices = counterTypeCommandServices;
                _resetTypeCommandServices = resetTypeCommandServices;
                _permissionCommandServices = permissionCommandServices;

                InitializeComponent();
                InitializeAutomatDataAsync();
                this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_1_Icon);
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
            appID = _languageQueryService.GetApplicationIDByName(UIConstants.APP_1_Name);
            uiCommon.ProcessMultipleLanguages(this, this, UIConstants.Main_GUI_Config, this.Tag.ToString());
        }
        List<AutomatDto> automatDtos;
        private async Task InitializeAutomatDataAsync()
        {

            automatDtos = await this._automatQueryServices.ListAllAsync();
            await Console.Out.WriteLineAsync();
        }
        private void InitializeAutomatDataGrid()
        {

            this.configGridViewColumn(this.dgrAutomatConfig, "Code", "Code", "DataGridViewImageColumn", 40);
            this.configGridViewColumn(this.dgrAutomatConfig, "Name", "Name", "DataGridViewImageColumn", 40);

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
                radProjectConfiguration.Checked = true;
                this.grpDatabaseInformation.Visible = false;
                GetApplicationSessionTimeoutValue();
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("Error: MainForm_Load() ", ex.Message, Environment.NewLine, ex.StackTrace));
            }
        }

        private void GetApplicationSessionTimeoutValue()
        {
            var isAllowedAppTimeout = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingIsAllowedApplicationTimeout];

            bool.TryParse(isAllowedAppTimeout, out bool isAllowed);
            if (isAllowed)
            {
                var appTimeoutValue = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingApplicationTimeoutValue];
                int.TryParse(appTimeoutValue, out int timeout);
                MaxTimeoutCounter = timeout * 60000; //calculate minutes for waiting
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

            //Form myMainForm = btnLogin.FindForm();
            login.isTimeout = isTimeout;
            //login.Owner = myMainForm;
            login.ShowDialog();
        }

        private void OnClosingForm(Control subControl)
        {
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.LOGIN))
                login = null;
            //if (subControl != null && subControl.Name.Equals(UIFormNameConstants.BACKUPDB))
            //    backup = null;
            //if (subControl != null && subControl.Name.Equals(UIFormNameConstants.LICENSEKEY))
            //    licenseForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.DEBUGLOG))
                debugLogForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.ABOUT))
                aboutForm = null;
            if (subControl != null && subControl.Name.Equals(UIFormNameConstants.CUSTOMLOG))
                customLogForm = null;
        }

        #endregion

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            if (MaxTimeoutCounter > 0)
            {
                _timeoutCounter += 1000;
                // Check for keyboard activity
                if (Control.ModifierKeys != Keys.None || Control.MousePosition != mousePosition)
                {
                    _timeoutCounter = 0;
                    mousePosition = Control.MousePosition;
                }

                // Check if the session has timed out
                if (_timeoutCounter >= MaxTimeoutCounter)
                {
                    DisplayActiveLoginForm(true);
                    _timeoutCounter = 0;
                    //this.btnLogin.Text = "Login";
                }
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location;
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
            if (this.btnOpenClose.Text.Equals("Close"))
            {
                this.btnOpenClose.Text = "Open";
                this.btnOpenClose.BackColor = Color.Red;

                uiCommon.ActivateMainTopMenu(this, false);
            }
            else
            {
                DisplayActiveLoginForm(false);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayDBConfigurationInformation(this);
        }


        private void btnAutomat_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayLeftMenuFormating(this, btnAutomat);
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            LoadAllComputers();
            uiCommon.DisplayLeftMenuFormating(this, btnComputer);
        }
        // For debugging
        List<ComputerDto> computerDtos;
        List<SewingMachineConfigurationDto> sewingMachineDtos;
        List<SerialNumberDto> serialNumberDtos;
        int _selectedRowComputerIdx = -1;
        int _selectedRowAutomatIdx = -1;
        int _selectedRowSewingMachineIdx = -1;
        int _selectedRowSerialNumberIdx = -1;

        // End For debugging
        private async Task<List<ComputerDto>> InitializeComputertDataAsync()
        {

            var dbData = await _computerCommandServices.ListAllAsync();
            if (dbData.Count == 0)
            {
                var rs = await _computerCommandServices.CreateBulk(new List<ComputerDto>()
                {
                    new ComputerDto(){MachineNumber = 1,Name="HC-C-004XH", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                });
                if (rs)
                {
                    dbData = await _computerCommandServices.ListAllAsync();
                    await Console.Out.WriteLineAsync();
                }
            }
            return dbData;
        }
        private async Task<List<SewingMachineConfigurationDto>> InitializeSewingMachineConfigurationDataAsync()
        {

            var dbData = await _sewingMachineConfigurationCommandServices.ListAllAsync();
            return dbData;
        }
        private async Task<List<SerialNumberDto>> InitializeSerialNumberDataAsync()
        {

            var dbData = await _serialNumberCommandServices.ListAllAsync();
            return dbData;
        }
        private void configComputersGridView()
        {
            this.dgrComputer.Visible = true;
            this.dgrComputer.SelectionChanged += onGridViewSelectionChangedComputer;
            this.dgrComputer.CellClick += onComputerCellClick;
        }

        private void configSewingMachineGridView()
        {
            this.dgrMachine.Visible = true;
            this.dgrMachine.SelectionChanged += onGridViewSelectionChangedSewingMachine;
            this.dgrMachine.CellClick += onSewingMachineCellClick;
        }
        private void configSerialNumberGridView()
        {
            this.dgrSerialNumber.Visible = true;
            this.dgrSerialNumber.SelectionChanged += onGridViewSelectionChangedSerialNumber;
            this.dgrSerialNumber.CellClick += onSerialNumberCellClick;

            dgrSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in dgrSerialNumber.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void reloadComputersGridView(List<ComputerDto> dtos)
        {
            dgrComputer.Rows.Clear();
            dgrComputer.RowCount = dtos.Count;
            for (int i = 0; i < dtos.Count; i++)
            {
                dgrComputer[0, i].Value = dtos[i].Name;
                dgrComputer[1, i].Value = dtos[i].MachineNumber;
            }
            dgrComputer.Refresh();
        }
        private void reloadSewingMachineGridView(List<SewingMachineConfigurationDto> dtos)
        {
            dgrMachine.Rows.Clear();
            dgrMachine.RowCount = dtos.Count; ;
            for (int i = 0; i < dtos.Count; i++)
            {
                dgrMachine[0, i].Value = dtos[i].MachineNumber;
            }
            dgrMachine.Refresh();
        }
        private void reloadSerialNumberGridView(List<SerialNumberDto> dtos)
        {
            dgrSerialNumber.Rows.Clear();
            dgrSerialNumber.RowCount = dtos.Count;
            for (int i = 0; i < dtos.Count; i++)
            {
                dgrSerialNumber[0, i].Value = dtos[i].ID;
                dgrSerialNumber[1, i].Value = dtos[i].InternalName;
            }
            dgrSerialNumber.Refresh();
        }
        private void LoadAllComputers()
        {
            this.grpDatabaseInformation.Visible = false;
            this.configComputersGridView();
            this.configSewingMachineGridView();
            if (computerDtos == null)
                computerDtos = InitializeComputertDataAsync().Result;
            sewingMachineDtos = InitializeSewingMachineConfigurationDataAsync().Result;

            this.reloadComputersGridView(computerDtos);
            this.reloadSewingMachineGridView(sewingMachineDtos);
        }
        private void onGridViewSelectionChangedComputer(object sender, EventArgs e)
        {

            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
                    this._selectedRowComputerIdx = selectedRow.Index;
                }
            }
        }


        private void onGridViewSelectionChangedAutomatConfig(object sender, EventArgs e)
        {

            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
                    this._selectedRowAutomatIdx = selectedRow.Index;
                }
            }
        }

        private void onGridViewSelectionChangedSewingMachine(object sender, EventArgs e)
        {

            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
                    this._selectedRowSewingMachineIdx = selectedRow.Index;
                }
            }
        }
        private void onGridViewSelectionChangedSerialNumber(object sender, EventArgs e)
        {

            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
                    this._selectedRowSerialNumberIdx = selectedRow.Index;
                }
            }
        }

        private void onComputerCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx >= 0)
            {
                // Lay du lieu cua dong hien tai
                // Check xem du lieu co ton tai hay khong
                // Load system config dua vao machine ID
                uiCommon.DisplayComputerConfiguration(this, this.computerDtos[_selectedRowComputerIdx]);
            }
        }
        public ComputerDto getCurrentRowDataComputer()
        {
            ComputerDto ret = null;
            if (_selectedRowComputerIdx != -1)
            {
                ret = this.computerDtos[_selectedRowComputerIdx];
            }

            return ret;
        }
        private void onSewingMachineCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx >= 0)
            {
                // Lay du lieu cua dong hien tai
                // Check xem du lieu co ton tai hay khong
                var tmp = this.sewingMachineDtos[_selectedRowSewingMachineIdx];
                // Load Sewing Machine dua vao machine ID
                uiCommon.DisplaySewingMachineConfiguration(this, this.sewingMachineDtos);
            }
        }

        private void onSerialNumberCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx >= 0)
            {
                // Lay du lieu cua dong hien tai
                // Check xem du lieu co ton tai hay khong
                // Load Sewing Machine dua vao machine ID
                var tmp = this._selectedRowSerialNumberIdx;
                uiCommon.DisplaySerialNumberConfiguration(this, this.serialNumberDtos[this._selectedRowSerialNumberIdx]);
            }
        }

        private void onAutomatCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx >= 0)
            {
                // Lay du lieu cua dong hien tai
                // Check xem du lieu co ton tai hay khong
                // Load Sewing Machine dua vao machine ID
                uiCommon.DisplayingAutomatInformation(this, automatDtos[_selectedRowAutomatIdx]);
            }
        }

        private void btnBobbin_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayBobbinsConfiguration(this);
        }

        private void lblComputerMachine_Click(object sender, EventArgs e)
        {
            if (!this.dgrComputer.Visible)
            {
                this.configComputersGridView();
                if (computerDtos == null)
                    computerDtos = InitializeComputertDataAsync().Result;
                this.reloadComputersGridView(computerDtos);
            }
            else
                this.dgrComputer.Visible = false;
            uiCommon.FormatDisplayingLeftMenu(this);
        }

        private async void lblSewingMachine_Click(object sender, EventArgs e)
        {
            if (!this.dgrMachine.Visible)
            {
                this.configSewingMachineGridView();
                if (computerDtos == null)
                    computerDtos = InitializeComputertDataAsync().Result;
                sewingMachineDtos = InitializeSewingMachineConfigurationDataAsync().Result;
                this.reloadSewingMachineGridView(sewingMachineDtos);
            }
            else
                this.dgrMachine.Visible = false;

            uiCommon.FormatDisplayingLeftMenu(this);
        }

        private void lblAutomatConfig_Click(object sender, EventArgs e)
        {

            this.dgrAutomatConfig.AutoGenerateColumns = false;
            this.dgrAutomatConfig.DataSource = null;
            this.dgrAutomatConfig.DataSource = automatDtos;
            this.dgrAutomatConfig.Refresh();
            var rowHeight = 24;
            if (!this.dgrAutomatConfig.Visible)
            {
                this.dgrAutomatConfig.Visible = true;

                this.dgrAutomatConfig.SelectionChanged += onGridViewSelectionChangedAutomatConfig;
                this.dgrAutomatConfig.CellClick += onAutomatCellClick;
                //display the height of gridview correctly with number of rows
                if (dgrAutomatConfig.Rows.Count > 0)
                {
                    _selectedRowAutomatIdx = 0;
                    dgrAutomatConfig.Height = rowHeight * dgrAutomatConfig.Rows.Count;
                    this.dgrAutomatConfig.CurrentCell = this.dgrAutomatConfig.Rows[0].Cells[0];
                    uiCommon.DisplayingAutomatInformation(this, automatDtos[_selectedRowAutomatIdx]);

                }
            }
            else
            {
                dgrAutomatConfig.Height = rowHeight;
                this.dgrAutomatConfig.Visible = false;
            }

            uiCommon.FormatDisplayingLeftMenu(this);
        }
        private void configGridViewColumn(DataGridView dataGridView,
           string header, string property, string type, int width = 150, bool isHightlight = false)
        {
            DataGridViewColumn column;
            switch (type)
            {
                case "DataGridViewImageColumn":
                    column = new DataGridViewImageColumn();
                    break;
                default:
                    column = new DataGridViewTextBoxColumn();
                    break;

            }
            column.HeaderText = header;
            column.DataPropertyName = property;
            column.Tag = property;
            column.Width = width;
            column.ReadOnly = false;
            column.DefaultCellStyle.BackColor = isHightlight ? Color.LightYellow : Color.White;
            dataGridView.Columns.Add(column);
        }

        private void lblSerialNumer_Click(object sender, EventArgs e)
        {
            if (!this.dgrSerialNumber.Visible)
            {
                this.configSerialNumberGridView();
                if (serialNumberDtos == null)
                {
                    serialNumberDtos = InitializeSerialNumberDataAsync().Result;
                }
                this.reloadSerialNumberGridView(serialNumberDtos);
            }
            else
                this.dgrSerialNumber.Visible = false;
            uiCommon.FormatDisplayingLeftMenu(this);
        }

        private void lblProjectSpecific_Click(object sender, EventArgs e)
        {
            if (!this.dgrProjectSpecific.Visible)
                this.dgrProjectSpecific.Visible = true;
            else
                this.dgrProjectSpecific.Visible = false;
            uiCommon.FormatDisplayingLeftMenu(this);
        }

        private void lblStockThread_Click(object sender, EventArgs e)
        {
            if (!this.dgrStockThread.Visible)
                this.dgrStockThread.Visible = true;
            else
                this.dgrStockThread.Visible = false;
            uiCommon.FormatDisplayingLeftMenu(this);
        }

        private void lblLabelDef_Click(object sender, EventArgs e)
        {
            if (!this.dgrLabelDef.Visible)
                this.dgrLabelDef.Visible = true;
            else
                this.dgrLabelDef.Visible = false;
            uiCommon.FormatDisplayingLeftMenu(this);
        }

        private void lblPrinterscript_Click(object sender, EventArgs e)
        {
            if (!this.dgrPrinterScript.Visible)
                this.dgrPrinterScript.Visible = true;
            else
                this.dgrPrinterScript.Visible = false;
            uiCommon.FormatDisplayingLeftMenu(this);
        }

        private void btnScannedPart_Click(object sender, EventArgs e)
        {
            if (!this.dgrPrinterScript.Visible)
                this.dgrPrinterScript.Visible = true;
            else
                this.dgrPrinterScript.Visible = false;
            uiCommon.FormatDisplayingLeftMenu(this);
        }

        private void btnCommonSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayPermissionConfiguration(this);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {

        }

        private void btnWinding_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayWindingParamConfiguration(this);
        }

        private void btnDefValue_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            uiCommon.DisplayUserConfiguration(this);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnAddComputer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSewingMachine_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAutomatConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnDBRefresh_Click(object sender, EventArgs e)
        {
            //Clean.WinF.Infrastructure.RefreshDB.RefreshDBConnection.RefreshDBConn();
        }
    }
}
