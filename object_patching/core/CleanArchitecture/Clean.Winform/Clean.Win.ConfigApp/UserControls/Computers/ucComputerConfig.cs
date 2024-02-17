using Clean.WinF.Applications.Features.Computer.DTOs;
using Clean.WinF.Applications.Features.Computer.Interfaces;
using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Language.Interfaces;
using Clean.WinF.Applications.Features.SystemConfiguration.Constants;
using Clean.WinF.Applications.Features.SystemConfiguration.DTOs;
using Clean.WinF.Applications.Features.SystemConfiguration.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clean.Win.AppConfigUI.UserControls.Computers
{
    public partial class ucComputerConfig : UserControl
    {
        private readonly IComputerCommandServices _computerCommandServices;
        private readonly ISystemConfigurationCommandServices _systemConfigurationCommandServices;
        private readonly ILanguageQueryServices _languageQueryServices;

        ComputerDto _computerData = new ComputerDto();
        List<LanguageDto> _languageData = new List<LanguageDto>();

        //public ucComputerConfig(ISystemConfigurationCommandServices systemConfigurationCommandServices, ILanguageQueryServices languageQueryService, ComputerDto dto)
        public ucComputerConfig(IComputerCommandServices computerCommandServices, ISystemConfigurationCommandServices systemConfigurationCommandServices, ILanguageQueryServices languageQueryService, ComputerDto dto)
        {
            _computerCommandServices = computerCommandServices;
            _systemConfigurationCommandServices = systemConfigurationCommandServices;
            _languageQueryServices = languageQueryService;
            _computerData = dto;
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            this.configLanguageCombobox();
            this.configForm();
            this.refreshData();
        }
        private void configForm()
        {
            this.tsbCopy.Enabled = false;
            this.tsbDelete.Enabled = false;
        }

        private void refreshFormData()
        {
            if (this._computerData != null)
            {
                this.txtMachineName.Text = this._computerData.Name;
                this.comboBoxMachineNumber.Text = this._computerData.MachineNumber.ToString();
            }
            if (this._computerData.systemConfigs != null)
            {
                this.cbArticle.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_ARTICLES).Permission.Equals("1");
                this.cbThread.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_MATERIAL_THREADS).Permission.Equals("1");
                this.cbPart.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_MATERIAL_FABRICS).Permission.Equals("1");
                this.cbStockThread.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_STOCK_THREADS).Permission.Equals("1");
                this.cbStockFabrics.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_STOCK_FABRICS).Permission.Equals("1");
                this.cBFabricRoll.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_FABRIC_ROLL).Permission.Equals("1");
                this.cBUserManagement.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_USER_MANAGEMENT).Permission.Equals("1");
                this.cBGroupPermission.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_USERGROUP_PERMISSION).Permission.Equals("1");
                this.cbMachineComputer.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_MACHINE_COMPUTER_CONFIGURATION).Permission.Equals("1");
                this.cBBobbin.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_BOBBIN).Permission.Equals("1");
                this.cbJobManagement.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_JOB_MANAGEMENT).Permission.Equals("1");
                this.cbArticleScannedBiasControl.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_ARTICLELABEL_SCANNED_WITH_BIASYSCONTROL).Permission.Equals("1");
                this.cBProjectSpecifiecData.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_PROJECT_SPECIFIC_DATA).Permission.Equals("1");
                this.cBProductionData.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_PRODUCTION_DATA).Permission.Equals("1");
                this.cBShowPrintReport.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_MISCELLANEOUS_SHOW_AND_PRINTREPORT).Permission.Equals("1");
                this.cBAutomatParameter.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_MISCELLANEOUS_AUTOMAT_CONFIGURATION).Permission.Equals("1");
                this.cBSABConfiguration.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_MISCELLANEOUS_SAB_CONFIGURATION).Permission.Equals("1");
                this.cbLogonAtProgramStartBiasysControl.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.CT_LOGON_AT_PROGRAM_START).Permission.Equals("1");
                this.tBDirectoryofProtocolFilebyBiasysControl.Text = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_DIRECTORY_OF_PROTOCOL_FILES_WRITTEN_BY_BIASYSCONTROL).Permission;
                this.cBLogonwithBarcodeandUserCard.Checked = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.CT_LOGON_WITH_BARCODE_HANDHELD_SCANNER_AND_USER_CARD).Permission.Equals("1");
                this.txtMaxtimeBetweenProgramStartEnd.Text = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.CT_MAXTIME_SPAN_BETWEEN_PROGRAM_END_START_INDAYS).Permission;
                this.tBDirectoryAndFilenameofSABBackup.Text = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.DB_DIRECTORY_AND_FILENAME_OF_SAB_BACKUP_APPLICATION).Permission;
                this.cbBiasControlLanguage.Text = this._computerData.FindSystemConfigurationValue(SystemConfigurationConstant.CT_LANGUAGE).Permission;
            }
        }
        private async void configLanguageCombobox()
        {
            var laguage = await _languageQueryServices.GetAlls();
            this._languageData = laguage;
            foreach (var language in this._languageData)
            {
                this.cbBiasControlLanguage.Items.Add(language.Lang);
            }
        }
        private async void refreshData()
        {
            //var result = await _computerCommandServices.ListAllAsync();
            //var dbData = (List<ComputerDto>)result;
            //var tmp = this._computerData;

            if (this._computerData != null)
            {
                this._computerData.systemConfigs = await this._systemConfigurationCommandServices.ListAllAsync();
            }
            this.refreshFormData();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }
        private ComputerDto getComputerData()
        {
            var dto = new ComputerDto();

            String computerName = this.txtMachineName.Text;
            String machineNumber = this.comboBoxMachineNumber.Text;

            dto.Name = computerName;
            dto.MachineNumber = Convert.ToInt32(machineNumber);

            return dto;
        }

        private List<SystemConfigurationDtos> getSystemData()
        {
            var currentComputerDto = this._computerData;
            bool cbArticle = this.cbArticle.Checked;
            bool cbThread = this.cbThread.Checked;
            bool cbPart = this.cbPart.Checked;
            bool cbStockThread = this.cbStockThread.Checked;
            bool cbStockFabrics = this.cbStockFabrics.Checked;
            bool cBFabricRoll = this.cBFabricRoll.Checked;
            bool cBUserManagement = this.cBUserManagement.Checked;
            bool cBGroupPermission = this.cBGroupPermission.Checked;
            bool cbMachineComputer = this.cbMachineComputer.Checked;
            bool cBBobbin = this.cBBobbin.Checked;
            bool cbJobManagement = this.cbJobManagement.Checked;
            bool cbArticleScannedBiasControl = this.cbArticleScannedBiasControl.Checked;
            bool cBProjectSpecifiecData = this.cBProjectSpecifiecData.Checked;
            bool cBProductionData = this.cBProductionData.Checked;
            bool cBShowPrintReport = this.cBShowPrintReport.Checked;
            bool cBAutomatParameter = this.cBAutomatParameter.Checked;
            bool cBSABConfiguration = this.cBSABConfiguration.Checked;
            bool cbLogonAtProgramStartBiasysControl = this.cbLogonAtProgramStartBiasysControl.Checked;
            string cbBiasControlLanguage = this.cbBiasControlLanguage.Text;
            string tBDirectoryofProtocolFilebyBiasysControl = this.tBDirectoryofProtocolFilebyBiasysControl.Text;
            bool cBLogonwithBarcodeandUserCard = this.cBLogonwithBarcodeandUserCard.Checked;
            string txtMaxtimeBetweenProgramStartEnd = this.txtMaxtimeBetweenProgramStartEnd.Text;
            string tBDirectoryAndFilenameofSABBackup = this.tBDirectoryAndFilenameofSABBackup.Text;



            List<SystemConfigurationDtos> systemConfigs = currentComputerDto.systemConfigs;
            {
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_ARTICLES).Permission = cbArticle ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_MATERIAL_THREADS).Permission = cbThread ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_MATERIAL_FABRICS).Permission = cbPart ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_STOCK_THREADS).Permission = cbStockThread ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_STOCK_FABRICS).Permission = cbStockFabrics ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_FABRIC_ROLL).Permission = cBFabricRoll ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_USER_MANAGEMENT).Permission = cBUserManagement ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_USERGROUP_PERMISSION).Permission = cBGroupPermission ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_MACHINE_COMPUTER_CONFIGURATION).Permission = cbMachineComputer ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_BOBBIN).Permission = cBBobbin ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_FORM_JOB_MANAGEMENT).Permission = cbJobManagement ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_ARTICLELABEL_SCANNED_WITH_BIASYSCONTROL).Permission = cbArticleScannedBiasControl ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_PROJECT_SPECIFIC_DATA).Permission = cBProjectSpecifiecData ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_PRODUCTION_DATA).Permission = cBProductionData ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_MISCELLANEOUS_SHOW_AND_PRINTREPORT).Permission = cBShowPrintReport ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_MISCELLANEOUS_AUTOMAT_CONFIGURATION).Permission = cBAutomatParameter ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_MISCELLANEOUS_SAB_CONFIGURATION).Permission = cBSABConfiguration ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.CT_LOGON_AT_PROGRAM_START).Permission = cbLogonAtProgramStartBiasysControl ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_DIRECTORY_AND_FILENAME_OF_SAB_BACKUP_APPLICATION).Permission = tBDirectoryAndFilenameofSABBackup;
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.CT_LOGON_WITH_BARCODE_HANDHELD_SCANNER_AND_USER_CARD).Permission = cBLogonwithBarcodeandUserCard ? "1" : "0";
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.CT_MAXTIME_SPAN_BETWEEN_PROGRAM_END_START_INDAYS).Permission = txtMaxtimeBetweenProgramStartEnd;
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_DIRECTORY_OF_PROTOCOL_FILES_WRITTEN_BY_BIASYSCONTROL).Permission = tBDirectoryofProtocolFilebyBiasysControl;
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.CT_LANGUAGE).Permission = cbBiasControlLanguage;
            };
            return systemConfigs;
        }
        private Boolean validateForm(ComputerDto dto)
        {
            Boolean ret = true;
            return ret;
        }


        private async void handleSave()
        {
            // get form data
            var computerDto = this.getComputerData();
            var sysDtos = this.getSystemData();

            // validation
            var validated = this.validateForm(computerDto);

            if (validated)
            {
                // check add or update event
                var updateListComputer = new List<ComputerDto>();
                var updateListSystemConf = sysDtos;

                if (computerDto != null)
                {
                    this._computerData.Name = computerDto.Name;
                    this._computerData.MachineNumber = computerDto.MachineNumber;

                    updateListComputer.Add(this._computerData);
                }

                if (updateListComputer.Count > 0)
                {
                    // update
                    await _computerCommandServices.UpdateBulk(updateListComputer);
                }
                if (updateListSystemConf.Count > 0)
                {
                    // update
                    await _systemConfigurationCommandServices.UpdateBulk(updateListSystemConf);
                }
                MessageBox.Show("Data was changed successfully");
                this.refreshData();
            }
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.handleSave();
        }
    }
}
