using Clean.WinF.Applications.Features.SystemConfiguration.DTOs;
using System.Collections.Generic;

namespace Clean.WinF.Applications.Features.Users.DTOs
{
    public sealed class UserPermissionDto
    {
        private static UserPermissionDto instance = null;

        private UserPermissionDto() { }

        public static UserPermissionDto Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserPermissionDto();
                }
                return instance;
            }
        }

        public UserDto user { get; set; }

        public RoleDto role { get; set; }

        public List<UserGroupDto> userGroups { get; set; }

        public List<RoleDto> roles { get; set; }

        public List<PermissionDto> permissions { get; set; }

        public List<SystemConfigurationDtos> systemConfigs { get; set; }

        public bool hasPermission(string code, string permission)
        {
            var permissionDto = this.findPermission(code);
            if (permissionDto == null)
            {
                return false;
            }

            var permissionId = permissionDto.ID;
            if (this.userGroups != null)
            {
                foreach (UserGroupDto dto in this.userGroups)
                {
                    if (dto.PermissionID == permissionId)
                    {
                        return this.checkPermission(dto, permission);
                    }
                }
            }
            return false;
        }

        private PermissionDto findPermission(string code)
        {
            foreach (PermissionDto dto in this.permissions)
            {
                if (dto.Code.Equals(code))
                {
                    return dto;
                }
            }
            return null;
        }

        private bool checkPermission(UserGroupDto dto, string permission)
        {
            if (SystemConfiguration.Constants.SystemConfigurationConstant.O_PERMISSION_READ.Equals(permission))
            {
                return dto.IsRead;
            }
            if (SystemConfiguration.Constants.SystemConfigurationConstant.O_PERMISSION_INSERT.Equals(permission))
            {
                return dto.IsInsert;
            }
            if (SystemConfiguration.Constants.SystemConfigurationConstant.O_PERMISSION_DELETE.Equals(permission))
            {
                return dto.IsDelete;
            }
            if (SystemConfiguration.Constants.SystemConfigurationConstant.O_PERMISSION_EXECUTE.Equals(permission))
            {
                return dto.IsExecute;
            }
            return false;
        }
        public bool isAdmin()
        {
            // Check for admin
            return SystemConfiguration.Constants.SystemConfigurationConstant.R_ADMINISTRATOR.Equals(this.role.Name);
        }
        public bool isPowerUser()
        {
            // Check for Power User
            return SystemConfiguration.Constants.SystemConfigurationConstant.R_POWER_USER.Equals(this.role.Name);
        }

        public bool isSewingUser()
        {
            // Check for Sewing User
            return SystemConfiguration.Constants.SystemConfigurationConstant.R_SEWING_USER.Equals(this.role.Name);
        }

        public bool isTechican()
        {
            // Check for Techican
            return SystemConfiguration.Constants.SystemConfigurationConstant.R_TECHNICAN.Equals(this.role.Name);
        }


        public string checkConfig(string FeatureKey)
        {
            // loop systemConfigs
            // check config with FeatureKey
            // return Permission
            foreach (SystemConfigurationDtos dto in this.systemConfigs)
            {
                if (dto.FeatureKey.Equals(FeatureKey))
                {
                    return dto.Permission;
                }
            }
            return "";
        }

        public bool hasArticleForm()
        {
            // Check system configration permission for Article Form (Master Data)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_ARTICLES) == "1";
        }
        public bool hasThreadForm()
        {
            // Check system configration permission for Thread Form (Master Data)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_MATERIAL_THREADS) == "1";
        }
        public bool hasPartForm()
        {
            // Check system configration permission for Part Form (Master Data)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_MATERIAL_FABRICS) == "1";
        }
        public bool hasStockThreadForm()
        {
            // Check system configration permission for Stock Thread (Goods Incoming)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_STOCK_THREADS) == "1";
        }
        public bool hasStockPartForm()
        {
            // Check system configration permission for Stock Thread (Goods Incoming)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_STOCK_FABRICS) == "1";
        }
        public bool hasUserManagementForm()
        {
            // Check system configration permission for User Management (Form Others)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_USER_MANAGEMENT) == "1";
        }
        public bool hasUserGroupPermissionForm()
        {
            // Check system configration permission for User Group (Form Others)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_USERGROUP_PERMISSION) == "1";
        }

        public bool hasMachineAndComputerConfigurationForm()
        {
            // Check system configration permission for Machine and Configuration (Form Others)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_MACHINE_COMPUTER_CONFIGURATION) == "1";
        }
        public bool hasBobbinForm()
        {
            // Check system configration permission for Bobbin (Form Others)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_FORM_BOBBIN) == "1";
        }
        public bool hasProductionDataForm()
        {
            // Check system configration permission for Bobbin (Form Others)
            return this.checkConfig(SystemConfiguration.Constants.SystemConfigurationConstant.DB_PRODUCTION_DATA) == "1";
        }

    }
}
