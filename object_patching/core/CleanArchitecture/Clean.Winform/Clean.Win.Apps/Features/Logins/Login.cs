using Clean.Win.Apps;
using Clean.Win.AppUI.UICommon;
using Clean.WinF.Applications.Features.SystemConfiguration.Constants;
using Clean.WinF.Applications.Features.SystemConfiguration.DTOs;
using Clean.WinF.Applications.Features.UIProfile;
using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Features.Logins
{
    public partial class LoginForm : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        public bool isTimeout = false;
        private readonly Clean.Win.AppUI.UICommon.UICommon uiCommon = Clean.Win.AppUI.UICommon.UICommon.Instance;
        public LoginForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_0_Icon);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UIUtility.userLogin))
                Application.Exit();
            else
                this.Close();
        }

        private void DoClosingForm()
        {
            OnFormClose.Invoke(this);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UIUtility.uiProfiles.Count > 0)
                UIUtility.uiProfiles.Clear();

            //tmp comment out when db's empty 
            //bool result = this.doLogin(this.txtUserID.Text.Trim(), this.txtPassword.Text.Trim());
            //if (!result)
            //{
            //    // show error message
            //    return;
            //}
            this.doLogin(this.txtUserID.Text.Trim(), this.txtPassword.Text.Trim());

            UIUtility.userLogin = txtUserID.Text.Trim();
            _mainForm.btnLogin.Text = "Log out";
            if (!_mainForm.timerNow.Enabled)
            {
                _mainForm.timerNow.Enabled = true;
                _mainForm.timerNow.Start();
            }

            GetAvailableUIPermissionTopMenu(UIUtility.uiProfiles);

            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = true;
            this.txtUserID.Focus();
            InitializeLanguages();
            if (isTimeout)
            {
                _mainForm.timerNow.Enabled = false;
                _mainForm.timerNow.Stop();
                this.btnCancel.Enabled = false;
            }
        }

        private void InitializeLanguages()
        {
            uiCommon.ProcessMultipleLanguages(_mainForm, this, UIConstants.Login_GUI, _mainForm.Tag.ToString().Trim());
        }

        // login begin
        private bool doLogin(String userId, String password)
        {
            bool ret = false;
            var encryptKey = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionKey];
            var encryptIV = ConfigurationManager.AppSettings[AppConfigurationConstants.AppsettingEncryptionIV];
            password = EncryptUtility.EncryptString(password, encryptKey, encryptIV);
            var findUser = this._mainForm._userCommandServices.login(userId, password);
            if (findUser != null)
            {
                var userPermissionDto = UserPermissionDto.Instance;

                var userDto = findUser.Result;
                userPermissionDto.user = userDto;

                var roleId = userDto.RoleID;

                var findUserGroup = this.findUserGroup(roleId);
                if (findUserGroup != null)
                {
                    userPermissionDto.userGroups = findUserGroup.Result;
                }

                List<RoleDto> roles = this._mainForm._roleCommandServices.ListAllAsync().Result;
                userPermissionDto.roles = roles;

                List<PermissionDto> permissions = this._mainForm._permissionCommandServices.ListAllAsync().Result;
                userPermissionDto.permissions = permissions;

                // set systemconfigs
                List<SystemConfigurationDtos> systemConfigs = this._mainForm._systemConfigurationCommandServices.ListAllAsync().Result;
                userPermissionDto.systemConfigs = systemConfigs;

                // check permission of users
                //var sewingRead = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_SEWING, SystemConfigurationConstant.O_PERMISSION_READ);
                //var sewingExecute = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_SEWING, SystemConfigurationConstant.O_PERMISSION_EXECUTE);

                //var hasPartMenu = UserPermissionDto.Instance.hasPartForm();
                //var useBiasDB = false;
                //if (!useBiasDB)
                //{
                //    //return false;
                //}

                GetAllAvailableUIPermissions();

                //MessageBox.Show($"doLogin: {userDto.Name} - sewing read: {sewingRead} - sewing delete: {sewingExecute}");
                ret = true;
            }
            return ret;
        }

        //get all available UI Permission
        private void GetAllAvailableUIPermissions()
        {
            var userPermissionDto = UserPermissionDto.Instance;
            //UI Permission for ucArticle example
            var hasArticle = UserPermissionDto.Instance.hasArticleForm();
            var articleRead = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_ARTICLE_GROUP, SystemConfigurationConstant.O_PERMISSION_READ);
            var articleExecute = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_ARTICLE_GROUP, SystemConfigurationConstant.O_PERMISSION_EXECUTE);
            var articleInsert = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_ARTICLE_GROUP, SystemConfigurationConstant.O_PERMISSION_INSERT);
            var articleDelete = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_ARTICLE_GROUP, SystemConfigurationConstant.O_PERMISSION_DELETE);
            SetUIPermissionObject(nameof(MenuEnums.Articles), nameof(MenuEnums.Articles), UIConstants.UC_ARTICLE_NAME, hasArticle, articleRead, articleInsert, articleExecute, articleDelete);

            //UI Permission for ucThread example
            var hasThread = UserPermissionDto.Instance.hasThreadForm();
            var threadRead = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_MATERIAL_THREADS, SystemConfigurationConstant.O_PERMISSION_READ);
            var threadExecute = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_MATERIAL_THREADS, SystemConfigurationConstant.O_PERMISSION_EXECUTE);
            var threadInsert = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_MATERIAL_THREADS, SystemConfigurationConstant.O_PERMISSION_INSERT);
            var threadDelete = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_MATERIAL_THREADS, SystemConfigurationConstant.O_PERMISSION_DELETE);
            SetUIPermissionObject(nameof(MenuEnums.Threads), nameof(MenuEnums.Threads), UIConstants.UC_THREAD_NAME, hasThread, threadRead, threadInsert, threadExecute, threadDelete);

            //UI Permission for ucPart example
            var haspart = UserPermissionDto.Instance.hasPartForm();
            var partRead = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_MATERIAL_FABRICS, SystemConfigurationConstant.O_PERMISSION_READ);
            var partExecute = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_MATERIAL_FABRICS, SystemConfigurationConstant.O_PERMISSION_EXECUTE);
            var partInsert = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_MATERIAL_FABRICS, SystemConfigurationConstant.O_PERMISSION_INSERT);
            var partDelete = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_MATERIAL_FABRICS, SystemConfigurationConstant.O_PERMISSION_DELETE);
            SetUIPermissionObject(nameof(MenuEnums.Parts), nameof(MenuEnums.Parts), UIConstants.UC_PART_NAME, haspart, partRead, partInsert, partExecute, partDelete);

            //get UI Permission for ucSupplier example
            var hasStockThread = UserPermissionDto.Instance.hasStockThreadForm();
            var hasStockFabric = UserPermissionDto.Instance.hasStockPartForm();
            var hasSupplier = hasStockThread || hasStockFabric;

            var supplierRead = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_SUPPLIER, SystemConfigurationConstant.O_PERMISSION_READ);
            var supplierExecute = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_SUPPLIER, SystemConfigurationConstant.O_PERMISSION_EXECUTE);
            var supplierInsert = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_SUPPLIER, SystemConfigurationConstant.O_PERMISSION_INSERT);
            var supplierDelete = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_SUPPLIER, SystemConfigurationConstant.O_PERMISSION_DELETE);
            SetUIPermissionObject(nameof(MenuEnums.Suppliers), nameof(MenuEnums.Suppliers), UIConstants.UC_SUPPLIER_NAME, hasSupplier, supplierRead, supplierInsert, supplierExecute, supplierDelete);


            //get UI Permission for User Management example
            var hasUserManagement = UserPermissionDto.Instance.hasUserManagementForm();

            var userManagementRead = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_USER_MANAGEMENT, SystemConfigurationConstant.O_PERMISSION_READ);
            var userManagementExecute = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_USER_MANAGEMENT, SystemConfigurationConstant.O_PERMISSION_EXECUTE);
            var userManagementInsert = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_USER_MANAGEMENT, SystemConfigurationConstant.O_PERMISSION_INSERT);
            var userManagementDelete = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_USER_MANAGEMENT, SystemConfigurationConstant.O_PERMISSION_DELETE);
            SetUIPermissionObject(nameof(MenuEnums.UserManagements), nameof(MenuEnums.UserManagements), UIConstants.UC_USER_MANAGEMENT_NAME, hasUserManagement, userManagementRead, userManagementInsert, userManagementExecute, userManagementDelete);

            //get UI Permission for User Group example
            var hasUserGroup = UserPermissionDto.Instance.hasUserGroupPermissionForm();

            var userGroupRead = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_USER_GROUP_PERMISSION, SystemConfigurationConstant.O_PERMISSION_READ);
            var userGroupExecute = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_USER_GROUP_PERMISSION, SystemConfigurationConstant.O_PERMISSION_EXECUTE);
            var userGroupInsert = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_USER_GROUP_PERMISSION, SystemConfigurationConstant.O_PERMISSION_INSERT);
            var userGroupDelete = UserPermissionDto.Instance.hasPermission(SystemConfigurationConstant.PC_USER_GROUP_PERMISSION, SystemConfigurationConstant.O_PERMISSION_DELETE);
            SetUIPermissionObject(nameof(MenuEnums.UserGroups), nameof(MenuEnums.UserGroups), UIConstants.UC_USER_GROUP_NAME, hasUserGroup, userGroupRead, userGroupInsert, userGroupExecute, userGroupDelete);

            //get UI Permission for Machine And ComputerConfiguration Form example
            var hasMachineAndComputer = UserPermissionDto.Instance.hasMachineAndComputerConfigurationForm();

            SetUIPermissionObject(nameof(MenuEnums.ComputerConfigurations), nameof(MenuEnums.ComputerConfigurations), UIConstants.UC_COMPUTER_NAME, hasMachineAndComputer, true, true, true, true);
            SetUIPermissionObject(nameof(MenuEnums.Machines), nameof(MenuEnums.Machines), UIConstants.UC_MACHINE_NAME, hasMachineAndComputer, true, true, true, true);

            //Case: hasSupplier = true and isRead = true
            //SetUIPermissionObject(nameof(MenuEnums.Suppliers), nameof(MenuEnums.Suppliers), UIConstants.UC_SUPPLIER_NAME, true, true, true, false, false, false);

            //logic
            //hasSupplier = false: invisible left+top menu, otherwise able to process
            //isread= false=> top + left menu visible: click -> display msg
            //isread= true: (all btn visible), isinserted: true => (visible save, reject, insert button + able to process),
            //isread= true, isinsert = false => invisible all button
            //SetUIPermissionObject(nameof(MenuEnums.Suppliers), nameof(MenuEnums.Suppliers), UIConstants.UC_SUPPLIER_NAME, true, true, false, false, false);
        }

        private void SetUIPermissionObject(string menuName, string featureName, string ucName, bool isPermission, bool isRead, bool isInserted, bool isExecuted, bool isDeleted)
        {
            var uiProfileObj = new UIProfileDto()
            {
                MenuName = menuName,
                FeatureName = featureName,
                UserControlName = ucName,
                IsPermission = isPermission,
                IsRead = isRead,
                IsInserted = isInserted,
                IsExecuted = isExecuted,
                IsDeleted = isDeleted,
            };

            var existedSupplier = UIUtility.uiProfiles.ToArray().FirstOrDefault(p => p.MenuName.Equals(uiProfileObj.MenuName) && p.UserControlName.Equals(uiProfileObj.UserControlName));
            if (existedSupplier is null)
                UIUtility.uiProfiles.Add(uiProfileObj);
        }

        private async Task<UserDto> findUser(String userId, String password)
        {
            return await this._mainForm._userCommandServices.login(userId, password);
        }

        private async Task<List<UserGroupDto>> findUserGroup(long roleId)
        {
            return await this._mainForm._userGroupCommandServices.GetAllById(roleId);
        }
        // login end

        private void GetAvailableUIPermissionTopMenu(IList<UIProfileDto> availables)
        {
            if (availables != null && availables.Count > 0)
            {
                RecursiveMenuItems(_mainForm.mainMenu.Items, availables);
            }
        }

        private void RecursiveMenuItems(ToolStripItemCollection items, IList<UIProfileDto> availables)
        {
            foreach (ToolStripItem item in items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    var existedUIPermission = availables.ToArray().FirstOrDefault(p => p.MenuName.Equals(menuItem.Text.Trim()));
                    if (existedUIPermission != null && existedUIPermission.IsPermission == false)
                    {
                        menuItem.Visible = false;
                    }
                    RecursiveMenuItems(menuItem.DropDownItems, availables);
                }
            }
        }
    }
}
