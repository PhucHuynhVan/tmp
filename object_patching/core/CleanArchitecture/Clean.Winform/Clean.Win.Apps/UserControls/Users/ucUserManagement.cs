using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Part.Interfaces;
using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Common.Enum;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Shared.Constants;
using Clean.WinF.Shared.ErrorMessage;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    public partial class ucUserManagement : UserControl
    {
        private readonly IPartQueryServices _queryService;
        private readonly IUserCommandServices _commandService;

        private readonly IRoleCommandServices _roleCommandService;

        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;

        List<UserDto> _data = new List<UserDto>();
        List<RoleDto> _roles = new List<RoleDto>();

        int _selectedRowIdx = -1;

        Image addIconImage = Image.FromFile("Icons\\createnew.png");
        Image editIconImage = Image.FromFile("Icons\\change.png");

        Image expiryDateIcon = Image.FromFile("Icons\\Button\\2.BMP");
        Image deleteIcon = Image.FromFile("Icons\\Button\\2.BMP");
        Image passwordIcon = Image.FromFile("Icons\\Button\\2.BMP");
        Image changeGroupIcon = Image.FromFile("Icons\\Button\\2.BMP");

        bool _refreshGrid = false;

        public ucUserManagement(IUserCommandServices commandService, IPartQueryServices queryServices,
            IRoleCommandServices roleCommandService)
        {
            _commandService = commandService;
            _queryService = queryServices;
            InitializeComponent();
            _roleCommandService = roleCommandService;
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            // config grid view columns
            this.configGridView();

            // config form
            this.configForm();

            // load gridview data
            this.refreshData();
            uiCommon.IsImplementedUIPermision(this, nameof(MenuEnums.UserManagements));
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
            this.configGridViewCheckBoxColumn(this.mainGridView, "Active", "IsActive");
            this.configGridViewColumn(this.mainGridView, "Expiry Date", "ExpiryDate");
            this.configGridViewIconColumn(this.mainGridView, "", "ExpiryDateIcon");
            this.configGridViewIconColumn(this.mainGridView, "", "DeleteIcon");
            this.configGridViewColumn(this.mainGridView, "Name", "Name", false);
            this.configGridViewColumn(this.mainGridView, "First Name", "FirstName", false);
            this.configGridViewColumn(this.mainGridView, "Telephone", "Telephone", false);
            this.configGridViewColumn(this.mainGridView, "User Id", "UserID", false);
            this.configGridViewIconColumn(this.mainGridView, "Password", "PasswordIcon");
            this.configGridViewColumn(this.mainGridView, "User Group", "RoleName");
            this.configGridViewIconColumn(this.mainGridView, "", "ChangeGroupIcon");

            // register gridview event handler
            this.mainGridView.SelectionChanged += onGridViewSelectionChanged;
            this.mainGridView.CellEndEdit += onGridViewCellEndEdit;

            this.mainGridView.CellClick += onCellClick;
        }

        private void configForm()
        {
            this.txtName.KeyUp += onKeyUp;
            this.txtFirstName.KeyUp += onKeyUp;
            this.txtWinAccount01.KeyUp += onKeyUp;
            this.txtWinAccount02.KeyUp += onKeyUp;
            this.txtTelephone.KeyUp += onKeyUp;
            this.txtUserId.KeyUp += onKeyUp;

            this.chkActive.Click += onCheckBoxClick;
            this.chkLoginAllowed.Click += onCheckBoxClick;
            this.chkFingerDataAvailable.Click += onCheckBoxClick;

            this.txtRole.ReadOnly = true;
        }

        private void formDataToDto(UserDto dto)
        {
            dto.Name = this.txtName.Text;
            dto.FirstName = this.txtFirstName.Text;
            dto.WinAccount01 = this.txtWinAccount01.Text;
            dto.WinAccount02 = this.txtWinAccount02.Text;
            dto.LoginAllowed = this.chkLoginAllowed.Checked;
            dto.FingerDataAvailable = this.chkFingerDataAvailable.Checked;
            dto.IsActive = this.chkActive.Checked;

            dto.Telephone = this.txtTelephone.Text;
            dto.UserID = this.txtUserId.Text;
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
            //if (sender is System.Windows.Forms.CheckBox checkBox)
            //{
            //    checkBox.Checked = !checkBox.Checked;
            //}

            if (sender is System.Windows.Forms.CheckBox checkBox)
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

        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx == 9 && this.mainGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                // change password
                //MessageBox.Show($"on click on select winding param {this._selectedRowIdx}");
                this.showInputDataDiaglog(new UserDto()
                {
                    IsUpdatePassword = true,
                });
            }
            if (columnIdx == 11 && this.mainGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                // change group
                //MessageBox.Show($"on click on select winding param {this._selectedRowIdx}");
                this.showInputDataDiaglog(new UserDto()
                {
                    IsUpdateGroup = true,
                });
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
            this.refreshRole();

            var result = await _commandService.ListAllAsync();
            var dbData = (List<UserDto>)result;

            // debug code begin
            //MessageBox.Show($"refreshData:: dbData:: {dbData.Count}");
            // debug code end

            // debug code begin
            //var groups = mocGroupsData();

            //this._groups = groups;

            //var mockData = this.mockData(groups);

            //this._data.Clear();
            //this._data.AddRange(mockData);
            // debug code end
            this._data = dbData;

            if (dbData.Count == 0)
            {
                this.InitDataAsync();
            }
            this.reloadGridView();
        }
        private async void refreshRole()
        {
            var result = await _roleCommandService.ListAllAsync();
            var dbData = (List<RoleDto>)result;
            this._roles = dbData;
        }

        private async Task InitDataAsync()
        {
            var encryptKey = ConfigurationManager.AppSettings["EncryptionKey"];
            var encryptIV = ConfigurationManager.AppSettings["EncryptionIV"];
            var rs = await _commandService.CreateBulk(new List<UserDto>()
            {
                 new UserDto(){IsActive = true,Name="User 01", FirstName="First Name 01", Telephone="Telephone 01", UserID="user01", Password= EncryptUtility.EncryptString("password01", encryptKey, encryptIV), WinAccount01="WinAccount01", WinAccount02="WinAccount01", LoginAllowed=true, FingerDataAvailable=true},
                 new UserDto(){IsActive = true,Name="User 02", FirstName="First Name 02", Telephone="Telephone 02", UserID="user02", Password= EncryptUtility.EncryptString("password02", encryptKey, encryptIV), WinAccount01="WinAccount02", WinAccount02="WinAccount02", LoginAllowed=true, FingerDataAvailable=true},
                 new UserDto(){IsActive = true,Name="User 03", FirstName="First Name 03", Telephone="Telephone 03", UserID="user03", Password= EncryptUtility.EncryptString("password03", encryptKey, encryptIV), WinAccount01="WinAccount03", WinAccount02="WinAccount03", LoginAllowed=true, FingerDataAvailable=true},
                 new UserDto(){IsActive = true,Name="User 04", FirstName="First Name 04", Telephone="Telephone 04", UserID="user04", Password= EncryptUtility.EncryptString("password04", encryptKey, encryptIV), WinAccount01="WinAccount04", WinAccount02="WinAccount04", LoginAllowed=true, FingerDataAvailable=true},
                 new UserDto(){IsActive = true,Name="User 05", FirstName="First Name 05", Telephone="Telephone 05", UserID="user05", Password= EncryptUtility.EncryptString("password05", encryptKey, encryptIV), WinAccount01="WinAccount05", WinAccount02="WinAccount05", LoginAllowed=true, FingerDataAvailable=true},
                 new UserDto(){IsActive = true,Name="User 06", FirstName="First Name 06", Telephone="Telephone 06", UserID="user06", Password= EncryptUtility.EncryptString("password06", encryptKey, encryptIV), WinAccount01="WinAccount06", WinAccount02="WinAccount06", LoginAllowed=true, FingerDataAvailable=true},
                 new UserDto(){IsActive = true,Name="User 07", FirstName="First Name 07", Telephone="Telephone 07", UserID="user07", Password= EncryptUtility.EncryptString("password07", encryptKey, encryptIV), WinAccount01="WinAccount07", WinAccount02="WinAccount07", LoginAllowed=true, FingerDataAvailable=true},
                 new UserDto(){IsActive = true,Name="User 08", FirstName="First Name 08", Telephone="Telephone 08", UserID="user08", Password= EncryptUtility.EncryptString("password08", encryptKey, encryptIV), WinAccount01="WinAccount08", WinAccount02="WinAccount08", LoginAllowed=true, FingerDataAvailable=true},
                 new UserDto(){IsActive = true,Name="User 09", FirstName="First Name 09", Telephone="Telephone 09", UserID="user09", Password= EncryptUtility.EncryptString("password09", encryptKey, encryptIV), WinAccount01="WinAccount09", WinAccount02="WinAccount09", LoginAllowed=true, FingerDataAvailable=true},
            });
            if (rs)
            {
                this._data = await _commandService.ListAllAsync();
                await Console.Out.WriteLineAsync();
            }
        }

        private async Task<UserDto> getById(long id)
        {
            return await _commandService.GetById(id);
        }

        private void reloadGridView()
        {
            this.updateDataSource();

            // config datasource
            this.mainGridView.DataSource = null;
            this.mainGridView.DataSource = this._data;
            this.mainGridView.Refresh();
        }

        private RoleDto mapRole(int roleId)
        {
            RoleDto ret = null;
            for (int i = 0; i < this._roles.Count; i++)
            {
                RoleDto role = this._roles[i];
                if (role.ID == roleId)
                {
                    ret = role;
                    break;
                }
            }
            return ret;
        }

        private void updateDataSource()
        {
            var defaultIcon = new Bitmap(1, 1);
            foreach (UserDto dto in this._data)
            {
                RoleDto roleDto = this.mapRole(dto.RoleID);
                dto.role = roleDto;

                dto.updateRole();
                dto.ExpiryDateIcon = this.expiryDateIcon;
                dto.DeleteIcon = this.deleteIcon;
                dto.PasswordIcon = this.passwordIcon;
                dto.ChangeGroupIcon = this.changeGroupIcon;

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

        private void updateFormData(UserDto model)
        {
            if (model != null)
            {
                this.txtName.Text = model.Name;
                this.txtFirstName.Text = model.FirstName;
                this.txtWinAccount01.Text = model.WinAccount01;
                this.txtWinAccount02.Text = model.WinAccount02;

                this.chkLoginAllowed.Checked = model.LoginAllowed;
                this.chkFingerDataAvailable.Checked = model.FingerDataAvailable;

                this.chkActive.Checked = model.IsActive;

                this.txtTelephone.Text = model.Telephone;
                this.txtUserId.Text = model.UserID;

                var role = model.role;
                string roleName = "";

                if (role != null)
                {
                    roleName = role.Name;
                }
                this.txtRole.Text = roleName;
            }
        }

        private UserDto getCurrentRowData()
        {
            UserDto ret = null;
            if (_selectedRowIdx != -1)
            {
                ret = this._data[_selectedRowIdx];
            }
            return ret;
        }

        // used when click button save
        private UserDto getFormData()
        {
            UserDto ret = new UserDto();
            String name = this.txtName.Text;
            String firstName = this.txtFirstName.Text;
            bool active = this.chkActive.Checked;
            String telephone = this.txtTelephone.Text;
            String userId = this.txtUserId.Text;

            ret.Name = name;
            ret.FirstName = firstName;
            ret.IsActive = active;
            ret.Telephone = telephone;
            ret.UserID = userId;

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

                // MessageBox.Show($"onGridViewSelectionChanged: {selectedRow.Index} - {selectedRow.Selected} - grid count:: {this.mainGridView.Rows.Count}");
                if (selectedRow != null && selectedRow.Selected)
                {
                    this._selectedRowIdx = selectedRow.Index;
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

        private Boolean validateForm(UserDto dto)
        {
            Boolean ret = true;
            if (string.IsNullOrEmpty(dto.Name.Trim()))
            {
                UIUtility.AppShowMsg("Name value should be not empty.", UIConstants.MSGBOX_ICON_ERROR_STYLE);
                ret = false;
            }

            if (string.IsNullOrEmpty(dto.FirstName.Trim()))
            {
                UIUtility.AppShowMsg("First Name value should be not empty.", UIConstants.MSGBOX_ICON_ERROR_STYLE);
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

                //dto.Password = currentRowData.Password;

                //var group = currentRowData.userGroup;
                //MessageBox.Show($"handleSave: ID:: {currentRowData.ID} - Name:: {dto.Name} - FirstName:: {dto.FirstName} - Active:: {dto.Active} - Telephone:: {dto.Telephone} - UserId:: {dto.UserID} - Password:: {dto.Password}" +
                //    $" -  group.id {group.ID} - group.name {group.Name}");

                var insertList = new List<UserDto>();
                var updateList = new List<UserDto>();
                foreach (UserDto item in this._data)
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

        private void handleDataCallback(UserDto dto)
        {
            dto.role = this._roles[dto.RoleIdx];
            if (dto.IsAdd)
            {
                dto.updateRole(this._roles[dto.RoleIdx]);
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
                    if (dto.IsUpdatePassword)
                    {
                        updatedData.Password = dto.Password;
                    }
                    if (dto.IsUpdateGroup)
                    {
                        //updatedData.role = this._roles[dto.RoleIdx];
                        updatedData.updateRole(this._roles[dto.RoleIdx]);
                    }

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

            var dto = new UserDto()
            {
                IsAdd = true,
            };
            showInputDataDiaglog(dto);
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            var dto = new UserDto()
            {
                IsUpdatePassword = true,
            };
            showInputDataDiaglog(dto);
        }

        private void btnChangeGroup_Click(object sender, EventArgs e)
        {
            var dto = new UserDto()
            {
                IsUpdateGroup = true,
            };
            showInputDataDiaglog(dto);
        }

        private List<InputDataStep> getInsertSteps()
        {
            List<InputDataStep> steps = new List<InputDataStep>();
            steps.Add(new InputDataStep
            {
                PropertyName = "Name",
                ControllType = EInputDataType.TEXTBOX
            });
            steps.Add(new InputDataStep
            {
                PropertyName = "FirstName",
                ControllType = EInputDataType.TEXTBOX
            });
            steps.Add(new InputDataStep
            {
                PropertyName = "UserID",
                ControllType = EInputDataType.TEXTBOX
            });
            steps.Add(new InputDataStep
            {
                PropertyName = "Password",
                ControllType = EInputDataType.TEXTBOX
            });
            steps.Add(new InputDataStep
            {
                PropertyName = "Group",
                ControllType = EInputDataType.DATAGRIDVIEW,
                ExtraData = this._roles
            });
            return steps;
        }

        private void showInputDataDiaglog(UserDto dto)
        {
            var steps = this.getInsertSteps();
            if (dto.IsUpdatePassword)
            {
                steps = new List<InputDataStep>() { steps[3] };
            }
            if (dto.IsUpdateGroup)
            {
                steps = new List<InputDataStep>() { steps[4] };
            }

            InputDataForm inputDataForm = new InputDataForm(steps, dto,
                EInputDataForm.USERS, validationAction);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
        }

        private void validationAction()
        {
            Console.WriteLine("validated");
        }

        private void OnClosingDataInputForm(Object inputObject, string status)
        {
            var dto = (UserDto)inputObject;
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
        //private List<UserDto> mockData(List<UserGroupDto> groups)
        //{
        //    var ret = new List<UserDto>();

        //    for (int i = 1; i <= 20; i++)
        //    {
        //        var dto = new UserDto();
        //        dto.ID = i;

        //        dto.IsActive = i % 2 == 0;

        //        dto.ExpiryDate = DateTime.Now;
        //        dto.Name = "Name " + i;
        //        dto.FirstName = "FirstName " + i;

        //        dto.LoginAllowed = i % 2 == 0;
        //        dto.FingerDataAvailable = i % 2 != 0;

        //        dto.Telephone = "Telephone " + i;
        //        dto.UserID = "UserID " + i;
        //        ret.Add(dto);
        //    }

        //    ret[0].userGroup = groups[0];
        //    ret[1].userGroup = groups[1];
        //    ret[2].userGroup = groups[2];

        //    return ret;
        //}

        private List<UserGroupDto> mocGroupsData()
        {
            var ret = new List<UserGroupDto>();
            ret.Add(new UserGroupDto()
            {
                ID = 1,
                Name = "Administrator",
                Description = "all permissions",
            });
            ret.Add(new UserGroupDto()
            {
                ID = 2,
                Name = "Power User",
                Description = "sewing: extended...",
            });
            ret.Add(new UserGroupDto()
            {
                ID = 3,
                Name = "Sewing User",
                Description = "sewing",
            });
            ret.Add(new UserGroupDto()
            {
                ID = 3,
                Name = "Technician",
                Description = "sewing: standard sewing",
            });
            return ret;
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
                    List<UserDto> exportData = new List<UserDto>();
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

                List<UserDto> rs = this.ImportBulk(_data, selectedFilePath);
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
        public void ExportBulk(List<UserDto> dtos, string filePath)
        {

            // Create a new Excel package
            using (var workbook = new XLWorkbook())
            {
                // Get the default worksheet
                var worksheet = workbook.Worksheets.Add("Sheet1");

                worksheet.Range(GetCellAddress(1, 1)).Value = "h1";
                worksheet.Range(GetCellAddress(1, 2)).Value = "Name";
                worksheet.Range(GetCellAddress(1, 3)).Value = "User Id";

                int row = 2;
                foreach (var dataItem in dtos)
                {
                    worksheet.Range(GetCellAddress(row, 1)).Value = "r";
                    worksheet.Range(GetCellAddress(row, 2)).Value = dataItem.Name;
                    worksheet.Range(GetCellAddress(row, 3)).Value = dataItem.UserID;

                    row++;
                }

                for (int i = 1; i < 100; i++)
                {
                    worksheet.Column(i).AdjustToContents();
                }
                workbook.SaveAs(filePath);
            }
        }
        public List<UserDto> ImportBulk(List<UserDto> incomingDtos, string filePath)
        {
            var dtos = new List<UserDto>();
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
                            UserDto dataItem = incomingDtos.FirstOrDefault(dataItem => dataItem.UserID == worksheet.Cell(GetCellAddress(row, 3)).Value.ToString());
                            if (dataItem == null)
                            {
                                dataItem = new UserDto();
                            }
                            else
                            {
                                continue;
                            }
                            dataItem.Name = worksheet.Cell(GetCellAddress(row, 2)).Value.ToString();
                            dataItem.UserID = worksheet.Cell(GetCellAddress(row, 3)).Value.ToString();
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
