using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using Clean.WinF.Applications.Features.SerialNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clean.Win.AppConfigUI.UserControls
{
    public partial class ucSerialNumberConfig : UserControl
    {
        private readonly ISerialNumberCommandServices _serialNumberCommandServices;
        private readonly ICounterTypeCommandServices _counterTypeCommandServices;
        private readonly IResetTypeCommandServices _resetTypeCommandServices;

        SerialNumberDto _serialNumberData = new SerialNumberDto();
        List<CounterTypeDto> _counterTypeData = new List<CounterTypeDto>();
        List<ResetTypeDto> _resetTypeData = new List<ResetTypeDto>();
        long _serialID;
        public ucSerialNumberConfig(
            ISerialNumberCommandServices serialNumberCommandServices,
            ICounterTypeCommandServices counterTypeCommandServices,
            IResetTypeCommandServices resetTypeCommandServices,
            SerialNumberDto dto)
        {
            InitializeComponent();
            _serialNumberCommandServices = serialNumberCommandServices;
            _counterTypeCommandServices = counterTypeCommandServices;
            _resetTypeCommandServices = resetTypeCommandServices;
            _serialNumberData = dto;
        }
        private async void onFormLoad(object sender, EventArgs e)
        {

            // Clip sensor Port
            var couterType = await _counterTypeCommandServices.ListAllAsync();
            this._counterTypeData = couterType;
            // Clip DeviceType Port
            var resetType = await _resetTypeCommandServices.ListAllAsync();
            this._resetTypeData = resetType;
            _serialID = _serialNumberData.ID;

            this.configGridView();
            this.configForm();
            this.refreshData();
        }
        private async void refreshData()
        {
            var result = await _serialNumberCommandServices.GetById(this._serialID);
            this._serialNumberData = result;

            this.updateFormData(this._serialNumberData);
            this.reloadGridView();
        }
        private void reloadGridView()
        {
            // config datasource
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this._serialNumberData;
            this.dataGridView1.Refresh();
        }
        private void configConterTypeComboBox(ComboBox comboBox, List<CounterTypeDto> dataSource)
        {
            comboBox.DataSource = dataSource.Select(item => item.Name).ToList();
        }
        private void configResetTypeComboBox(ComboBox comboBox, List<ResetTypeDto> dataSource)
        {
            comboBox.DataSource = dataSource.Select(item => item.Name).ToList();
        }
        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox)
            {
                var dto = this._serialNumberData;
                if (dto != null)
                {
                    this.formDataToDto(dto);
                }
            }
        }
        private void formDataToDto(SerialNumberDto dto)
        {
            dto.ID = long.Parse(this.txtID.Text);
            dto.Name = this.txtName.Text;
            dto.InternalName = this.txtInternalName.Text;
            dto.MaximumValue = long.Parse(this.txtMaxValue.Text);
            dto.CurrentSerialNumber = long.Parse(this.txtSerialNumber.Text);
            dto.ResetDate = Convert.ToDateTime(this.txtResetDate.Text);
        }
        private void updateFormData(SerialNumberDto model)
        {
            if (model != null)
            {
                this.txtID.Text = model.ID.ToString();
                this.txtName.Text = model.Name;
                this.txtInternalName.Text = model.InternalName;
                this.txtMaxValue.Text = model.MaximumValue.ToString();
                this.txtSerialNumber.Text = model.CurrentSerialNumber.ToString();
                this.txtResetDate.Text = model.ResetDate.ToString();

                cbCountertype.SelectedItem = model.CounterTypeName;
                cbResetType.SelectedItem = model.ResetTypeName;
            }
        }
        private void configForm()
        {
            this.txtSerialNumber.ReadOnly = true;
            this.txtResetDate.ReadOnly = true;
            this.txtID.KeyUp += this.onKeyUp;
            this.txtName.KeyUp += this.onKeyUp;
            this.txtInternalName.KeyUp += this.onKeyUp;
            this.txtMaxValue.KeyUp += this.onKeyUp;

            this.configConterTypeComboBox(cbCountertype, _counterTypeData);
            this.configResetTypeComboBox(cbResetType, _resetTypeData);
        }
        private void configGridViewColumn(DataGridView dataGridView, String header, String property)
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;
            dataGridView.Columns.Add(column);
        }
        private void configGridView()
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ScrollBars = ScrollBars.Both;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.MultiSelect = false;

            // config gridview display columns
            this.configGridViewColumn(this.dataGridView1, "Serial Number", "CurrentSerialNumber");
            this.configGridViewColumn(this.dataGridView1, "Reset date", "ResetDate");
        }
        private SerialNumberDto getFormData()
        {
            SerialNumberDto ret = new SerialNumberDto();

            String id = this.txtID.Text;
            String name = this.txtName.Text;
            String internalName = this.txtInternalName.Text;
            String counterType = this.cbCountertype.Text;
            String resetType = this.cbResetType.Text;
            String maxValue = this.txtMaxValue.Text;
            String currentSerialNumber = this.txtSerialNumber.Text;
            String resetDate = this.txtResetDate.Text;


            ret.ID = long.Parse(id);
            ret.Name = name;
            ret.CounterTypeName = counterType;
            ret.InternalName = internalName;
            ret.ResetTypeName = resetType;
            ret.MaximumValue = long.Parse(maxValue);
            ret.CurrentSerialNumber = long.Parse(currentSerialNumber);
            ret.ResetDate = Convert.ToDateTime(resetDate);

            return ret;
        }
        private Boolean validateForm(SerialNumberDto dto)
        {
            Boolean ret = true;
            // Code for valiate Form
            return ret;
        }
        private async void handleSave()
        {
            // get form data for Sewing Machine
            var dto = this.getFormData();
            var validated = this.validateForm(dto);

            if (validated)
            {
                // check add or update event

                var updateList = new List<SerialNumberDto>
                {
                    dto
                };
                if (updateList.Count > 0)
                {
                    // update
                    await _serialNumberCommandServices.UpdateBulk(updateList);
                }
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
