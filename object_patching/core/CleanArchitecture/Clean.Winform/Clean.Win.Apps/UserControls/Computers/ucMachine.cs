using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using Clean.WinF.Common.Enum;
using Clean.WinF.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clean.Win.AppUI.UserControls
{
    public partial class ucMachine : UserControl
    {

        private readonly IChangeNeedleRecordCommandServices _changeNeedleCommandServices;
        private readonly IClipSensorActivationCommandServices _clipSensorActivationCommandServices;
        private readonly ISewingMachingConfigurationCommandServices _commandServices;
        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;

        List<SewingMachineConfigurationDto> _data = new List<SewingMachineConfigurationDto>();
        List<ChangeNeedleRecordDto> _dataChangeNeedleRecord = new List<ChangeNeedleRecordDto>();
        List<ClipSensorActivationDto> _dataClipSensorActivation = new List<ClipSensorActivationDto>();


        Image addIconImage = Image.FromFile("Icons\\createnew.png");
        Image editIconImage = Image.FromFile("Icons\\change.png");
        Image chooseClipSensorInputImage = Image.FromFile("Icons\\FreeIcons\\Chart_bar.png");
        int _selectedRowIdx = -1;
        bool _refreshGrid = false;
        DateTime fromDate = DateTime.Now;
        DateTime untilDate = DateTime.Now;

        public ucMachine(IChangeNeedleRecordCommandServices changeNeedleCommandServices, IClipSensorActivationCommandServices clipSensorActivationCommandServices,
            ISewingMachingConfigurationCommandServices commandServices)
        {
            _changeNeedleCommandServices = changeNeedleCommandServices;
            _clipSensorActivationCommandServices = clipSensorActivationCommandServices;
            _commandServices = commandServices;
            InitializeComponent();
        }
        private void onFormLoad(object sender, EventArgs e)
        {
            // config grid view columns
            this.configGridViewForSewingMachine();
            this.configGridViewForReplaceNeedleRecord();

            this.configForm();

            this.refreshSewingMachine();
            this.refreshNeedleRecord();
            uiCommon.IsImplementedUIPermision(this, nameof(MenuEnums.Machines));
        }
        private void configForm()
        {

            this.txtMachine.ReadOnly = true;
            this.txtAlterMachine.ReadOnly = true;
            this.txtMachineNeedles.ReadOnly = true;
            this.txtMaxNo.KeyUp += onKeyUp;
            this.cbActivateFoot.Click += onCheckBoxClick;
            this.txtClipSensorActivate.ReadOnly = true;
            this.btnClipSensorActivate.BackgroundImage = this.chooseClipSensorInputImage;
            this.btnClipSensorActivate.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void onCheckBoxClick(object sender, EventArgs e)
        {
            // Prevent changes to the checkbox's checked state
            if (sender is System.Windows.Forms.CheckBox checkBox)
            {
                checkBox.Checked = !checkBox.Checked;
                var dto = this.getCurrentRowData();
                dto.ActivatedFootLiftinCriticalSection = !checkBox.Checked;
                if (dto != null)
                {
                    //string newText = textBox.Text;
                    //MessageBox.Show($"onKeyUp: {newText} - {dto.IsAdd} - row:: {this._selectedRowIdx}");
                    if (!dto.IsAdd)
                    {
                        //MessageBox.Show($"onKeyUp: {newText} - {dto.IsAdd}");
                        dto.IsEdit = true;
                        this._refreshGrid = true;
                    }
                    this.reloadSewingMachineGridView();
                }
            }
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox)
            {
                var dto = this.getCurrentRowData();
                if (dto != null)
                {
                    //string newText = textBox.Text;
                    //MessageBox.Show($"onKeyUp: {newText} - {dto.IsAdd} - row:: {this._selectedRowIdx}");
                    if (!dto.IsAdd)
                    {
                        //MessageBox.Show($"onKeyUp: {newText} - {dto.IsAdd}");
                        dto.IsEdit = true;
                        this._refreshGrid = true;
                    }
                    this.formDataToDto(dto);
                    this.reloadSewingMachineGridView();
                }
            }
        }
        private void formDataToDto(SewingMachineConfigurationDto dto)
        {
            dto.MaxNoStitchesPerNeedles = Convert.ToInt32(this.txtMaxNo.Text);
            dto.ActivatedFootLiftinCriticalSection = this.cbActivateFoot.Checked;
        }

        private void configGridViewForSewingMachine()
        {
            this.sewingMachineGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.sewingMachineGridView.ScrollBars = ScrollBars.Both;
            this.sewingMachineGridView.AutoGenerateColumns = false;
            this.sewingMachineGridView.MultiSelect = false;

            // config gridview display columns
            this.configGridViewIconColumn(this.sewingMachineGridView, "", "StatusIcon");
            this.configGridViewColumn(this.sewingMachineGridView, "Machine", "MachineNumber");
            this.configGridViewColumn(this.sewingMachineGridView, "Alternative Machine", "AlternativeMachine");
            this.configGridViewCheckboxColumn(this.sewingMachineGridView, "Activate Foot Lift in Critical Section", "ActivatedFootLiftinCriticalSection");
            this.configGridViewColumn(this.sewingMachineGridView, "Clip Sensor Activation", "ClipSensorActivationName");
            this.configGridViewIconColumn(this.sewingMachineGridView, "", "Icon");

            foreach (DataGridViewColumn column in this.sewingMachineGridView.Columns)
            {
                column.ReadOnly = true;
            }

            // register gridview event handler
            this.sewingMachineGridView.SelectionChanged += onGridViewSelectionChanged;
            this.sewingMachineGridView.CellEndEdit += onGridViewCellEndEdit;
            this.sewingMachineGridView.CellClick += onCellClick;
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


        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx == 5 && this.sewingMachineGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                //MessageBox.Show($"on click on select winding param {this._selectedRowIdx}");
                this.showInputDataDiaglog(false);
            }
            if (columnIdx == 3)
            {
                var dto = getCurrentRowData();
                dto.ActivatedFootLiftinCriticalSection = !dto.ActivatedFootLiftinCriticalSection;
                if (dto != null)
                {
                    if (!dto.IsAdd)
                    {
                        dto.IsEdit = true;
                        this._refreshGrid = true;
                    }
                    this.reloadSewingMachineGridView();
                    this.sewingMachineGridView.Rows[this._selectedRowIdx].Selected = true;
                    this.onRowChange(sewingMachineGridView.Rows[this._selectedRowIdx]);
                }
            }
            if (columnIdx == 0 && this.sewingMachineGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                var selectedData = this._data[this._selectedRowIdx];
                if (selectedData != null && selectedData.IsEdit)
                {
                    var originalData = this.getById(selectedData.ID);
                    if (originalData != null)
                    {
                        this._data[this._selectedRowIdx] = originalData.Result;
                        this.reloadSewingMachineGridView();
                    }
                }
            }
        }
        private void showInputDataDiaglog(bool isAdd)
        {
            var dto = new SewingMachineConfigurationDto();
            dto.IsAdd = isAdd;

            var steps = this.getInsertSteps();
            if (!dto.IsAdd)
            {
                // update step
                steps = new List<InputDataStep>() { steps[0] };
            }

            InputDataForm inputDataForm = new InputDataForm(steps, dto,
                EInputDataForm.SEWINGMACHINECONFIG, validationAction);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
            if (dto.ClipSenserActivationIdx == 1)
            {
                steps.Add(new InputDataStep
                {
                    PropertyName = "OnAfterMinStitchesminusXStitch",
                    ControllType = EInputDataType.TEXTBOX,
                });
                if (!dto.IsAdd)
                {
                    // update step
                    steps = new List<InputDataStep>() { steps[1] };
                }
                InputDataForm inputDataFormText = new InputDataForm(steps, dto,
                EInputDataForm.SEWINGMACHINECONFIG, validationAction);
                inputDataFormText.OnFormClose += OnClosingDataInputForm;
                inputDataFormText.ShowDialog();
            }
            this.handleDataCallback(dto);
        }
        private void OnClosingDataInputForm(Object inputObject, string status)
        {
            var dto = (SewingMachineConfigurationDto)inputObject;
            switch (status)
            {
                case CommonConstant.InputDataFinished:
                    break;
                default:
                    //close form
                    break;
            }
        }
        private void handleDataCallback(SewingMachineConfigurationDto dto)
        {
            dto.ClipSenserActivation = this._dataClipSensorActivation[dto.ClipSenserActivationIdx];
            if (dto.IsAdd)
            {
                dto.IsActive = true;

                // add to beginning
                //this._data.Insert(0, dto);

                // add to the end
                this._data.Add(dto);

                //int selectedRow = 0;
                int selectedRow = this._data.Count - 1;

                this.reloadSewingMachineGridView();

                this.sewingMachineGridView.Rows[selectedRow].Selected = true;
                this.onRowChange(sewingMachineGridView.Rows[0]);
            }
            else
            {
                var updatedData = this.getCurrentRowData();
                if (updatedData != null)
                {
                    updatedData.ClipSenserActivation = this._dataClipSensorActivation[dto.ClipSenserActivationIdx];
                    if (dto.ClipSenserActivationIdx == 1)
                    {
                        updatedData.OnAfterMinStitchesminusXStitch = Convert.ToInt32(dto.OnAfterMinStitchesminusXStitch);
                    }


                    if (!updatedData.IsAdd)
                    {
                        updatedData.IsEdit = true;
                        this._refreshGrid = true;
                    }
                    this.reloadSewingMachineGridView();
                    this.sewingMachineGridView.Rows[this._selectedRowIdx].Selected = true;
                    this.onRowChange(sewingMachineGridView.Rows[this._selectedRowIdx]);
                }
            }
        }
        private void validationAction()
        {
            MessageBox.Show($"validated");
        }
        private List<InputDataStep> getInsertSteps()
        {
            List<InputDataStep> steps = new List<InputDataStep>();
            steps.Add(new InputDataStep
            {
                PropertyName = "ClipSenserActivateId",
                ControllType = EInputDataType.DATAGRIDVIEW,
                ExtraData = this._dataClipSensorActivation
            });
            return steps;
        }
        private async Task<SewingMachineConfigurationDto> getById(long id)
        {
            return await _commandServices.GetById(id);
        }

        private void configGridViewCheckboxColumn(DataGridView dataGridView, string header, string property)
        {
            var column = new DataGridViewCheckBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;
            dataGridView.Columns.Add(column);
        }
        private void onGridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex;
            //int columnIndex = e.ColumnIndex;
            //var dto = this._data[rowIndex];
            //dto.IsEdit = true;
            var dto = this.getCurrentRowData();
            if (dto != null && !dto.IsAdd)
            {
                dto.IsEdit = true;
                this._refreshGrid = true;
            }
        }

        private void onGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (this._refreshGrid)
            {
                this._refreshGrid = false;
                this.reloadSewingMachineGridView();
            }

            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
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
                this.updateFormData(this.getCurrentRowData());
            }
        }


        private void updateFormData(SewingMachineConfigurationDto model)
        {
            if (model != null)
            {
                this.txtMachineNeedles.Text = model.MachineNumber.ToString();
                this.txtMachine.Text = model.MachineNumber.ToString();
                this.txtAlterMachine.Text = model.AlternativeMachine.ToString();
                this.txtMaxNo.Text = model.MaxNoStitchesPerNeedles.ToString();
                this.cbActivateFoot.Checked = model.ActivatedFootLiftinCriticalSection;
                string inputString = model.ClipSensorActivationName.ToString();
                string replacement = model.OnAfterMinStitchesminusXStitch.ToString();
                string resultString = inputString.Replace("X", replacement);
                this.txtClipSensorActivate.Text = resultString;
            }
        }

        private SewingMachineConfigurationDto getCurrentRowData()
        {
            SewingMachineConfigurationDto ret = null;
            if (_selectedRowIdx != -1)
            {
                ret = this._data[_selectedRowIdx];
            }
            return ret;
        }

        private async void refreshSewingMachine()
        {
            var result = await _commandServices.ListAllAsync();
            var dbData = (List<SewingMachineConfigurationDto>)result;

            var clipSensorInput = await _clipSensorActivationCommandServices.ListAllAsync();
            this._dataClipSensorActivation = clipSensorInput;

            if (_dataClipSensorActivation.Count == 0)
            {
                this.InitClipSensorDataAsync();
            }

            this._data = dbData;

            if (dbData.Count == 0)
            {
                this.InitDataAsync();
            }
            this.reloadSewingMachineGridView();
        }

        private async void refreshNeedleRecord()
        {
            var result = await _changeNeedleCommandServices.ListAllAsync();
            var dbData = (List<ChangeNeedleRecordDto>)result;

            this._dataChangeNeedleRecord = dbData;

            if (_dataChangeNeedleRecord.Count == 0)
            {
                this.InitChangeNeedleRecordDataAsync();
            }

            this.reloadChangeNeedleGridView();
        }

        private async Task InitChangeNeedleRecordDataAsync()
        {
            var rs = await _changeNeedleCommandServices.CreateBulk(new List<ChangeNeedleRecordDto>()
            {
                new ChangeNeedleRecordDto(){StitchCount=100, UserID=1111, MachineNumber=1,CreatedOn=DateTime.Now.AddDays(-1), UpdatedOn = DateTime.Now, IsActive = true},
                new ChangeNeedleRecordDto(){StitchCount=150, UserID=1111, MachineNumber=1,CreatedOn=DateTime.Now.AddDays(-3), UpdatedOn = DateTime.Now, IsActive = true},
                new ChangeNeedleRecordDto(){StitchCount=200, UserID=1111, MachineNumber=1,CreatedOn=DateTime.Now.AddDays(-5), UpdatedOn = DateTime.Now, IsActive = true},
                new ChangeNeedleRecordDto(){StitchCount=250, UserID=1111, MachineNumber=1,CreatedOn=DateTime.Now.AddDays(-7), UpdatedOn = DateTime.Now, IsActive = true},
                new ChangeNeedleRecordDto(){StitchCount=300, UserID=1111, MachineNumber=1,CreatedOn=DateTime.Now.AddDays(-8), UpdatedOn = DateTime.Now, IsActive = true},
                new ChangeNeedleRecordDto(){StitchCount=350, UserID=1111, MachineNumber=1,CreatedOn=DateTime.Now.AddDays(-9), UpdatedOn = DateTime.Now, IsActive = true},
            });
            if (rs)
            {
                this._dataChangeNeedleRecord = await _changeNeedleCommandServices.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        private async Task InitClipSensorDataAsync()
        {
            var rs = await _clipSensorActivationCommandServices.CreateBulk(new List<ClipSensorActivationDto>()
            {
                new ClipSensorActivationDto(){Name="Alway ON", CreatedOn=DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                new ClipSensorActivationDto(){Name="ON After Min.Stitches minus [X] Stitches", CreatedOn=DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
            });
            if (rs)
            {
                this._dataClipSensorActivation = await _clipSensorActivationCommandServices.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        private async Task InitDataAsync()
        {
            var rs = await _commandServices.CreateBulk(new List<SewingMachineConfigurationDto>()
            {
                new SewingMachineConfigurationDto(){MachineNumber = 1, AlternativeMachine = 2, ClipSensorActivationName=this._dataClipSensorActivation[0].Name, MaxNoStitchesPerNeedles = 20000, ActivatedFootLiftinCriticalSection=true, OnAfterMinStitchesminusXStitch=5,  CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
            });
            if (rs)
            {
                this._data = await _commandServices.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        private void reloadSewingMachineGridView()
        {
            this.updateSewingMachineDataSource();

            // config datasource
            this.sewingMachineGridView.DataSource = null;
            this.sewingMachineGridView.DataSource = this._data;
            this.sewingMachineGridView.Refresh();
        }

        private void reloadChangeNeedleGridView()
        {
            // config datasource
            this.ClipSensorGridView.DataSource = null;
            this.ClipSensorGridView.DataSource = this._dataChangeNeedleRecord;
            this.ClipSensorGridView.Refresh();
        }

        private void updateSewingMachineDataSource()
        {
            var defaultIcon = new Bitmap(1, 1);
            foreach (SewingMachineConfigurationDto dto in this._data)
            {
                dto.updateClipSensorInput();
                dto.Icon = this.chooseClipSensorInputImage;
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

        private void configGridViewForReplaceNeedleRecord()
        {
            this.ClipSensorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ClipSensorGridView.ScrollBars = ScrollBars.Both;
            this.ClipSensorGridView.AutoGenerateColumns = false;
            this.ClipSensorGridView.MultiSelect = false;

            // config gridview display columns
            this.configGridViewColumn(this.ClipSensorGridView, "Date", "CreatedOn");
            this.configGridViewColumn(this.ClipSensorGridView, "Stitch Count", "StitchCount");
            this.configGridViewColumn(this.ClipSensorGridView, "User ID", "UserID");

            foreach (DataGridViewColumn column in this.ClipSensorGridView.Columns)
            {
                column.ReadOnly = true;
            }
            this.dateTimePickerFrom.ValueChanged += DateTimePickerFrom_ValueChanged;
            this.dateTimePickerUntil.ValueChanged += DateTimePickerUntil_ValueChanged;
        }

        private void configGridViewColumn(DataGridView dataGridView, String header, String property)
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;
            dataGridView.Columns.Add(column);
        }

        private void DateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxFrom.Checked && !checkBoxUntil.Checked)
            {
                fromDate = dateTimePickerFrom.Value;
                this.UpdateClipSensorGridViewBasedOnDates(fromDate, untilDate);
            }
            else if (!checkBoxFrom.Checked && checkBoxUntil.Checked)
            {
                untilDate = dateTimePickerUntil.Value;
                this.UpdateClipSensorGridViewBasedOnDates(fromDate, untilDate);
            }
            else if (checkBoxFrom.Checked && checkBoxUntil.Checked)
            {
                fromDate = dateTimePickerFrom.Value;
                untilDate = dateTimePickerUntil.Value;
                this.UpdateClipSensorGridViewBasedOnDates(fromDate, untilDate);
            }
            this.reloadChangeNeedleGridView();
        }

        private void checkBoxFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFrom.Checked)
            {
                fromDate = dateTimePickerFrom.Value;
                this.UpdateClipSensorGridViewBasedOnDates(fromDate, untilDate);
            }
        }

        private void DateTimePickerUntil_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxUntil.Checked && checkBoxFrom.Checked)
            {
                fromDate = dateTimePickerFrom.Value;
                untilDate = dateTimePickerUntil.Value;
                this.UpdateClipSensorGridViewBasedOnDates(fromDate, untilDate);
            }
            else if (checkBoxUntil.Checked && !checkBoxFrom.Checked)
            {
                untilDate = dateTimePickerUntil.Value;
                this.UpdateClipSensorGridViewBasedOnDates(fromDate, untilDate);
            }
            else if (!checkBoxUntil.Checked && checkBoxFrom.Checked)
            {
                fromDate = dateTimePickerFrom.Value;
                this.UpdateClipSensorGridViewBasedOnDates(fromDate, untilDate);
            }
            this.reloadChangeNeedleGridView();
        }

        private void checkBoxUntil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUntil.Checked)
            {
                untilDate = dateTimePickerUntil.Value;
                this.UpdateClipSensorGridViewBasedOnDates(fromDate, untilDate);
            }
        }

        private async void UpdateClipSensorGridViewBasedOnDates(DateTime fromDate, DateTime untilDate)
        {

            var dto = getCurrentRowData();
            var result = await _changeNeedleCommandServices.GetByTimeRange(1111, dto.MachineNumber, fromDate, untilDate);
            var dbData = (List<ChangeNeedleRecordDto>)result;
            this._dataChangeNeedleRecord = dbData;
            this.reloadChangeNeedleGridView();
        }

        private async void handleSave()
        {
            // get form data
            var dto = this.getFormData();
            // validation
            var validated = this.validateForm(dto);
            if (validated)
            {
                // check add or update event
                var currentRowData = this.getCurrentRowData();
                currentRowData.ClipSensorActivationName = dto.ClipSensorActivationName;

                var insertList = new List<SewingMachineConfigurationDto>();
                var updateList = new List<SewingMachineConfigurationDto>();
                foreach (SewingMachineConfigurationDto item in this._data)
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
                this.refreshSewingMachine();
            }
        }
        private Boolean validateForm(SewingMachineConfigurationDto dto)
        {
            Boolean ret = true;
            return ret;
        }
        private SewingMachineConfigurationDto getFormData()
        {
            SewingMachineConfigurationDto ret = new SewingMachineConfigurationDto();
            int MachineNumber = Convert.ToInt32(this.txtMachine.Text);
            int AlternativeMachine = Convert.ToInt32(this.txtAlterMachine.Text);
            int MaxNoStitchesPerNeedles = Convert.ToInt32(this.txtMaxNo.Text);
            bool ActivateFootLiftinCriticalSection = this.cbActivateFoot.Checked;
            string ClipSensorActivationName = this.txtClipSensorActivate.Text;

            ret.MachineNumber = MachineNumber;
            ret.AlternativeMachine = AlternativeMachine;
            ret.MaxNoStitchesPerNeedles = MaxNoStitchesPerNeedles;
            ret.ActivatedFootLiftinCriticalSection = ActivateFootLiftinCriticalSection;
            ret.ClipSensorActivationName = ClipSensorActivationName;

            return ret;
        }
        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            this.refreshSewingMachine();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.handleSave();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available now");
        }

        private void btnClipSensorActivate_Click(object sender, EventArgs e)
        {
            this.showInputDataDiaglog(false);
        }
    }
}
