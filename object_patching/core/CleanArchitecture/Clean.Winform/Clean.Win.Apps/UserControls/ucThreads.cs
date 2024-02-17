using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Thread.Interfaces;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Common.Enum;
using Clean.WinF.Shared.Constants;
using Clean.WinF.Shared.ErrorMessage;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucThreads : UserControl
    {
        private readonly IThreadQueryServices _queryService;
        private readonly IThreadCommandServices _commandService;

        private readonly IWindingParamCommandServices _windingParamCommandService;

        // debug code begin
        //private readonly IPartQueryServices _queryService;
        //private readonly IPartCommandServices _commandService;
        // debug code end

        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;

        List<ThreadDto> _data = new List<ThreadDto>();
        List<ThreadWindingParamDto> _windingParams = new List<ThreadWindingParamDto>();

        int _selectedRowIdx = -1;

        Image chooseWindingParameterImage = Image.FromFile("Icons\\Button\\2.BMP");
        //Image editIconImage = Image.FromFile("Icons\\Button\\10.BMP");
        //Image addIconImage = Image.FromFile("Icons\\Button\\7.BMP");

        Image addIconImage = Image.FromFile("Icons\\createnew.png");
        Image editIconImage = Image.FromFile("Icons\\change.png");

        bool _refreshGrid = false;

        //public ucThreads(IThreadCommandServices commandService, IThreadQueryServices queryServices, IThreadQueryServices queryServices111)
        public ucThreads(IThreadCommandServices commandService, IThreadQueryServices queryServices,
            IWindingParamCommandServices windingParamCommandService)
        {
            _commandService = commandService;
            _queryService = queryServices;
            _windingParamCommandService = windingParamCommandService;
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
            uiCommon.IsImplementedUIPermision(this, nameof(MenuEnums.Threads));
        }

        private void configGridView()
        {
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.ReadOnly = false;
            this.mainGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.ScrollBars = ScrollBars.Both;
            this.mainGridView.AutoGenerateColumns = false;
            this.mainGridView.MultiSelect = true;
            //this.mainGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // config gridview display columns
            this.configGridViewIconColumn(this.mainGridView, "", "StatusIcon");
            this.configGridViewColumn(this.mainGridView, "Thread Code", "Code", false);
            this.configGridViewColumn(this.mainGridView, "Thread Name", "Name", false);
            this.configGridViewColumn(this.mainGridView, "Thread/Winding Paramter", "WindingParameterName");
            this.configGridViewCheckBoxColumn(this.mainGridView, "Needle Thread", "NeedleThread");
            this.configGridViewCheckBoxColumn(this.mainGridView, "Bobbin Thread", "BobbinThread");
            this.configGridViewIconColumn(this.mainGridView, "", "Icon");
            this.configGridViewColumn(this.mainGridView, "Thread Colour", "Colour", false);

            // register gridview event handler
            this.mainGridView.SelectionChanged += onGridViewSelectionChanged;
            this.mainGridView.CellEndEdit += onGridViewCellEndEdit;

            this.mainGridView.CellClick += onCellClick;
        }

        private void configForm()
        {
            this.txtCode.KeyUp += onKeyUp;
            this.txtName.KeyUp += onKeyUp;
            this.txtColour.KeyUp += onKeyUp;

            this.txtWindingParameter.ReadOnly = true;

            // prevent click on checkbox instead of disable the checkbox
            //this.chkUpperThread.Enabled = false;
            //this.chkBobbinThread.Enabled = false;
            this.chkUpperThread.Click += onCheckBoxClick;
            this.chkBobbinThread.Click += onCheckBoxClick;
        }

        private void formDataToDto(ThreadDto dto)
        {
            dto.Code = this.txtCode.Text;
            dto.Name = this.txtName.Text;
            dto.Colour = this.txtColour.Text;
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

        private void onCheckBoxClick(object sender, EventArgs e)
        {
            // Prevent changes to the checkbox's checked state
            if (sender is System.Windows.Forms.CheckBox checkBox)
            {
                checkBox.Checked = !checkBox.Checked;
            }
        }

        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx == 6 && this.mainGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                //MessageBox.Show($"on click on select winding param {this._selectedRowIdx}");
                this.showInputDataDiaglog(false);
            }
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
            var dbData = (List<ThreadDto>)result;

            var windingParams = await _windingParamCommandService.ListAllAsync();
            this._windingParams = windingParams;

            if (windingParams.Count == 0)
            {
                this.InitWindingParamDataAsync();
            }

            //var mockData = this.mockData(windingParams);

            this._data = dbData;

            if (dbData.Count == 0)
            {
                this.InitDataAsync();
            }
            this.reloadGridView();
        }

        private async Task InitDataAsync()
        {
            var rs = await _commandService.CreateBulk(new List<ThreadDto>()
            {
                new ThreadDto(){Code = "01",Name="TEst ", Colour="02", WindingParameterName="01", BobbinThread=true, NeedleThread=true, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                new ThreadDto(){Code = "02",Name="Vardhanam", Colour="03", WindingParameterName="02", BobbinThread=true, NeedleThread=true, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                new ThreadDto(){Code = "03",Name="VARDHAMAN", Colour="04", WindingParameterName="03", BobbinThread=true, NeedleThread=true, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true},
                new ThreadDto(){Code = "04",Name="RELIANCE P", Colour="05", WindingParameterName="04", BobbinThread=true, NeedleThread=true, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true}
            });
            if (rs)
            {
                this._data = await _queryService.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        private async Task InitWindingParamDataAsync()
        {
            var rs = await _windingParamCommandService.CreateBulk(this.mockWindingParamsData());
            if (rs)
            {
                this._windingParams = await _windingParamCommandService.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        // debug code begin
        // this method should be modified to get data from database to restore the row to original status
        private async Task<ThreadDto> getById(long id)
        {
            //ThreadDto ret = null;
            //var windingParams = mockWindingParamsData();
            //var mockData = this.mockData(windingParams);

            //foreach (ThreadDto dto in mockData)
            //{
            //    if(dto.ID == id)
            //    {
            //        ret = dto; 
            //        break;
            //    }
            //}
            //return ret;
            return await _queryService.GetById(id);
        }
        // debug code begin

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
            foreach (ThreadDto dto in this._data)
            {
                dto.updateWindingParam();
                dto.Icon = this.chooseWindingParameterImage;
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

        //private void updateGridViewData(List<ThreadDto> data)
        //{
        //    var iconImage = Image.FromFile("Icons\\Button\\2.BMP");

        //    var columns = from t in data
        //                  select new
        //                  {
        //                      Code = t.Code,
        //                      Name = t.Name,
        //                      WindingParamterName = t.WindingParam != null ? t.WindingParam.Name : "",
        //                      NeedleThread = t.WindingParam != null ? t.WindingParam.NeedleThread : false,
        //                      BobbinThread = t.WindingParam != null ? t.WindingParam.BobbinThread : false,
        //                      Colour = t.Colour,
        //                      Icon = iconImage,
        //                  };

        //    this.mainGridView.DataSource = null;
        //    //this.mainGridView.DataSource = data;
        //    this.mainGridView.DataSource = columns.ToList();
        //    //this.mainGridView.Refresh();
        //}

        private void updateFormData(ThreadDto model)
        {
            if (model != null)
            {
                this.txtCode.Text = model.Code;
                this.txtName.Text = model.Name;
                var windingParam = model.WindingParam;
                string windingParamName = model.WindingParameterName;
                bool needleThread = model.NeedleThread;
                bool bobbinThread = model.BobbinThread;

                if (windingParam != null)
                {
                    windingParamName = windingParam.Name;
                    needleThread = windingParam.NeedleThread;
                    bobbinThread = windingParam.BobbinThread;
                }
                this.txtWindingParameter.Text = windingParamName;
                this.chkUpperThread.Checked = needleThread;
                this.chkBobbinThread.Checked = bobbinThread;
                this.txtColour.Text = model.Colour;
            }
        }

        private ThreadDto getCurrentRowData()
        {
            ThreadDto ret = null;
            if (_selectedRowIdx != -1)
            {
                ret = this._data[_selectedRowIdx];
            }
            return ret;
        }

        // used when click button save
        private ThreadDto getFormData()
        {
            ThreadDto ret = new ThreadDto();
            String code = this.txtCode.Text;
            String name = this.txtName.Text;
            String colour = this.txtColour.Text;

            ret.Code = code;
            ret.Name = name;
            ret.Colour = colour;

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

        private Boolean validateForm(ThreadDto dto)
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
                var currentRowData = this.getCurrentRowData();
                //if (currentRowData.IsAdd)
                //{
                //    MessageBox.Show($"handleSave: insert data");
                //}
                //else
                //{
                //    MessageBox.Show($"handleSave: update data");
                //}

                var windingParam = currentRowData.WindingParam;
                //MessageBox.Show($"handleSave: ID:: {currentRowData.ID} - Code:: {dto.Code} - Name:: {dto.Name} - Colour:: {dto.Colour}" +
                //    $" - windingParam.name {windingParam.Name} - windingParam.needle {windingParam.NeedleThread} - windingParam.bobbin {windingParam.BobbinThread}");

                var insertList = new List<ThreadDto>();
                var updateList = new List<ThreadDto>();
                foreach (ThreadDto item in this._data)
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

        private void handleDataCallback(ThreadDto dto)
        {
            dto.WindingParam = this._windingParams[dto.WindingParamIdx];
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
                    updatedData.WindingParam = this._windingParams[dto.WindingParamIdx];

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
            //var dto = this.mockThreadDto();
            //// debug code end
            //this.handleInsertCallback(dto);

            showInputDataDiaglog(true);
        }

        private void btnEditWindingParam_Click(object sender, EventArgs e)
        {
            showInputDataDiaglog(false);
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
            steps.Add(new InputDataStep
            {
                PropertyName = "WindingParamId",
                ControllType = EInputDataType.DATAGRIDVIEW,
                ExtraData = this._windingParams
            });
            steps.Add(new InputDataStep
            {
                PropertyName = "Colour",
                ControllType = EInputDataType.TEXTBOX
            });
            return steps;
        }

        private void showInputDataDiaglog(bool isAdd)
        {
            var dto = new ThreadDto();
            dto.IsAdd = isAdd;

            var steps = this.getInsertSteps();
            if (!dto.IsAdd)
            {
                // update step
                steps = new List<InputDataStep>() { steps[2] };
            }

            InputDataForm inputDataForm = new InputDataForm(steps, dto,
                EInputDataForm.THREADS, validationAction);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
        }

        private void validationAction()
        {
            MessageBox.Show($"validated");
        }

        private void OnClosingDataInputForm(Object inputObject, string status)
        {
            var dto = (ThreadDto)inputObject;
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

        // debug code begin
        private List<ThreadDto> mockData(List<ThreadWindingParamDto> windingParams)
        {
            List<ThreadDto> ret = new List<ThreadDto>();

            for (int i = 1; i <= 20; i++)
            {
                ThreadDto threadDto = new ThreadDto();
                threadDto.ID = i;
                threadDto.Code = "code " + i;
                threadDto.Name = "name " + i;
                threadDto.Colour = "colour " + i;
                ret.Add(threadDto);
            }

            ret[0].WindingParam = windingParams[0];
            ret[1].WindingParam = windingParams[1];
            ret[2].WindingParam = windingParams[2];

            return ret;
        }

        private ThreadDto mockThreadDto()
        {
            int count = this._data.Count + 1;
            var dto = new ThreadDto();
            dto.Code = "new - xxx - " + count;
            dto.Name = "new - yyy - " + count;
            dto.Colour = "new - zzz - " + count;
            return dto;
        }

        private List<ThreadWindingParamDto> mockWindingParamsData()
        {
            var ret = new List<ThreadWindingParamDto>();
            ret.Add(new ThreadWindingParamDto()
            {
                Name = "20 TEX",
                NeedleThread = false,
                BobbinThread = true,
                StitchesOnFullBobbin = "25000",
                WindingDurationOnMachine = "30000",
                Remark = "Heavy (Weight...)",
                IsActive = true,
            });
            ret.Add(new ThreadWindingParamDto()
            {
                Name = "30 TEX",
                NeedleThread = false,
                BobbinThread = true,
                StitchesOnFullBobbin = "25000",
                WindingDurationOnMachine = "30000",
                Remark = "Upholstery (Weight...)",
                IsActive = true,
            });
            ret.Add(new ThreadWindingParamDto()
            {
                Name = "40 TEX",
                NeedleThread = true,
                BobbinThread = false,
                StitchesOnFullBobbin = "25000",
                WindingDurationOnMachine = "30000",
                Remark = "Regular (Weight...)",
                IsActive = true,
            });

            for (int i = ret.Count + 1; i < 20; i++)
            {
                ret.Add(this.mockWindingParfamDto(i));
            }
            return ret;
        }

        private ThreadWindingParamDto mockWindingParfamDto(int count)
        {
            var dto = new ThreadWindingParamDto()
            {
                ID = count,
                Name = "Name " + count,
                NeedleThread = true,
                BobbinThread = false,
                StitchesOnFullBobbin = count.ToString(),
                WindingDurationOnMachine = count.ToString(),
                Remark = "Remard " + count.ToString(),
                IsActive = true,
            };
            return dto;
        }
        // debug code end

        // import export begin
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
                    List<ThreadDto> exportData = new List<ThreadDto>();
                    for (int i = 0; i < _data.Count; i++)
                    {
                        if (selectedIndices.Contains(i.ToString()))
                        {
                            exportData.Add(_data[i]);
                        }
                    }
                    this.ExportBulk(exportData, filePath);
                    UIUtility.AppShowMsg(CustomErrorMessage.APP_THREAD_EXPORTED_SUCCESS);
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

                List<ThreadDto> rs = this.ImportBulk(_data, selectedFilePath);
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

        static string GetCellAddress(int row, int col)
        {
            string columnName = GetColumnName(col);
            return $"{columnName}{row}";
        }
        static string GetColumnName(int columnNumber)
        {
            const int baseNumber = 'Z' - 'A' + 1;
            string columnName = "";

            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % baseNumber;
                columnName = (char)('A' + remainder) + columnName;
                columnNumber = (columnNumber - 1) / baseNumber;
            }

            return columnName;
        }
        public void ExportBulk(List<ThreadDto> dtos, string filePath)
        {

            // Create a new Excel package
            using (var workbook = new XLWorkbook())
            {
                // Get the default worksheet
                var worksheet = workbook.Worksheets.Add("Sheet1");

                worksheet.Range(GetCellAddress(1, 1)).Value = "h1";
                worksheet.Range(GetCellAddress(1, 2)).Value = "Material Code";
                worksheet.Range(GetCellAddress(1, 3)).Value = "Material Name";

                int row = 2;
                foreach (var dataItem in dtos)
                {
                    worksheet.Range(GetCellAddress(row, 1)).Value = "r";
                    worksheet.Range(GetCellAddress(row, 2)).Value = dataItem.Code;
                    worksheet.Range(GetCellAddress(row, 3)).Value = dataItem.Name;

                    row++;
                }

                for (int i = 1; i < 100; i++)
                {
                    worksheet.Column(i).AdjustToContents();
                }
                workbook.SaveAs(filePath);
            }
        }
        public List<ThreadDto> ImportBulk(List<ThreadDto> incomingDtos, string filePath)
        {
            var dtos = new List<ThreadDto>();
            using (var workbook = new XLWorkbook(filePath))
            {
                if (workbook != null)
                {
                    IXLWorksheet worksheet = workbook.Worksheets.FirstOrDefault(); // Get the first worksheet, for example

                    if (worksheet != null)
                    {
                        int rowCount = worksheet.LastCellUsed().Address.RowNumber;
                        for (int row = 2; row <= rowCount; row++)
                        {
                            ThreadDto dataItem = incomingDtos.FirstOrDefault(dataItem => dataItem.Code == worksheet.Cell(GetCellAddress(row, 2)).Value.ToString());
                            if (dataItem == null)
                            {
                                dataItem = new ThreadDto();
                            }
                            else
                            {
                                continue;
                            }
                            dataItem.Code = worksheet.Cell(GetCellAddress(row, 2)).Value.ToString();
                            dataItem.Name = worksheet.Cell(GetCellAddress(row, 3)).Value.ToString();
                            dataItem.IsActive = true;
                            dataItem.IsAdd = true;
                            dtos.Add(dataItem);
                        }
                        Console.WriteLine();
                        return dtos;
                    }
                }
            }
            return dtos;
        }
        // import export end
    }
}
