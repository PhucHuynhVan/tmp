using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Supplier.DTOs;
using Clean.WinF.Applications.Features.Supplier.Interfaces;
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
    public partial class ucSuppliers : UserControl
    {
        private readonly ISupplierQueryServices _queryService;
        private readonly ISupplierCommandServices _commandService;

        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;

        List<SupplierDto> _data = new List<SupplierDto>();
        int _selectedRowIdx = -1;

        Image addIconImage = Image.FromFile("Icons\\createnew.png");
        Image editIconImage = Image.FromFile("Icons\\change.png");
        bool _refreshGrid = false;


        public ucSuppliers(ISupplierCommandServices commandService, ISupplierQueryServices queryServices)
        {
            _commandService = commandService;
            _queryService = queryServices;
            InitializeComponent();
        }
        private async Task InitDataAsync()
        {
            _data = await _queryService.ListAllAsync();
            if (_data.Count == 0)
            {
                var rs = await _commandService.CreateBulkSuppliers(new List<SupplierDto>()
                {
                    new SupplierDto(){Code = "01",Name="PG Sdn Bhd", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                    new SupplierDto(){Code = "02",Name="Vardhanam", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                    new SupplierDto(){Code = "03",Name="VARDHAMAN", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                    new SupplierDto(){Code = "04",Name="RELIANCE P", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true}
                });
                if (rs)
                {
                    _data = await _queryService.ListAllAsync();
                    await Console.Out.WriteLineAsync();
                }
            }


        }

        private void onFormLoad(object sender, EventArgs e)
        {
            // config grid view columns
            this.configGridView();

            // config form
            this.configForm();
            // Innit
            this.InitDataAsync();
            // load gridview data
            this.refreshData();

            //implement ui permission for supplier
            uiCommon.IsImplementedUIPermision(this, nameof(MenuEnums.Suppliers));
        }

        private void configForm()
        {
            this.txtSupplierCode.KeyUp += onKeyUp;
            this.txtSupplierName.KeyUp += onKeyUp;
            this.txtSupplierZip.KeyUp += onKeyUp;
            this.txtSupplierStreet.KeyUp += onKeyUp;
            this.txtSupplierPlace.KeyUp += onKeyUp;
            this.txtSupplierTelephone.KeyUp += onKeyUp;
            this.txtSupplierFax.KeyUp += onKeyUp;
            this.txtSupplierRemark.KeyUp += onKeyUp;
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
                }
            }
        }

        private void formDataToDto(SupplierDto dto)
        {
            dto.Code = this.txtSupplierCode.Text;
            dto.Name = this.txtSupplierName.Text;
            dto.Street = this.txtSupplierStreet.Text;
            dto.Zip = this.txtSupplierZip.Text;
            dto.Place = this.txtSupplierPlace.Text;
            dto.Telephone = this.txtSupplierTelephone.Text;
            dto.Fax = this.txtSupplierFax.Text;
            dto.Remark = this.txtSupplierRemark.Text;
        }

        private void fromDtoToForm(SupplierDto dto)
        {
            this.txtSupplierCode.Text = dto.Code;
            this.txtSupplierName.Text = dto.Name;
            this.txtSupplierStreet.Text = dto.Street;
            this.txtSupplierZip.Text = dto.Zip;
            this.txtSupplierPlace.Text = dto.Place;
            this.txtSupplierTelephone.Text = dto.Telephone;
            this.txtSupplierFax.Text = dto.Fax;
            this.txtSupplierRemark.Text = dto.Remark;
        }

        private void configGridView()
        {
            this.mainGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.ScrollBars = ScrollBars.Both;
            this.mainGridView.AutoGenerateColumns = false;
            this.mainGridView.ReadOnly = false; ;

            // config gridview display columns
            this.configGridViewIconColumn(this.mainGridView, "", "StatusIcon");
            this.configGridViewColumn(this.mainGridView, "Supplier Code", "Code", false);
            this.configGridViewColumn(this.mainGridView, "Supplier Name", "Name", false);
            this.configGridViewColumn(this.mainGridView, "Street", "Street", false);
            this.configGridViewColumn(this.mainGridView, "Zip", "Zip", false);
            this.configGridViewColumn(this.mainGridView, "Place", "Place", false);
            this.configGridViewColumn(this.mainGridView, "Telephone", "Telephone", false);
            this.configGridViewColumn(this.mainGridView, "Fax", "Fax", false);
            this.configGridViewColumn(this.mainGridView, "Remark", "Remark", false);

            for (int i = 0; i < mainGridView.Columns.Count; i++)
            {
                mainGridView.Columns[i].ReadOnly = false;
            }

            // register gridview event handler
            this.mainGridView.SelectionChanged += onGridViewSelectionChanged;
            this.mainGridView.CellEndEdit += onGridViewCellEndEdit;

            this.mainGridView.CellClick += onCellClick;
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
                //this.reloadGridView();
            }
            this._refreshGrid = true;
        }

        private void showInputDataDiaglog(bool isAdd)
        {
            var dto = new SupplierDto();
            dto.IsAdd = isAdd;
            dto.IsActive = true;

            var steps = this.getInsertSteps();
            if (!dto.IsAdd)
            {
                steps = new List<InputDataStep>() { steps[2] };
            }
            _data.Add(dto);
            reloadGridView();
            _selectedRowIdx = _data.Count - 1;
            //this.drgArticle.Rows[_selectedRowIdx].Selected = true;
            this.mainGridView.CurrentCell = this.mainGridView.Rows[_selectedRowIdx].Cells[0];
            this.onRowChange(mainGridView.Rows[_selectedRowIdx]);

            InputDataForm inputDataForm = new InputDataForm(steps, dto,
                EInputDataForm.SUPPLIERS, validationAction);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
        }

        private List<InputDataStep> getInsertSteps()
        {
            List<InputDataStep> steps = new List<InputDataStep>();
            steps.Add(new InputDataStep
            {
                PropertyName = "Code",
                ControllType = EInputDataType.TEXTBOX
            });
            steps.Add(new InputDataStep
            {
                PropertyName = "Name",
                ControllType = EInputDataType.TEXTBOX
            });
            return steps;
        }

        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx == 6 && this.mainGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                this.showInputDataDiaglog(false);
            }
            if (columnIdx == 0 && this.mainGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                var selectedData = this._data[this._selectedRowIdx];
                if (selectedData != null && selectedData.IsEdit)
                {
                    var originalData = this.getByIdAsync(selectedData.ID);
                    if (originalData != null)
                    {
                        this._data[this._selectedRowIdx] = originalData.Result;
                        this.reloadGridView();
                        this.fromDtoToForm(originalData.Result);
                    }
                }
            }
        }

        private async Task<SupplierDto> getByIdAsync(long id)
        {
            return await _queryService.GetSupplierById(id);
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
            String header, String property, Boolean readOnly = true, int width = 150)
        {
            var column = new DataGridViewTextBoxColumn()
            {
                HeaderText = header,
                DataPropertyName = property,
                Width = width,
                ReadOnly = readOnly,
            };

            dataGridView.Columns.Add(column);
        }


        private async void refreshData()
        {
            // data is available
            this._data = await this._queryService.ListAllAsync();
            this.reloadGridView();
        }

        private void reloadGridView()
        {
            //this.updateGridViewData(this._data);

            //MessageBox.Show($"reloadGridView");
            this.updateDataSource();

            // config datasource
            this.mainGridView.DataSource = null;
            this.mainGridView.DataSource = this._data;
            this.mainGridView.Refresh();
        }

        private void updateDataSource()
        {
            var defaultIcon = new Bitmap(1, 1);
            foreach (SupplierDto dto in this._data)
            {
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


        private void updateFormData(SupplierDto model)
        {
            if (model != null)
            {
                this.txtSupplierCode.Text = model.Code;
                this.txtSupplierName.Text = model.Name;
                this.txtSupplierStreet.Text = model.Street;
                this.txtSupplierZip.Text = model.Zip;
                this.txtSupplierPlace.Text = model.Place;
                this.txtSupplierTelephone.Text = model.Telephone;
                this.txtSupplierFax.Text = model.Fax;
                this.txtSupplierRemark.Text = model.Remark;
            }
        }

        private SupplierDto getCurrentRowData()
        {
            SupplierDto ret = null;
            if (_selectedRowIdx != -1)
            {
                ret = this._data[_selectedRowIdx];
            }
            return ret;
        }

        // used when click button save
        private SupplierDto getFormData()
        {
            SupplierDto ret = new SupplierDto();


            String code = this.txtSupplierCode.Text;
            String name = this.txtSupplierName.Text;
            String street = this.txtSupplierStreet.Text;
            String zip = this.txtSupplierZip.Text;
            String place = this.txtSupplierPlace.Text;
            String telephone = this.txtSupplierTelephone.Text;
            String fax = this.txtSupplierFax.Text;
            String remark = this.txtSupplierRemark.Text;


            ret.Code = code;
            ret.Name = name;
            ret.Street = street;
            ret.Zip = zip;
            ret.Place = place;
            ret.Telephone = telephone;
            ret.Fax = fax;
            ret.Remark = remark;

            return ret;
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
                    this._selectedRowIdx = selectedRow.Index;
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

        private Boolean validateForm(SupplierDto dto)
        {
            Boolean ret = true;
            if (string.IsNullOrEmpty(dto.Code.Trim()))
            {
                UIUtility.AppShowMsg("Code value should be not empty.", UIConstants.MSGBOX_ICON_ERROR_STYLE);
                ret = false;
            }

            if (string.IsNullOrEmpty(dto.Name.Trim()))
            {
                UIUtility.AppShowMsg("Name value should be not empty.", UIConstants.MSGBOX_ICON_ERROR_STYLE);
                ret = false;
            }
            return ret;
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

                var insertList = new List<SupplierDto>();
                var updateList = new List<SupplierDto>();
                foreach (SupplierDto item in this._data)
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
                    await _commandService.CreateBulkSuppliers(insertList);
                }
                if (updateList.Count > 0)
                {
                    // update
                    await _commandService.UpdateBulkSupliers(updateList);
                }
            }
            UIUtility.AppShowMsg(CustomErrorMessage.APP_SUPPLIER_UPDATED_SUCCESS);
            refreshData();
        }

        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.handleSave();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            showInputDataDiaglog(true);
        }

        private void validationAction()
        {
            Console.WriteLine("validated");
        }

        private void OnClosingDataInputForm(Object inputObject, string status)
        {
            var dto = (SupplierDto)inputObject;
            switch (status)
            {
                case CommonConstant.InputDataFinished:
                    this.handleDataCallback(dto);
                    //this.drgArticle.Rows[_selectedRowIdx].Selected = true;
                    this.mainGridView.CurrentCell = this.mainGridView.Rows[_selectedRowIdx].Cells[0];
                    this.onRowChange(mainGridView.Rows[_selectedRowIdx]);
                    break;
                default:
                    _selectedRowIdx = 0;
                    dto = (SupplierDto)inputObject;
                    if (dto.ID == 0)
                    {
                        _data.RemoveAt(_data.Count - 1);

                    }
                    reloadGridView();
                    break;
            }
        }

        private void handleDataCallback(SupplierDto dto)
        {

            if (dto.IsAdd)
            {
                // add to beginning
                //this._data.Insert(0, dto);

                // add to the end
                //this._data.Add(dto);
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


        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set properties for the SaveFileDialog
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.Title = "Save File";
                saveFileDialog.DefaultExt = "xlsx";

                // Show the SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name
                    string filePath = saveFileDialog.FileName;
                    List<string> selectedIndices = new List<string>();

                    foreach (DataGridViewRow row in mainGridView.SelectedRows)
                    {
                        int rowIndex = row.Index;
                        selectedIndices.Add(rowIndex.ToString());
                    }
                    List<SupplierDto> exportData = new List<SupplierDto>();
                    for (int i = 0; i < _data.Count; i++)
                    {
                        if (selectedIndices.Contains(i.ToString()))
                        {
                            exportData.Add(_data[i]);
                        }
                    }
                    _commandService.ExportBulk(exportData, filePath);
                    UIUtility.AppShowMsg(CustomErrorMessage.APP_SUPPLIER_EXPORTED_SUCCESS);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties of the dialog
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

            // Show the dialog and get the result
            DialogResult result = openFileDialog.ShowDialog();

            // Check if the user clicked OK in the dialog
            if (result == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog.FileName;

                List<SupplierDto> rs = _commandService.ImportBulk(_data, selectedFilePath);
                try
                {
                    MessageBox.Show("Import File: " + selectedFilePath + " succeed", "Import");
                    _data.AddRange(rs);
                    reloadGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import failed: " + ex.Message, "Import");
                }
            }
        }
    }
}
