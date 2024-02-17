using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Common.Enum;
using Clean.WinF.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucPartConfig : UserControl
    {

        private readonly IPartQueryServices _queryService;
        private readonly IPartCommandServices _commandService;

        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;

        List<PartDto> _data = new List<PartDto>();

        int _selectedRowIdx = -1;

        Image addIconImage = Image.FromFile("Icons\\createnew.png");
        Image editIconImage = Image.FromFile("Icons\\change.png");

        bool _refreshGrid = false;

        public ucPartConfig(IPartCommandServices commandService, IPartQueryServices queryServices)
        {
            _commandService = commandService;
            _queryService = queryServices;
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            // config grid view columns
            this.configGridView();

            // config form
            this.configForm();

            // load gridview data
            this.refreshData();
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

        private void configGridView()
        {
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.ReadOnly = false;
            this.mainGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.ScrollBars = ScrollBars.Both;
            this.mainGridView.AutoGenerateColumns = false;
            this.mainGridView.MultiSelect = false;
            //this.mainGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // config gridview display columns
            this.configGridViewIconColumn(this.mainGridView, "", "StatusIcon");
            this.configGridViewColumn(this.mainGridView, "Parts Code", "Code", false);
            this.configGridViewColumn(this.mainGridView, "Parts Name", "Name", false);

            // register gridview event handler
            this.mainGridView.SelectionChanged += onGridViewSelectionChanged;
            this.mainGridView.CellEndEdit += onGridViewCellEndEdit;

            this.mainGridView.CellClick += onCellClick;
        }

        private void configForm()
        {
            this.txtCode.KeyUp += onKeyUp;
            this.txtName.KeyUp += onKeyUp;
        }

        private void formDataToDto(PartDto dto)
        {
            dto.Code = this.txtCode.Text;
            dto.Name = this.txtName.Text;
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

        private void configGridViewCheckBoxColumn(DataGridView dataGridView,
            String header, String property, int width = 150)
        {
            var column = new DataGridViewCheckBoxColumn
            {
                HeaderText = header,
                DataPropertyName = property,
                ReadOnly = true,
                Width = width,
            };
            dataGridView.Columns.Add(column);
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

        private async void refreshData()
        {
            var result = await _queryService.ListAllAsync();
            var dbData = (List<PartDto>)result;

            this._data = dbData;

            if (dbData.Count == 0)
            {
                this.InitDataAsync();
            }
            this.reloadGridView();
        }

        private async Task InitDataAsync()
        {
            var rs = await _commandService.CreateBulk(new List<PartDto>()
            {
                new PartDto(){Code = "01",Name="Name 01", IsActive = true},
                new PartDto(){Code = "02",Name="Name 02", IsActive = true},
                new PartDto(){Code = "03",Name="Name 03", IsActive = true},
                new PartDto(){Code = "04",Name="Name 04", IsActive = true},
                new PartDto(){Code = "05",Name="Name 05", IsActive = true},
            });
            if (rs)
            {
                this._data = await _queryService.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        private async Task<PartDto> getById(long id)
        {
            return await _queryService.GetById(id);
        }

        private void reloadGridView()
        {
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
            foreach (PartDto dto in this._data)
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

        private void updateFormData(PartDto model)
        {
            if (model != null)
            {
                this.txtCode.Text = model.Code;
                this.txtName.Text = model.Name;
            }
        }

        private PartDto getCurrentRowData()
        {
            PartDto ret = null;
            if (_selectedRowIdx != -1)
            {
                ret = this._data[_selectedRowIdx];
            }
            return ret;
        }

        // used when click button save
        private PartDto getFormData()
        {
            PartDto ret = new PartDto();
            String code = this.txtCode.Text;
            String name = this.txtName.Text;

            ret.Code = code;
            ret.Name = name;
            return ret;
        }

        private void onGridViewSelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"onGridViewSelectionChanged:: {this._selectedRowIdx}");
            //MessageBox.Show($"onGridViewSelectionChanged:: _refreshGrid:: {this._refreshGrid}");
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

        private void onRowChange(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                //MessageBox.Show($"onRowChange: selectedRow = {this._selectedRowIdx}");
                this.updateFormData(this.getCurrentRowData());
            }
        }

        private Boolean validateForm(PartDto dto)
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
                var insertList = new List<PartDto>();
                var updateList = new List<PartDto>();
                foreach (PartDto item in this._data)
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

                MessageBox.Show($"handleSave: insertList:: count:: {insertList.Count} - updateList:: count:: {updateList.Count}");

                if (insertList.Count > 0)
                {
                    // insert
                    await _commandService.CreateBulk(insertList);
                }
                if (updateList.Count > 0)
                {
                    // update
                    await _commandService.UpdateBulk(updateList);
                }
                this.refreshData();
            }

        }

        private void handleDataCallback(PartDto dto)
        {
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
            //MessageBox.Show($"on click insert");
            //// debug code begin
            //var dto = this.mockPartDto();
            //// debug code end
            //this.handleInsertCallback(dto);

            showInputDataDiaglog(true);
        }

        private void btnEditWindingParam_Click(object sender, EventArgs e)
        {
            showInputDataDiaglog(false);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

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

        private void showInputDataDiaglog(bool isAdd)
        {
            var dto = new PartDto();
            dto.IsAdd = isAdd;

            var steps = this.getInsertSteps();

            InputDataForm inputDataForm = new InputDataForm(steps, dto,
                EInputDataForm.PARTS, validationAction);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
        }

        private void validationAction()
        {
            MessageBox.Show($"validated");
        }

        private void OnClosingDataInputForm(Object inputObject, string status)
        {
            var dto = (PartDto)inputObject;
            switch (status)
            {
                case CommonConstant.InputDataFinished:
                    this.handleDataCallback(dto);
                    break;
                default:
                    //close form
                    break;
            }
        }
    }
}
