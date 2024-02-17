using Clean.Win.AppUI.Forms;
using Clean.Win.AppUI.UICommon;
using Clean.Win.AppUI.UICommon.Entities;
using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Common.Enum;
using Clean.WinF.Shared.Constants;
using Clean.WinF.Shared.ErrorMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls.Users
{
    public partial class ucUserGroups : UserControl
    {

        private readonly IPermissionCommandServices _permissionCommandService;
        private readonly IRoleCommandServices _roleCommandService;
        private readonly IUserGroupQueryServices _userGroupQueryService;
        private readonly IUserGroupCommandServices _userGroupCommandService;


        private readonly UICommon.UICommon uiCommon = UICommon.UICommon.Instance;


        List<RoleDto> _roleData = new List<RoleDto>();
        List<PermissionDto> _permissionData = new List<PermissionDto>();
        List<UserGroupDto> _data = new List<UserGroupDto>();

        private int _selectedRowIdxRole = -1;
        private int _selectedRowIdxPermission = -1;
        bool _refreshGrid = false;

        public ucUserGroups(
            IUserGroupCommandServices userGroupCommandService,
            IUserGroupQueryServices userGroupQueryService,
            IPermissionCommandServices permissionCommandService,
            IRoleCommandServices roleCommandService)
        {
            _userGroupCommandService = userGroupCommandService;
            _userGroupQueryService = userGroupQueryService;
            _permissionCommandService = permissionCommandService;
            _roleCommandService = roleCommandService;
            InitializeComponent();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            // config grid view columns
            this.configGridViewRole();
            this.configGridViewUserPermission();

            this.InitDataAsync();
            this.configForm();

            // load gridview data
            this.refreshRole();
            this.refreshUserPermission();
            uiCommon.IsImplementedUIPermision(this, nameof(MenuEnums.UserGroups));
        }

        private void configForm()
        {
            this.txtUserGroup.KeyUp += onKeyUp;
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox)
            {
                var dto = this.getCurrentRowDataRole();
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

        private void formDataToDto(RoleDto dto)
        {
            dto.Name = this.txtUserGroup.Text;
        }


        private async void refreshRole()
        {
            var result = await _roleCommandService.ListAllAsync();
            var dbData = (List<RoleDto>)result;
            this._roleData = dbData;

            this.reloadRoleGridView();
        }

        private async void refreshUserPermission()
        {
            var Roledto = new RoleDto();
            Roledto = this.getCurrentRowDataRole();
            var result = await _userGroupCommandService.GetAllById(Roledto.ID);
            var dbDataUserGroup = (List<UserGroupDto>)result;
            this._data = dbDataUserGroup;

            MapUserGroupDataToPermissionNames();
            this.reloadUserPermissionGridView();
        }

        private void updateFormData(RoleDto model)
        {
            if (model != null)
            {
                this.txtUserGroup.Text = model.Name;
            }
        }


        private void reloadUserPermissionGridView()
        {
            this.userPermissionsGridView.DataSource = null;
            this.userPermissionsGridView.DataSource = this._data;
            this.userPermissionsGridView.Refresh();
        }

        private void configGridViewColumn(DataGridView dataGridView, string header, string propertyName, bool useMapping = false)
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = propertyName;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns.Add(column);
        }


        private void configGridViewRole()
        {
            this.userGroupGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.userGroupGridView.ScrollBars = ScrollBars.Both;
            this.userGroupGridView.AutoGenerateColumns = false;
            this.userGroupGridView.MultiSelect = false;

            // config gridview display columns
            this.configGridViewColumn(this.userGroupGridView, "User Group", "Name");
            this.configGridViewColumn(this.userGroupGridView, "Description", "Description");

            // register gridview event handler
            this.userGroupGridView.SelectionChanged += onGridViewSelectionChangedRole;
            this.userGroupGridView.CellEndEdit += onRoleGridViewCellEndEdit;
            this.userGroupGridView.CellClick += onCellClickRole;
        }

        private async Task InitDataAsync()
        {
            _roleData = await this._roleCommandService.ListAllAsync();
            if (_roleData.Count == 0)
            {
                var rs = await _roleCommandService.CreateBulk(new List<RoleDto>()
                {
                     new RoleDto(){IsActive = true,Name="Administrator", Description="all permission"},
                     new RoleDto(){IsActive = true,Name="Power User", Description="sewing: extended Biasysontrol and BiasysDb permissions"},
                     new RoleDto(){IsActive = true,Name="Sewing User", Description="sewing"},
                     new RoleDto(){IsActive = true,Name="Sewing", Description="sewing: standard sewing"},
                });
                if (rs)
                {
                    _roleData = await this._roleCommandService.ListAllAsync();
                }
            }
            _permissionData = await _permissionCommandService.GetAllsActive();
            if (_permissionData.Count == 0)
            {
                var rs = await _permissionCommandService.CreateBulk(new List<PermissionDto>()
                {
                     new PermissionDto(){IsActive = true,Name="BiasysControl: sewing", Code="SEWING"},
                     new PermissionDto(){IsActive = true,Name="BiasysControl: reprint end label", Code="REPRINT_END_LABEL"},
                     new PermissionDto(){IsActive = true,Name="BiasysControl: continue sewing when stitches out of tolerance", Code="SEWING_ON_ERROR"},
                     new PermissionDto(){IsActive = true,Name="BiasysControl: debug automat", Code="DEBUG_AUTOMAT"},
                     new PermissionDto(){IsActive = true,Code="STANDARD_SEWING",Name ="BiasysControl: standard sewing / unclock sewing machine"},
                     new PermissionDto(){IsActive = true,Code="RESCAN_END_LABEL",Name ="BiasysControl: Rescan Part Label"},
                     new PermissionDto(){IsActive = true,Code="NEW_NEEDLE",Name ="BiasysControl: New Needle"},
                     new PermissionDto(){IsActive = true,Code="CONFIRM_VALID_SEAM",Name ="BiasysControl: Confirm valid seam on too few ETM measurements"},
                     new PermissionDto(){IsActive = true,Code="CONFIRM_ETM_ADJUSTED",Name ="BiasysControl: Confirm that the ETM has been adjusted"},
                     new PermissionDto(){IsActive = true,Code="EXECUTED_BACKUP",Name ="Execute Backup Application: Stetting not editable"},
                     new PermissionDto(){IsActive = false,Code="SETTING_EDITABLE",Name ="BiasysControl: execute backup; setting editable"},
                     new PermissionDto(){IsActive = true,Code="USER_MANAGEMENT",Name ="BiasysDB: Form [User Management]"},
                     new PermissionDto(){IsActive = true,Code="USER_GROUP",Name ="BiasysDB: Form [User Group]"},
                     new PermissionDto(){IsActive = true,Code="ADMINISTRATOR_ACTION",Name ="BiasysDB: Form [User management] -> admin actions(Reset password, ..)"},
                     new PermissionDto(){IsActive = true,Code="SET_USER_IMAGE_EXPIRY_DATE",Name ="BiasysDB: User management -> Set user Image ad Expiry Date"},
                     new PermissionDto(){IsActive = true,Code="MATERIAL_THREADS",Name ="BiasysDB: Form [Material Threads]"},
                     new PermissionDto(){IsActive = true,Code="SUPPLIER",Name ="BiasysDB: Form [Suppliers]"},
                     new PermissionDto(){IsActive = true,Code="STOCK_THREADS",Name ="BiasysDB: Form [Stock Threads]"},
                     new PermissionDto(){IsActive = true,Code="ARTICLE_GROUP",Name ="BiasysDB: Form [Article Group]"},
                     new PermissionDto(){IsActive = true,Code="ARTICLE_GROUP_PRINT_LABEL",Name ="BiasysDB: Article Group -> Print Label"},
                     new PermissionDto(){IsActive = true,Code="FORM_ORDERS",Name ="BiasysDB: Form [Order]"},
                     new PermissionDto(){IsActive = true,Code="FORM_PRODUCTION_DATA",Name ="BiasysDB: Form [Production Data]"},
                     new PermissionDto(){IsActive = true,Code="ARTICLE_LABEL_SCANNED_IN_BIASYSCONTROL",Name ="BiasysDB: Article label scanned in BiasysControl"},
                     new PermissionDto(){IsActive = true,Code="PC_SYSTEM_SETTINGS",Name ="BiasysDB: Form [PC System Settings]"},
                     new PermissionDto(){IsActive = true,Code="SEWING_MACHINE_SETTING",Name ="BiasysDB: Form [Sewing Machine Settings]"},
                     new PermissionDto(){IsActive = true,Code="MATERIAL_FABRICS",Name ="BiasysDB: Form [Material Fabrics]"},
                     new PermissionDto(){IsActive = true,Code="STOCK_FABRICS",Name ="BiasysDB: Form [Stock Fabrics]"},
                     new PermissionDto(){IsActive = true,Code="PRODUCTION_DATA_ADD_REPRINT_END_LABEL",Name ="BiasysDB: Form [Production Data] -> reprint end label"},
                     new PermissionDto(){IsActive = true,Code="EXEL_EXPORT_MISC",Name ="BiasysDB: Excel Export Misc . (Article, Thread, ...)"},
                     new PermissionDto(){IsActive = true,Code="PRODUCTION_DATA_ADD_COMMENT_PROTOCOL",Name ="BiasysDB: Form [Production Data] -> add comments to protocols"},
                     new PermissionDto(){IsActive = true,Code="EDIT_AUTOMAT",Name ="BiasysDB: Edit automat parameter"},
                     new PermissionDto(){IsActive = true,Code="EDIT_AUTOMAT_PARAMETER",Name ="BiasysDB: Bobbin"},
                     new PermissionDto(){IsActive = true,Code="BIASYSDB_BIASYSCONTROL_CHECK_SYSTEM_DATE",Name ="BiasysDB/BiasysControl: Check system date"},
                });
                if (rs)
                {
                    _permissionData = await _permissionCommandService.GetAllsActive();
                    await Console.Out.WriteLineAsync();
                }
            }
            _data = await this._userGroupCommandService.ListAllAsync();
            if (_data.Count == 0)
            {
                var userGroupDtos = new List<UserGroupDto>();

                foreach (var roleDto in _roleData)
                {
                    foreach (var permissionDto in _permissionData)
                    {
                        var userGroupDto = new UserGroupDto
                        {
                            Name = permissionDto.Name,
                            RoleID = roleDto.ID,
                            PermissionID = permissionDto.ID,
                            IsRead = false,
                            IsInsert = false,
                            IsDelete = false,
                            IsExecute = false,
                            IsActive = true,
                        };

                        userGroupDtos.Add(userGroupDto);
                    }
                }

                var rs = await _userGroupCommandService.CreateBulk(userGroupDtos);
                if (rs)
                {
                    _data = await this._userGroupCommandService.ListAllAsync();
                }
            }

        }

        private void onRoleGridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex;
            //int columnIndex = e.ColumnIndex;
            //var dto = this._data[rowIndex];
            //dto.IsEdit = true;
            var dto = this.getCurrentRowDataRole();
            if (dto != null && !dto.IsAdd)
            {
                dto.IsEdit = true;
                //this.reloadGridView();
            }
            this._refreshGrid = true;
        }

        private void onCellClickRole(object sender, DataGridViewCellEventArgs e)
        {
            int columnIdx = e.ColumnIndex;
            if (columnIdx == 6 && this.userGroupGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                this.showInputDataDiaglog(false);
            }
            if (columnIdx == 0 && this.userGroupGridView.Columns[columnIdx] is DataGridViewImageColumn)
            {
                var selectedData = this._roleData[this._selectedRowIdxRole];
                if (selectedData != null && selectedData.IsEdit)
                {
                    var originalData = this.getRoleByIdAsync(selectedData.ID);
                    if (originalData != null)
                    {
                        this._roleData[this._selectedRowIdxRole] = originalData.Result;
                        this.reloadRoleGridView();
                        this.fromDtoToForm(originalData.Result);
                    }
                }
            }
        }
        private void fromDtoToForm(RoleDto dto)
        {
            this.txtUserGroup.Text = dto.Name;
        }

        private async Task<RoleDto> getRoleByIdAsync(long id)
        {
            return await _roleCommandService.GetById(id);
        }


        private void configGridViewUserPermission()
        {
            this.userPermissionsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.userPermissionsGridView.ScrollBars = ScrollBars.Both;
            this.userPermissionsGridView.AutoGenerateColumns = false;
            this.userPermissionsGridView.MultiSelect = false;

            // Config gridview display columns
            this.configGridViewColumn(this.userPermissionsGridView, "Permission", "Name");

            // Config checkboxes for permissions
            this.configGridViewCheckboxColumn(this.userPermissionsGridView, "Read", "IsRead");
            this.configGridViewCheckboxColumn(this.userPermissionsGridView, "Insert", "IsInsert");
            this.configGridViewCheckboxColumn(this.userPermissionsGridView, "Delete", "IsDelete");
            this.configGridViewCheckboxColumn(this.userPermissionsGridView, "Execute", "IsExecute");
            this.userPermissionsGridView.CellClick += onCellClickUserPermission;
        }

        private void onCellClickUserPermission(object sender, DataGridViewCellEventArgs e)
        {

            int columnIdx = e.ColumnIndex;
            this._selectedRowIdxPermission = e.RowIndex;

            if (columnIdx >= 1 && columnIdx <= 4)
            {
                var selectedData = this.getCurrentRowDataUserPermission();

                if (selectedData != null)
                {

                    string columnName = this.userPermissionsGridView.Columns[columnIdx].HeaderText;
                    bool currentValue = (bool)this.userPermissionsGridView.Rows[e.RowIndex].Cells[columnIdx].Value;

                    selectedData.IsEdit = true;

                    switch (columnName)
                    {
                        case "Read":
                            selectedData.IsRead = !currentValue;
                            break;
                        case "Insert":
                            selectedData.IsInsert = !currentValue;
                            break;
                        case "Delete":
                            selectedData.IsDelete = !currentValue;
                            break;
                        case "Execute":
                            selectedData.IsExecute = !currentValue;
                            break;
                    }

                    this._refreshGrid = true;
                }
            }
        }

        private void configGridViewCheckboxColumn(DataGridView dataGridView, string header, string property)
        {
            var column = new DataGridViewCheckBoxColumn();
            column.HeaderText = header;
            column.DataPropertyName = property;
            dataGridView.Columns.Add(column);

            // Customize cell style
            column.DefaultCellStyle.NullValue = false;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Optional: center-align the checkboxes
            column.DefaultCellStyle.Padding = new Padding(0, 0, 0, 0); // Optional: remove padding
        }


        private void onGridViewSelectionChangedRole(object sender, EventArgs e)
        {
            if (this._refreshGrid)
            {
                this._refreshGrid = false;
                this.reloadRoleGridView();
            }

            var targetGridView = sender as DataGridView;
            if (targetGridView.SelectedRows.Count > 0)
            {
                var selectedRow = targetGridView.SelectedRows[0];

                if (selectedRow != null && selectedRow.Selected)
                {
                    this._selectedRowIdxRole = selectedRow.Index;
                    this.onRowChangeRole(selectedRow);
                }
            }
        }


        private void reloadRoleGridView()
        {
            // config datasource
            this.userGroupGridView.DataSource = null;
            this.userGroupGridView.DataSource = this._roleData;
            this.userGroupGridView.Refresh();
        }

        private async void onRowChangeRole(DataGridViewRow selectedRow)
        {
            if (selectedRow != null && selectedRow.Selected)
            {
                this._selectedRowIdxRole = selectedRow.Index;
                RoleDto roleDto = this.getCurrentRowDataRole();
                this.updateFormData(roleDto);

                if (roleDto != null)
                {
                    var result = await _userGroupCommandService.GetAllById(roleDto.ID);
                    var dbData = (List<UserGroupDto>)result;

                    if (dbData.Count == 0)
                    {
                        var userGroupDtos = new List<UserGroupDto>();
                        foreach (var permissionDto in _permissionData)
                        {
                            var userGroupDto = new UserGroupDto
                            {
                                Name = permissionDto.Name,
                                RoleID = roleDto.ID,
                                PermissionID = permissionDto.ID,
                                IsRead = false,
                                IsInsert = false,
                                IsDelete = false,
                                IsExecute = false,
                                IsActive = true,
                                IsAdd = true,
                            };
                            userGroupDtos.Add(userGroupDto);
                        }
                        this._data = userGroupDtos;
                    }
                    else
                    {
                        this._data = dbData;
                    }
                    MapUserGroupDataToPermissionNames();
                    this.reloadUserPermissionGridView();
                }
            }
        }

        private void MapUserGroupDataToPermissionNames()
        {
            foreach (var userGroup in _data)
            {
                // Tìm phần tử Permission tương ứng trong _permissionData
                var correspondingPermission = _permissionData.FirstOrDefault(p => p.ID == userGroup.PermissionID);

                // Nếu tìm thấy Permission tương ứng, cập nhật Name của userGroup
                if (correspondingPermission != null)
                {
                    userGroup.Name = correspondingPermission.Name;
                }
            }
        }
        private RoleDto getCurrentRowDataRole()
        {
            RoleDto ret = null;
            if (_selectedRowIdxRole != -1)
            {
                ret = this._roleData[_selectedRowIdxRole];
            }
            return ret;
        }

        private void validationAction()
        {
            Console.WriteLine("validated");
        }

        private UserGroupDto getCurrentRowDataUserPermission()
        {
            UserGroupDto ret = null;
            if (_selectedRowIdxPermission != -1)
            {
                ret = this._data[_selectedRowIdxPermission];
            }
            return ret;
        }
        private List<InputDataStep> getInsertSteps()
        {
            List<InputDataStep> steps = new List<InputDataStep>();
            steps.Add(new InputDataStep
            {
                PropertyName = "Name",
                ControllType = EInputDataType.TEXTBOX
            });
            return steps;
        }
        private void showInputDataDiaglog(bool isAdd)
        {
            var dto = new RoleDto();
            dto.IsAdd = isAdd;

            var steps = this.getInsertSteps();
            if (!dto.IsAdd)
            {
                // update step
                steps = new List<InputDataStep>() { steps[2] };
            }

            _roleData.Add(dto);
            reloadRoleGridView();
            _selectedRowIdxRole = _roleData.Count - 1;
            //this.drgArticle.Rows[_selectedRowIdx].Selected = true;
            this.userGroupGridView.CurrentCell = this.userGroupGridView.Rows[_selectedRowIdxRole].Cells[0];
            this.onRowChangeRole(userGroupGridView.Rows[_selectedRowIdxRole]);
            InputDataForm inputDataForm = new InputDataForm(steps, dto,
                EInputDataForm.USERGROUPS, validationAction);
            inputDataForm.OnFormClose += OnClosingDataInputForm;
            inputDataForm.ShowDialog();
        }
        private void OnClosingDataInputForm(Object inputObject, string status)
        {
            var roleDto = (RoleDto)inputObject;
            long maxId = 0;
            if (_roleData.Count > 0)
            {
                maxId = _roleData.Max(r => r.ID);
            }
            roleDto.ID = maxId + 1;
            //roleDto.IsAdd = false;
            roleDto.IsActive = true;

            switch (status)
            {
                case CommonConstant.InputDataFinished:
                    this.handleDataCallbackRole(roleDto);
                    this.userGroupGridView.CurrentCell = this.userGroupGridView.Rows[_selectedRowIdxRole].Cells[0];
                    this.onRowChangeRole(userGroupGridView.Rows[_selectedRowIdxRole]);
                    break;
                default:
                    //close form
                    _selectedRowIdxRole = 0;
                    roleDto = (RoleDto)inputObject;
                    if (roleDto.ID == 0)
                    {
                        _roleData.RemoveAt(_data.Count - 1);

                    }
                    reloadRoleGridView();
                    reloadUserPermissionGridView();
                    break;
            }
        }
        private void handleDataCallbackRole(RoleDto dto)
        {

            if (dto.IsAdd)
            {
                // add to beginning
                //this._data.Insert(0, dto);

                // add to the end
                //this._roleData.Add(dto);

                int selectedRow = this._roleData.Count - 1;

                this.reloadRoleGridView();

                this.userGroupGridView.Rows[selectedRow].Selected = true;
                this.onRowChangeRole(userGroupGridView.Rows[selectedRow]);
            }
            else
            {
                var updatedData = this.getCurrentRowDataRole();
                if (updatedData != null)
                {

                    if (!updatedData.IsAdd)
                    {
                        updatedData.IsEdit = true;
                        this._refreshGrid = true;
                    }
                    this.reloadRoleGridView();

                    this.userGroupGridView.Rows[this._selectedRowIdxRole].Selected = true;
                    this.onRowChangeRole(userGroupGridView.Rows[this._selectedRowIdxRole]);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            showInputDataDiaglog(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.handleSaveRole();
            this.handleSavePermission();
            UIUtility.AppShowMsg(CustomErrorMessage.APP_USER_UPDATED_SUCCESS);
        }

        private RoleDto getFormData()
        {
            RoleDto ret = new RoleDto();

            String name = this.txtUserGroup.Text;
            ret.Name = name;

            return ret;
        }

        private Boolean validateForm(RoleDto dto)
        {
            Boolean ret = true;
            if (string.IsNullOrEmpty(dto.Name.Trim()))
            {
                UIUtility.AppShowMsg("Name value should be not empty.", UIConstants.MSGBOX_ICON_ERROR_STYLE);
                ret = false;
            }
            return ret;
        }

        private async void handleSaveRole()
        {
            // get form data
            var dto = this.getFormData();

            // validation
            var validated = this.validateForm(dto);

            if (validated)
            {
                // check add or update event

                var insertList = new List<RoleDto>();
                var updateList = new List<RoleDto>();
                foreach (RoleDto item in this._roleData)
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
                    await _roleCommandService.CreateBulk(insertList);
                }
                if (updateList.Count > 0)
                {
                    // update
                    await _roleCommandService.UpdateBulk(updateList);
                }
                //MessageBox.Show($"handleSave: insertList:: count:: {insertList.Count} \n updateList:: count:: {updateList.Count}");
            }
        }

        private async void handleSavePermission()
        {
            // get form data
            //var dto = this.getFormData();

            // validation
            //var validated = this.validateForm(dto);
            var validated = true;

            if (validated)
            {
                // check add or update event

                var insertList = new List<UserGroupDto>();
                var updateList = new List<UserGroupDto>();
                foreach (UserGroupDto item in this._data)
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
                    await _userGroupCommandService.CreateBulk(insertList);
                }
                if (updateList.Count > 0)
                {
                    // update
                    await _userGroupCommandService.UpdateBulk(updateList);
                }
                //MessageBox.Show($"handleSave: insertList:: count:: {insertList.Count} \n updateList:: count:: {updateList.Count}");
            }
            refreshRole();
            refreshUserPermission();
        }

        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            refreshRole();
            refreshUserPermission();
        }
    }
}
