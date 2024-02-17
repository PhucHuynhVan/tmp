using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clean.Win.AppConfigUI.UserControls.Computers
{
    public partial class
        ucMachineConfig : UserControl
    {
        private readonly ISewingMachingConfigurationCommandServices _sewingMachineConfigurationCommandServices;
        private readonly IClipSensorActivationCommandServices _clipSensorActivationCommandServices;
        private readonly IPortCommandServices _portCommandServices;
        private readonly IDeviceTypeCommandServices _deviceTypeCommandServices;
        private readonly IDeviceRoutingCommandServices _deviceRoutingeCommandServices;
        private readonly IConnectedDeviceCommandServices _connectedDeviceCommandServices;

        List<SewingMachineConfigurationDto> _data = new List<SewingMachineConfigurationDto>();
        List<ClipSensorActivationDto> _dataClipSensorActivation = new List<ClipSensorActivationDto>();
        List<PortDto> _portData = new List<PortDto>();
        List<DeviceRoutingDto> _deviceRoutingData = new List<DeviceRoutingDto>();
        List<DeviceTypeDto> _deviceTypeData = new List<DeviceTypeDto>();
        List<ConnectedDeviceDto> _connectedDeviceData = new List<ConnectedDeviceDto>();

        int _sewingRowIdx = 0;
        int _connectedDeviceRowIdx = -1;


        public ucMachineConfig(
            ISewingMachingConfigurationCommandServices sewingMachineConfigurationCommandServices,
            IClipSensorActivationCommandServices clipSensorActivationCommandServices,
            List<SewingMachineConfigurationDto> dtos,
            IPortCommandServices portCommandServices,
            IDeviceTypeCommandServices deviceTypeCommandServices,
            IDeviceRoutingCommandServices deviceRoutingeCommandServices,
            IConnectedDeviceCommandServices connectedDeviceCommandServices)
        {
            _sewingMachineConfigurationCommandServices = sewingMachineConfigurationCommandServices;
            _clipSensorActivationCommandServices = clipSensorActivationCommandServices;
            _data = dtos;
            InitializeComponent();
            _portCommandServices = portCommandServices;
            _deviceTypeCommandServices = deviceTypeCommandServices;
            _deviceRoutingeCommandServices = deviceRoutingeCommandServices;
            _connectedDeviceCommandServices = connectedDeviceCommandServices;
        }

        private async void onFormLoad(object sender, EventArgs e)
        {
            // Clip sensor Input
            var clipSensorInput = await _clipSensorActivationCommandServices.ListAllAsync();
            this._dataClipSensorActivation = clipSensorInput;
            // Clip sensor Port
            var port = await _portCommandServices.ListAllAsync();
            this._portData = port;
            // Clip DeviceType Port
            var deviceType = await _deviceTypeCommandServices.ListAllAsync();
            this._deviceTypeData = deviceType;
            // Clip DeviceRouting Port
            var deviceRouting = await _deviceRoutingeCommandServices.ListAllAsync();
            this._deviceRoutingData = deviceRouting;

            this.configSewingMachineParameterGridView();
            this.configForm();
            this.configConnectedDeviceGridView();
            this.refreshData();

        }
        private List<ConnectedDeviceDto> UpdateConnectedDeviceDetails(List<ConnectedDeviceDto> connectedDevices)
        {
            foreach (ConnectedDeviceDto dto in connectedDevices)
            {
                if (dto != null)
                {
                    // Cập nhật thông tin DeviceRoutingName
                    if (dto.DeviceRoutingID > 0)
                    {
                        dto.DeviceRouting = _deviceRoutingData.FirstOrDefault(d => d.ID == dto.DeviceRoutingID);
                        dto.DeviceRoutingName = dto.DeviceRouting.Name;
                    }
                    // Cập nhật thông tin DeviceTypeName
                    if (dto.DeviceTypeID > 0)
                    {
                        dto.DeviceType = _deviceTypeData.FirstOrDefault(d => d.ID == dto.DeviceTypeID);
                        dto.DeviceTypeName = dto.DeviceType.Name;
                    }
                    // Cập nhật thông tin PortName
                    if (dto.PortID > 0)
                    {
                        dto.Port = _portData.FirstOrDefault(p => p.ID == dto.PortID);
                        dto.PortName = dto.Port.Name;
                    }
                }
            }
            return connectedDevices;
        }

        private List<ConnectedDeviceDto> UpdateConnectedDeviceIDs(List<ConnectedDeviceDto> connectedDevices)
        {
            foreach (ConnectedDeviceDto dto in connectedDevices)
            {
                if (dto != null)
                {
                    // Ánh xạ ngược lại từ DeviceRoutingName
                    if (!string.IsNullOrEmpty(dto.DeviceRoutingName))
                    {
                        var deviceRouting = _deviceRoutingData.FirstOrDefault(d => d.Name == dto.DeviceRoutingName);
                        if (deviceRouting != null)
                        {
                            dto.DeviceRoutingID = (int)deviceRouting.ID;
                        }
                    }

                    // Ánh xạ ngược lại từ DeviceTypeName
                    if (!string.IsNullOrEmpty(dto.DeviceTypeName))
                    {
                        var deviceType = _deviceTypeData.FirstOrDefault(d => d.Name == dto.DeviceTypeName);
                        if (deviceType != null)
                        {
                            dto.DeviceTypeID = (int)deviceType.ID;
                        }
                    }

                    // Ánh xạ ngược lại từ PortName
                    if (!string.IsNullOrEmpty(dto.PortName))
                    {
                        var port = _portData.FirstOrDefault(p => p.Name == dto.PortName);
                        if (port != null)
                        {
                            dto.PortID = (int)port.ID;
                        }
                    }
                }
            }
            return connectedDevices;
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox)
            {
                var dto = this.getCurrentSewingMachineRowData();
                if (dto != null)
                {
                    if (!dto.IsAdd)
                    {
                        dto.IsEdit = true;
                    }
                    this.formDataToDto(dto);
                }
            }
        }
        private void onCheckBoxClick(object sender, EventArgs e)
        {
            // Prevent changes to the checkbox's checked state
            var dto = this.getCurrentSewingMachineRowData();
            if (dto != null)
            {
                if (!dto.IsAdd)
                {
                    dto.IsEdit = true;
                }
                this.formDataToDto(dto);
            }
        }
        private void configForm()
        {
            this.txtMachineNumber.ReadOnly = true;
            this.txtAlterMachineNumber.ReadOnly = true;
            this.cbACtive.Click += onCheckBoxClick;
            this.txtSerialNumber.KeyUp += onKeyUp;
        }

        private void formDataToDto(SewingMachineConfigurationDto dto)
        {
            if (!string.IsNullOrEmpty(this.txtAlterMachineNumber.Text))
            {
                dto.AlternativeMachine = Convert.ToInt16(this.txtAlterMachineNumber.Text);
            }
            if (!string.IsNullOrEmpty(this.txtMachineNumber.Text))
            {
                dto.MachineNumber = Convert.ToInt16(this.txtMachineNumber.Text);
            }
            dto.IsActive = this.cbACtive.Checked;
            dto.SerialNumber = this.txtSerialNumber.Text;
        }
        private void ComboBox_SewingSelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedValue = ((ComboBox)sender).SelectedItem;
            var dto = this.getCurrentSewingMachineRowData();
            if (dto != null && !dto.IsAdd)
            {
                dto.IsEdit = true;
                dto.ClipSensorActivationName = selectedValue.ToString();
            }

        }
        private void configGridViewClipSensorComboboxColumn(DataGridView dataGridView, string header, string property)
        {
            var column = new DataGridViewComboBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;
            foreach (var dto in this._dataClipSensorActivation)
            {
                column.Items.Add(dto.Name);
            }
            dataGridView.Columns.Add(column);
            dataGridView.EditingControlShowing += (sender, e) =>
            {
                if (e.Control is ComboBox comboBox)
                {
                    comboBox.SelectedIndexChanged -= ComboBox_SewingSelectedIndexChanged;
                    comboBox.SelectedIndexChanged += ComboBox_SewingSelectedIndexChanged;
                }
            };
        }
        private void configGridViewCheckboxColumn(DataGridView dataGridView, string header, string property)
        {
            var column = new DataGridViewCheckBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;
            dataGridView.Columns.Add(column);
        }
        private void configGridViewColumn(DataGridView dataGridView, String header, String property)
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;
            dataGridView.Columns.Add(column);
        }
        private void onSewingSelectionChanged(object sender, EventArgs e)
        {
            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
                    this._sewingRowIdx = selectedRow.Index;
                    //this.cacheSelectedData();
                    //this.onRowChange(selectedRow);
                }
            }
        }
        private void onSewingCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dto = this.getCurrentSewingMachineRowData();
            if (dto != null && !dto.IsAdd)
            {
                dto.IsEdit = true;
            }
        }
        private void onSewingCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx == 2)
            {
                var dto = this.getCurrentSewingMachineRowData();
                if (dto != null && !dto.IsAdd)
                {
                    dto.IsEdit = true;
                    dto.ActivatedFootLiftinCriticalSection = !dto.ActivatedFootLiftinCriticalSection;
                }
            }
        }

        private void configSewingMachineParameterGridView()
        {
            this.dgSewingParameter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgSewingParameter.ScrollBars = ScrollBars.Both;
            this.dgSewingParameter.AutoGenerateColumns = false;
            this.dgSewingParameter.MultiSelect = false;

            // config gridview display columns
            this.configGridViewColumn(this.dgSewingParameter, "Stitches already sewn", "StitchesAlreadySewn");
            this.configGridViewColumn(this.dgSewingParameter, "Max. Stitches Per Needle", "MaxNoStitchesPerNeedles");
            this.configGridViewCheckboxColumn(this.dgSewingParameter, "Activate Foot Lift in Critical Section", "ActivatedFootLiftinCriticalSection");
            this.configGridViewClipSensorComboboxColumn(this.dgSewingParameter, "Clip Sensor Activation", "ClipSensorActivationName");
            this.configGridViewColumn(this.dgSewingParameter, "CSA Stitches", "CSAStitches");
            this.configGridViewColumn(this.dgSewingParameter, "ETM last adjusted (in days)", "ETMLastAdjusted");

            this.dgSewingParameter.SelectionChanged += onSewingSelectionChanged;
            this.dgSewingParameter.CellEndEdit += onSewingCellEndEdit;
            this.dgSewingParameter.CellClick += onSewingCellClick;
        }
        private SewingMachineConfigurationDto getCurrentSewingMachineRowData()
        {
            SewingMachineConfigurationDto ret = null;
            if (_sewingRowIdx != -1)
            {
                ret = this._data[_sewingRowIdx];
            }
            return ret;
        }
        private ConnectedDeviceDto getCurrentConnectedDeviceRowData()
        {
            ConnectedDeviceDto ret = null;
            if (this._connectedDeviceRowIdx != -1)
            {
                ret = this._connectedDeviceData[_connectedDeviceRowIdx];
            }
            return ret;
        }
        private void onConnectedDeviceGridViewSelectionChanged(object sender, EventArgs e)
        {
            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];
                if (selectedRow != null && selectedRow.Selected)
                {
                    this._connectedDeviceRowIdx = selectedRow.Index;
                }
            }
            //MessageBox.Show($"onConnectedDeviceGridViewSelectionChanged was changed successfully {this._connectedDeviceRowIdx}");
        }
        private void onConnectedDeviceGridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell editedCell = dgwConnectedDeviced.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (!editedCell.IsInEditMode)
                {
                    // Đoạn mã xử lý khi ô đã kết thúc chỉnh sửa
                    //MessageBox.Show($"onConnectedDeviceGridViewCellEndEdit was changed successfully {this._connectedDeviceRowIdx}");
                    var dto = this.getCurrentConnectedDeviceRowData();
                    if (dto != null && !dto.IsAdd)
                    {
                        dto.IsEdit = true;
                    }
                }
            }
        }

        private void onConnectedDeviceCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx == 0 && this.dgwConnectedDeviced.Columns[columnIdx] is DataGridViewCheckBoxColumn)
            {
                var dto = this.getCurrentConnectedDeviceRowData();
                if (dto != null && !dto.IsAdd)
                {
                    dto.IsEdit = true;
                    dto.IsExit = !dto.IsExit;
                }
            }
        }
        private void ConfigComboBoxColumn(DataGridView dataGridView, int columnIndex, string header, string property, EventHandler eventHandler)
        {
            var column = new DataGridViewComboBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;

            if (columnIndex == 2)
            {
                var deviceRoutingNames = _deviceRoutingData.Select(dto => dto.Name).ToArray();
                column.Items.AddRange(deviceRoutingNames);
            }
            else if (columnIndex == 3)
            {
                var deviceTypeNames = _deviceTypeData.Select(dto => dto.Name).ToArray();
                column.Items.AddRange(deviceTypeNames);
            }
            else if (columnIndex == 4)
            {
                var portNames = _portData.Select(dto => dto.Name).ToArray();
                column.Items.AddRange(portNames);
            }

            dataGridView.Columns.Add(column);
            dataGridView.EditingControlShowing += (sender, e) =>
            {
                if (e.Control is ComboBox comboBox)
                {
                    var editingColumn = dataGridView.CurrentCell.OwningColumn;
                    if (editingColumn.Index == columnIndex)
                    {
                        comboBox.SelectedIndexChanged -= eventHandler;
                        comboBox.SelectedIndexChanged += eventHandler;
                    }
                }
            };
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = ((ComboBox)sender).SelectedItem;
            var dto = this.getCurrentConnectedDeviceRowData();

            if (dto != null && !dto.IsAdd)
            {
                dto.IsEdit = true;

                // Xác định cột (index) của ComboBox được chọn
                int columnIndex = this.dgwConnectedDeviced.CurrentCell.ColumnIndex;

                switch (columnIndex)
                {
                    case 2: // Cột thứ 2
                        dto.DeviceRoutingName = selectedValue.ToString();
                        var deviceRouting = _deviceRoutingData.FirstOrDefault(d => d.Name == dto.DeviceRoutingName);
                        if (deviceRouting != null)
                        {
                            dto.DeviceRoutingID = (int)deviceRouting.ID;
                        }
                        break;

                    case 3: // Cột thứ 3
                        dto.DeviceTypeName = selectedValue.ToString();
                        var deviceType = _deviceTypeData.FirstOrDefault(d => d.Name == dto.DeviceTypeName);
                        if (deviceType != null)
                        {
                            dto.DeviceTypeID = (int)deviceType.ID;
                        }
                        break;
                    case 4: // Cột thứ 4
                        dto.PortName = selectedValue.ToString();
                        var portName = _portData.FirstOrDefault(d => d.Name == dto.PortName);
                        if (portName != null)
                        {
                            dto.PortID = (int)portName.ID;
                        }
                        break;
                }
                this.UpdateConnectedDeviceIDs(_connectedDeviceData);
            }
        }

        private void configConnectedDeviceGridView()
        {
            this.dgwConnectedDeviced.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgwConnectedDeviced.ScrollBars = ScrollBars.Both;
            this.dgwConnectedDeviced.AutoGenerateColumns = false;
            this.dgwConnectedDeviced.MultiSelect = false;

            // config gridview display columns
            this.configGridViewCheckboxColumn(this.dgwConnectedDeviced, "Exit", "IsExit");
            this.configGridViewColumn(this.dgwConnectedDeviced, "Device", "Name");

            this.ConfigComboBoxColumn(this.dgwConnectedDeviced, 2, "Device Routing", "DeviceRoutingName", ComboBox_SelectedIndexChanged);
            this.ConfigComboBoxColumn(this.dgwConnectedDeviced, 3, "Device Type", "DeviceTypeName", ComboBox_SelectedIndexChanged);
            this.ConfigComboBoxColumn(this.dgwConnectedDeviced, 4, "Port", "PortName", ComboBox_SelectedIndexChanged);
            this.configGridViewColumn(this.dgwConnectedDeviced, "Zebra Scanner SNo", "ZebraScannerSerialNumber");

            this.dgwConnectedDeviced.SelectionChanged += onConnectedDeviceGridViewSelectionChanged;
            this.dgwConnectedDeviced.CellEndEdit += onConnectedDeviceGridViewCellEndEdit;
            this.dgwConnectedDeviced.CellClick += onConnectedDeviceCellClick;
        }

        private void reloadSewingMachineGridView()
        {
            this.updateFormData(this._data[this._sewingRowIdx]);
            // config datasource
            this.dgSewingParameter.DataSource = null;
            this.dgSewingParameter.DataSource = this._data;
            this.dgSewingParameter.Refresh();
        }
        private void reloadConectedDeviceGridView()
        {
            // config datasource
            this.dgwConnectedDeviced.DataSource = null;
            this.dgwConnectedDeviced.DataSource = this._connectedDeviceData;
            this.dgwConnectedDeviced.Refresh();
        }

        private async void refreshData()
        {
            var result = await _sewingMachineConfigurationCommandServices.ListAllAsync();
            var dbData = (List<SewingMachineConfigurationDto>)result;
            this._data = dbData;

            var dto = await _connectedDeviceCommandServices.ListAllAsync();
            var db_Data = (List<ConnectedDeviceDto>)dto;
            this._connectedDeviceData = this.UpdateConnectedDeviceDetails(db_Data);

            this.reloadSewingMachineGridView();
            this.reloadConectedDeviceGridView();
        }
        private void updateFormData(SewingMachineConfigurationDto model)
        {
            if (model != null)
            {
                this.txtMachineNumber.Text = model.MachineNumber.ToString();
                this.txtAlterMachineNumber.Text = model.AlternativeMachine.ToString();
                this.cbACtive.Checked = model.IsActive;
                this.txtSerialNumber.Text = model.SerialNumber;
            }
        }
        private SewingMachineConfigurationDto getFormData()
        {
            SewingMachineConfigurationDto ret = new SewingMachineConfigurationDto();


            String machineNumber = this.txtMachineNumber.Text;
            String alterMachine = this.txtAlterMachineNumber.Text;
            bool isActive = this.cbACtive.Checked;
            String serialNumber = this.txtSerialNumber.Text;


            ret.MachineNumber = Convert.ToInt16(machineNumber);
            ret.AlternativeMachine = Convert.ToInt16(alterMachine);
            ret.IsActive = isActive;
            ret.SerialNumber = serialNumber;

            return ret;
        }
        private Boolean validateForm(SewingMachineConfigurationDto dto)
        {
            Boolean ret = true;
            // Code for valiate Form
            return ret;
        }

        private async void handleSave()
        {
            // get form data for Sewing Machine
            var sewingDto = this.getFormData();

            var validated = this.validateForm(sewingDto);

            if (validated)
            {
                // check add or update event

                var updateSewingList = new List<SewingMachineConfigurationDto>();
                foreach (SewingMachineConfigurationDto item in this._data)
                {
                    if (item.IsEdit)
                    {
                        updateSewingList.Add(item);
                    }
                }
                if (updateSewingList.Count > 0)
                {
                    // update
                    await _sewingMachineConfigurationCommandServices.UpdateBulk(updateSewingList);
                }
            }
            // get form data for Connected Device
            var currentRowData = this.getCurrentConnectedDeviceRowData();

            var tmpConnectedDeviceList = new List<ConnectedDeviceDto>();
            foreach (ConnectedDeviceDto item in this._connectedDeviceData)
            {
                if (item.IsEdit)
                {
                    tmpConnectedDeviceList.Add(item);
                }
            }
            var updateConnectedDeviceList = this.UpdateConnectedDeviceIDs(tmpConnectedDeviceList);
            if (updateConnectedDeviceList.Count > 0)
            {
                // update
                await _connectedDeviceCommandServices.UpdateBulk(updateConnectedDeviceList);
            }

            MessageBox.Show($"Data was changed successfully");
            this.refreshData();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.handleSave();
        }
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }
    }
}
