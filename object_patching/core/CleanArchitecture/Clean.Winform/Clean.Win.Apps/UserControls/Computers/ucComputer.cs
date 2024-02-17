using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Computer.DTOs;
using Clean.WinF.Applications.Features.Computer.Interfaces;
using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Language.Interfaces;
using Clean.WinF.Applications.Features.SystemConfiguration.Constants;
using Clean.WinF.Applications.Features.SystemConfiguration.DTOs;
using Clean.WinF.Applications.Features.SystemConfiguration.Interfaces;
using Clean.WinF.Common.Enum;
using Clean.WinF.Shared.Constants;
using Clean.WinF.Shared.ErrorMessage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucComputer : UserControl
    {
        private readonly IComputerQueryServices _queryServices;
        private readonly IComputerCommandServices _commandServices;
        private readonly ILanguageQueryServices _languageQueryServices;
        private readonly ISystemConfigurationCommandServices _systemConfigurationCommandServices;

        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;
        List<ComputerDto> _data = new List<ComputerDto>();
        List<LanguageDto> _languageData = new List<LanguageDto>();
        Image addIconImage = Image.FromFile("Icons\\createnew.png");
        Image editIconImage = Image.FromFile("Icons\\change.png");
        int _selectedRowIdx = -1;
        bool _refreshGrid = false;

        public ucComputer(IComputerCommandServices commandServices, IComputerQueryServices queryServices, ILanguageQueryServices languageQueryService, ISystemConfigurationCommandServices systemConfigurationCommandServices)
        {
            _commandServices = commandServices;
            _queryServices = queryServices;
            _languageQueryServices = languageQueryService;
            _systemConfigurationCommandServices = systemConfigurationCommandServices;
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            // config grid view columns
            this.configGridView();

            this.configForm();

            this.refreshData();
            uiCommon.IsImplementedUIPermision(this, nameof(MenuEnums.ComputerConfigurations));
        }
        private void configForm()
        {
            this.txtInterfaceBarcodePrinter.ReadOnly = true;
            this.txtArchiveAllProtocolAfterXdays.ReadOnly = true;
            this.txtDirectoryOfProtocolDatabases.ReadOnly = true;
            this.txtDirectoryinProtocolFiles.ReadOnly = true;
            this.txtLanguageBiasysControl.ReadOnly = true;
            this.txtLanguageBiasysDB.ReadOnly = true;
            // Thay đổi nút btnLanguageBiasysControl
            //this.btnLanguageBiasysControl.BackgroundImage = this.laguageIconImage; // Đặt hình ảnh cho nút

            // Thay đổi nút btnLanguageBiasysDB
            //this.btnLanguageBiasysDB.BackgroundImage = this.laguageIconImage; // Đặt hình ảnh cho nút
        }

        private void configGridView()
        {
            this.mainGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.ScrollBars = ScrollBars.Both;
            this.mainGridView.AutoGenerateColumns = false;
            this.mainGridView.MultiSelect = false;

            // config gridview display columns
            this.configGridViewIconColumn(this.mainGridView, "", "StatusIcon");
            this.configGridViewColumn(this.mainGridView, "Name", "Name");
            this.configGridViewColumn(this.mainGridView, "MachineNumber", "MachineNumber");


            // register gridview event handler
            this.mainGridView.SelectionChanged += onGridViewSelectionChanged;
            this.mainGridView.CellClick += onCellClick;
        }
        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx == 0 && this.mainGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                //MessageBox.Show($"on click on reset {this._selectedRowIdx}");
                var selectedData = this._data[this._selectedRowIdx];
                if (selectedData != null && selectedData.IsEdit)
                {
                    var originalData = this.getById(selectedData.ID);
                    if (originalData != null)
                    {
                        this._data[this._selectedRowIdx] = originalData.Result;
                        this.reloadGridView();
                    }
                }
            }
        }
        private async Task<ComputerDto> getById(long id)
        {

            return await _commandServices.GetById(id);
        }
        private void configGridViewIconColumn(DataGridView dataGridView,
            String header, String property, int width = 50)
        {
            var column = new DataGridViewImageColumn
            {
                HeaderText = header,
                DataPropertyName = property,
                ImageLayout = DataGridViewImageCellLayout.Normal,
                Width = width,
            };
            dataGridView.Columns.Add(column);
        }

        private void configGridViewColumn(DataGridView dataGridView,
            String header, String property)
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;
            dataGridView.Columns.Add(column);
        }


        private async void refreshData()
        {
            var result = await _commandServices.ListAllAsync();
            var dbData = (List<ComputerDto>)result;

            var laguage = await _languageQueryServices.GetAlls();
            this._languageData = laguage;

            this._data = dbData;
            if (this._data != null)
            {
                foreach (ComputerDto dto in this._data)
                {
                    dto.systemConfigs = await this._systemConfigurationCommandServices.ListAllAsync();
                    dto.LanguageForBiasysControlName = dto.FindSystemConfigurationValue(SystemConfigurationConstant.CT_LANGUAGE).Permission;
                    dto.LanguageForBiasysDBName = dto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_LANGUAGE).Permission;
                }
            }
            //if (dbData.Count == 0)
            //{
            //    this.InitDataAsync();
            //}
            this.reloadGridView();
        }

        private void reloadGridView()
        {
            this.updateDataSource();

            // config datasource
            this.mainGridView.DataSource = null;
            this.mainGridView.DataSource = this._data;
            this.mainGridView.Refresh();
        }

        private void updateDataSource()
        {
            var defaultIcon = new Bitmap(1, 1);
            foreach (ComputerDto dto in this._data)
            {
                dto.UpdateLanguageForBiasysControl();
                dto.UpdateLanguageForBiasysDB();
                dto.StatusIcon = defaultIcon;

                if (dto.IsAdd)
                {
                    dto.StatusIcon = this.addIconImage;
                }
                if (dto.IsEdit)
                {
                    dto.StatusIcon = this.editIconImage;
                }
            }
        }

        private void updateFormData(ComputerDto model)
        {
            if (model.systemConfigs != null)
            {
                this.txtInterfaceBarcodePrinter.Text = model.FindSystemConfigurationValue(SystemConfigurationConstant.DB_INTERFACE_BARCODE_PRINTER).Permission;
                this.txtArchiveAllProtocolAfterXdays.Text = model.FindSystemConfigurationValue(SystemConfigurationConstant.DB_ARCHIEVE_ALL_PROTOCOL_AFTER_DAYS).Permission;
                this.txtDirectoryOfProtocolDatabases.Text = model.FindSystemConfigurationValue(SystemConfigurationConstant.DB_DIRECTORY_ARCHIVED_PROTOCOL).Permission;
                this.txtDirectoryinProtocolFiles.Text = model.FindSystemConfigurationValue(SystemConfigurationConstant.DB_DIRECTORY_OF_PROTOCOL_FILES_WRITTEN_BY_BIASYSCONTROL).Permission;
                this.txtLanguageBiasysControl.Text = model.LanguageForBiasysControlName;
                this.txtLanguageBiasysDB.Text = model.LanguageForBiasysDBName;
            }
        }

        private ComputerDto getCurrentRowData()
        {
            ComputerDto ret = null;
            if (_selectedRowIdx != -1)
            {
                ret = this._data[_selectedRowIdx];
            }
            return ret;
        }

        // used when click button save
        private List<SystemConfigurationDtos> getFormData()
        {
            var currentComputerDto = getCurrentRowData();
            String interfaceBarcodePrinter = this.txtInterfaceBarcodePrinter.Text;
            String archiveAllProtocolAfterXdays = this.txtArchiveAllProtocolAfterXdays.Text;
            String locationOfArchievedProtocolDatabases = this.txtDirectoryOfProtocolDatabases.Text;
            String directoryinProtocolFiles = this.txtDirectoryinProtocolFiles.Text;
            String languageBiasysControl = this.txtLanguageBiasysControl.Text;
            String languageBiasysDB = this.txtLanguageBiasysDB.Text;

            List<SystemConfigurationDtos> systemConfigs = currentComputerDto.systemConfigs;
            {
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_INTERFACE_BARCODE_PRINTER).Permission = interfaceBarcodePrinter;
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_ARCHIEVE_ALL_PROTOCOL_AFTER_DAYS).Permission = archiveAllProtocolAfterXdays;
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_DIRECTORY_ARCHIVED_PROTOCOL).Permission = locationOfArchievedProtocolDatabases;
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_DIRECTORY_OF_PROTOCOL_FILES_WRITTEN_BY_BIASYSCONTROL).Permission = directoryinProtocolFiles;
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.CT_LANGUAGE).Permission = languageBiasysControl;
                currentComputerDto.FindSystemConfigurationValue(SystemConfigurationConstant.DB_LANGUAGE).Permission = languageBiasysDB;
            };
            return systemConfigs;
        }

        private void onGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (this._refreshGrid)
            {
                this._refreshGrid = false;
                this.reloadGridView();
            }

            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
                    //MessageBox.Show($"onGridViewSelectionChanged: {selectedRow.Index} - {selectedRow.Selected} - grid count:: {this.mainGridView.Rows.Count}");
                    this._selectedRowIdx = selectedRow.Index;
                    //this.cacheSelectedData();
                    this.onRowChange(selectedRow);
                }
            }
        }

        private void onRowChange(DataGridViewRow selectedRow)
        {
            if (selectedRow != null && selectedRow.Selected)
            {
                this._selectedRowIdx = selectedRow.Index;
                //MessageBox.Show($"onRowChange: selectedRow = {this._selectedRowIdx}");
                this.updateFormData(this.getCurrentRowData());
            }
        }

        private Boolean validateForm(ComputerDto dto)
        {
            Boolean ret = true;
            return ret;
        }

        private async void handleSave()
        {
            // get form data
            var sysDtos = this.getFormData();
            // validation
            var dto = new ComputerDto();
            var validated = this.validateForm(dto);

            if (validated)
            {
                // check add or update event
                var currentRowData = this.getCurrentRowData();
                var insertList = new List<ComputerDto>();
                var updateList = new List<ComputerDto>();
                foreach (ComputerDto item in this._data)
                {
                    if (item.IsAdd)
                    {
                        insertList.Add(item);
                    }
                    if (item.IsEdit)
                    {
                        updateList.Add(item);
                    }
                }

                if (insertList.Count > 0)
                {
                    // insert
                    await _commandServices.CreateBulk(insertList);
                }
                if (updateList.Count > 0)
                {
                    // update
                    await _commandServices.UpdateBulk(updateList);
                }
                if (sysDtos.Count > 0)
                {
                    // update
                    await _systemConfigurationCommandServices.UpdateBulk(sysDtos);
                }
                UIUtility.AppShowMsg(CustomErrorMessage.APP_USER_UPDATED_SUCCESS);
                this.refreshData();
            }
        }

        private void handleInsertCallback(ComputerDto dto)
        {
            int selectedRow = 0;

            // add to beginning
            this._data.Insert(0, dto);

            // add to the end
            //this._data.Add(dto);
            //selectedRow = this._data.Count - 1;

            this.reloadGridView();

            this.mainGridView.Rows[selectedRow].Selected = true;
            this.onRowChange(mainGridView.SelectedRows[0]);
        }

        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.handleSave();
        }


        private void validationAction()
        {
            Console.WriteLine("validated");
        }


        // debug code begin

        private void showInputDataDiaglogBiasysControl(bool isAdd)
        {
            //prepair data
            var dto = new ComputerDto();
            dto.IsAdd = isAdd;

            var steps = this.getInsertSteps();
            if (!dto.IsAdd)
            {
                steps = new List<InputDataStep>() { steps[0] };
            }

            InputDataForm inputDataForm = new InputDataForm(steps, dto,
                EInputDataForm.LANGUAGES, validationAction);
            inputDataForm.OnFormClose += OnClosingDataInputFormBiasysControl;
            inputDataForm.ShowDialog();
        }
        private void showInputDataDiaglogBiasysDB(bool isAdd)
        {
            //prepair data
            var dto = new ComputerDto();
            dto.IsAdd = isAdd;

            var steps = this.getInsertSteps();
            if (!dto.IsAdd)
            {
                // update step
                steps = new List<InputDataStep>() { steps[0] };
            }

            InputDataForm inputDataForm = new InputDataForm(steps, dto,
                EInputDataForm.LANGUAGES, validationAction);
            inputDataForm.OnFormClose += OnClosingDataInputFormBiasysDB;
            inputDataForm.ShowDialog();
        }
        private List<InputDataStep> getInsertSteps()
        {
            List<InputDataStep> steps = new List<InputDataStep>();
            steps.Add(new InputDataStep
            {
                PropertyName = "Lang",
                ControllType = EInputDataType.DATAGRIDVIEW,
                ExtraData = this._languageData
            });
            return steps;
        }

        private void OnClosingDataInputFormBiasysControl(Object inputObject, string status)
        {
            var dto = (ComputerDto)inputObject;
            switch (status)
            {
                case CommonConstant.InputDataFinished:
                    this.handleDataCallbackBiasysControl(dto);
                    break;
                default:
                    //close form
                    break;
            }
        }
        private void OnClosingDataInputFormBiasysDB(Object inputObject, string status)
        {
            var dto = (ComputerDto)inputObject;
            switch (status)
            {
                case CommonConstant.InputDataFinished:
                    this.handleDataCallbackBiasysDB(dto);
                    break;
                default:
                    //close form
                    break;
            }
        }
        private void handleDataCallbackBiasysDB(ComputerDto dto)
        {
            dto.LanguageForBiasysDB = this._languageData[dto.LanguagueForBiasysDBId];
            if (dto.IsAdd)
            {
                dto.IsActive = true;

                // add to beginning
                //this._data.Insert(0, dto);

                // add to the end
                this._data.Add(dto);

                //int selectedRow = 0;
                int selectedRow = this._data.Count - 1;

                this.reloadGridView();

                this.mainGridView.Rows[selectedRow].Selected = true;
                this.onRowChange(mainGridView.Rows[0]);
            }
            else
            {
                var updatedData = this.getCurrentRowData();
                if (updatedData != null)
                {
                    updatedData.LanguageForBiasysDB = this._languageData[dto.LanguagueForBiasysDBId];

                    if (!updatedData.IsAdd)
                    {
                        updatedData.IsEdit = true;
                        this._refreshGrid = true;
                    }
                    this.reloadGridView();

                    this.mainGridView.Rows[this._selectedRowIdx].Selected = true;
                    this.onRowChange(mainGridView.Rows[this._selectedRowIdx]);
                }
            }
        }
        private void handleDataCallbackBiasysControl(ComputerDto dto)
        {
            dto.LanguageForBiasysControl = this._languageData[dto.LanguagueForBiasysControlId];
            if (dto.IsAdd)
            {
                dto.IsActive = true;

                // add to beginning
                //this._data.Insert(0, dto);

                // add to the end
                this._data.Add(dto);

                //int selectedRow = 0;
                int selectedRow = this._data.Count - 1;

                this.reloadGridView();

                this.mainGridView.Rows[selectedRow].Selected = true;
                this.onRowChange(mainGridView.Rows[0]);
            }
            else
            {
                var updatedData = this.getCurrentRowData();
                if (updatedData != null)
                {
                    updatedData.LanguageForBiasysControl = this._languageData[dto.LanguagueForBiasysControlId];

                    if (!updatedData.IsAdd)
                    {
                        updatedData.IsEdit = true;
                        this._refreshGrid = true;
                    }
                    this.reloadGridView();

                    this.mainGridView.Rows[this._selectedRowIdx].Selected = true;
                    this.onRowChange(mainGridView.Rows[this._selectedRowIdx]);
                }
            }
        }

        private void btnLanguageBiasysControl_Click(object sender, EventArgs e)
        {
            this.showInputDataDiaglogBiasysControl(false);
        }

        private void btnLanguageBiasysDB_Click(object sender, EventArgs e)
        {
            this.showInputDataDiaglogBiasysDB(false);
        }

        // debug code end
    }
}
