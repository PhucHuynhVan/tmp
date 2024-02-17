namespace Clean.WinF.Shared.ErrorMessage
{
    public static class CustomErrorMessage
    {
        //Account controller
        public const string APP_INVALID_LDAP_CHECKED = "Verified by LDAP service - Invalid credentials! Please check again.";

        public const string APP_USER_NOT_FOUND = "User {0} is not found in the system.";

        public const string APP_USER_HAS_NO_PERMISSION = "User {0} has no permission.";

        public const string APP_USER_EXISTED_ALREADY = "User {0} is existed in the system already.";

        public const string APP_USER_WAITED_TO_APPROVAL = "User {0} is waitting for approval from admin.";

        public const string APP_INTERNAL_USER_UPDATED_FAIL = "Updating user {0} is failure. Please check the log file for more detail information.";

        public const string APP_INTERNAL_USER_CREATE_FAIL = "Creating user {0} is failure. Please check the log file for more detail information.";

        public const string APP_LDAP_USER_CREATE_FAIL = "Creating LDAP user {0} is failure. Please check the log file for more detail information.";

        public const string APP_INTERNAL_USER_REMOVED_FAIL = "Removing user {0} is failure. Please check the log file for more detail information.";

        public const string APP_INVALID_USER_STATUS = "Invalid user status! It should be one of (Active, InActive and Removed) user status.";

        public const string APP_USER_FULL_NAME_EMPTY = "Full name is not empty.";

        public const string APP_USER_NAME_EMPTY = "User name is not empty.";

        public const string APP_USER_EMAIL_EMPTY = "Email of {0} should be not empty.";

        public const string APP_USER_EMAIL_INVALID = "Email of {0} is invalid.";

        public const string APP_USER_INVALID_NAME = "Has the special character in the name of user.";

        public const string APP_WAM_INVALID_IV_USER_EMPTY = "Verified by WAM server - Can't detect user on WAM server or not.";

        public const string APP_WAM_EMPTY_X_FOWARDED_FOR = "Verified by WAM server - Can't detect request from empty WAM server";

        public const string APP_WAM_INVALID_X_FOWARDED_FOR = "Verified by WAM server - Can't detect request from valid WAM server";

        public const string APP_WAM_EMPTY_SERVER_IP = "Verified by WAM server - Can't detect ip from backend server";

        public const string APP_WAM_INVALID_SERVER_IP = "Verified by WAM server - Invalid ip from backend server";

        public const string APP_DISTRIBUTION_LIST_NAME_EMPTY = "Display name of distribution list should not be empty.";

        public const string APP_DISTRIBUTION_LIST_NOT_FOUND = "Distribution list is not found in the system.";

        public const string APP_DISTRIBUTION_LIST_EXISTED_ALREADY = "Distribution list {0} is existed in this group already.";

        public const string APP_DISTRIBUTION_LIST_EMAIL_EMPTY = "The email of distribution list {0} should be not empty.";

        public const string APP_DISTRIBUTION_LIST_EMAIL_INVALID = "The email of distribution list {0} is invalid.";

        public const string APP_DISTRIBUTION_LIST_GROUP_EMPTY = "Selected LDAP distribution list into group should not be empty.";

        public const string APP_DISTRIBUTION_LIST_ADD_FAIL = "Unable to add the distribution list {0} in to this group. Please check the log file for detail.";

        //Group controller
        public const string APP_GROUP_NOT_FOUND = "Group {0} is not found in the system.";

        public const string APP_GROUP_EXISTED_ALREADY = "Group {0} is existed in the system already.";

        public const string APP_GROUP_UPDATED_FAIL = "Updating group {0} is failure. Please check the log file for more detail information.";

        public const string APP_GROUP_CREATE_FAIL = "Creating group {0} is failure. Please check the log file for more detail information.";

        public const string APP_GROUP_REMOVED_FAIL = "Removing group {0} is failure. Please check the log file for more detail information.";

        public const string APP_INVALID_GROUP_STATUS = "Invalid group status! It should be one of (Active, InActive and Removed) group status";

        public const string APP_GROUP_STATUS_ACTIVE_ONLY = "Group status should be Active for this case.";

        public const string APP_USER_GROUP_EMPTY = "Selected users into group should not be empty.";

        public const string APP_USER_GROUP_EXISTED_ALREADY = "User {0} is existed in this group already.";

        public const string APP_ROLE_GROUP_EMPTY = "Selected roles into group should not be empty.";

        public const string APP_GROUP_INVALID_NAME = "Group name is invalid due to contain the special characters. Please try another.";

        public const string APP_GROUP_NAME_EMPTY = "Group name can not be empty. Please try another.";

        public const string APP_GROUP_INVALID_VALUE = "Group value should be a number value.";

        public const string APP_USER_GROUP_ID_VALUE = "Selected users should be number values.";

        public const string APP_GROUP_EXIST_SPECIAL_CHARS_NAME = "Group name {0} cannot contain special characters";

        public const string APP_GROUP_EXIST_SPECIAL_CHARS_DESCRIPTION = "Group description cannot contain special characters";

        //Role controller
        public const string APP_ROLE_NOT_FOUND = "Role {0} is not found in the system.";

        public const string APP_ROLE_EXISTED_ALREADY = "Role {0} is existed in the system already.";

        public const string APP_ROLE_UPDATED_FAIL = "Updating role {0} is failure. Please check the log file for more detail information.";

        public const string APP_ROLE_CREATE_FAIL = "Creating role {0} is failure. Please check the log file for more detail information.";

        public const string APP_ROLE_REMOVED_FAIL = "Removing role {0} is failure. Please check the log file for more detail information.";

        public const string APP_ROLE_ADD_PERMISSION_FAIL = "Add permissions to role {0} is failure. Please check the log file for more detail information.";

        public const string APP_ROLE_INVALID_NAME = "Role name is invalid.";

        public const string APP_ROLE_NAME_EMPTY = "Role name can not be empty. Please try another.";

        public const string APP_ROLE_REMOVED_FAIL_GROUP_ACTIVE = "Removing role {0} is failure. Some groups relate to this role are Active";

        public const string APP_ROLE_EXIST_SPECIAL_CHARS_NAME = "Role name {0} cannot contain special characters";

        public const string APP_ROLE_EXIST_SPECIAL_CHARS_DESCRIPTION = "Role description cannot contain special characters";


        //Permission controller
        public const string APP_PERMISSION_NOT_FOUND = "Permission {0} is not found in the system.";
        //Permission Group controller
        public const string APP_PERMISSION_GROUP_NOT_FOUND = "Permission Group {0} is not found in the system.";

        public const string APP_PERMISSION_GROUP_EXISTED_ALREADY = "Permission Group {0} is existed in the system already.";

        public const string APP_PERMISSION_GROUP_UPDATED_FAIL = "Updating Permission group {0} is failure. Please check the log file for more detail information.";

        public const string APP_PERMISSION_GROUP_CREATE_FAIL = "Creating Permission group {0} is failure. Please check the log file for more detail information.";

        public const string APP_PERMISSION_GROUP_REMOVED_FAIL = "Removing Permission group {0} is failure. Please check the log file for more detail information.";

        public const string APP_INVALID_PERMISSION_GROUP_STATUS = "Invalid Permission group status! It should be one of (Active, InActive and Removed) group status";

        public const string APP_PERMISSION_GROUP_STATUS_ACTIVE_ONLY = "Permission Group status should be Active for this case.";

        public const string APP_PERMISSION_GROUP_INVALID_NAME = "Permission Group name is invalid due to contain the special characters. Please try another.";

        public const string APP_PERMISSION_GROUP_ROLE_IS_MISSING_FAIL = "Permission Group is missing role.";

        public const string APP_PERMISSION_GROUP_EMPTY = "Permission Group Name can not be empty. Please try another.";

        //public const string APP_USER_GROUP_EMPTY = "Selected users into group should not be empty.";

        //public const string APP_ROLE_GROUP_EMPTY = "Selected roles into group should not be empty.";

        //public const string APP_GROUP_INVALID_NAME = "Group name is invalid due to contain the special characters. Please try another.";

        //public const string APP_GROUP_NAME_EMPTY = "Group name can not be empty. Please try another.";
        public const string APP_PERMISSION_EXISTED_ALREADY = "Permission {0} is existed in the system already.";

        public const string APP_PERMISSION_CREATE_FAIL = "Creating permission {0} is failure. Please check the log file for more detail information.";

        public const string APP_PERMISSION_REMOVED_FAIL = "Removing permission {0} is failure. Please check the log file for more detail information.";

        public const string APP_INVALID_PERMISSION_STATUS = "Invalid permission status! It should be one of (Active, InActive and Removed) group status";

        public const string APP_PERMISSION_UPDATED_FAIL = "Updating permission {0} is failure. Please check the log file for more detail information.";

        public const string APP_PERMISSION_NAME_EMPTY = "Permission name can not be empty. Please try another.";

        public const string APP_PERMISSION_INVALID_NAME = "Permission name is invalid due to contain the special characters. Please try another.";

        //PART
        public const string APP_PART_NAME_EMPTY = "Part Name value should be not empty.";
        public const string APP_PART_CODE_EMPTY = "Part Code value should be not empty.";
        public const string APP_PART_CODE_NOT_ALLOW_SPECIAL_CHARS = "Part Code value is not allowed special characters.";
        public const string APP_PART_NAME_NOT_ALLOW_SPECIAL_CHARS = "Part Name value is not allowed special characters.";
        public const string APP_PART_UPDATED_SUCCESS = "Data changes have updated successfully.";
        public const string APP_PART_UPDATED_FAIL = "Data changes have updated fail";
        public const string APP_PART_NOT_FOUND = "This Part information is not found.";
        public const string APP_PART_CODE_EXISTED_ALREADY = "The Part Code value is existed already.";
        public const string APP_PART_INVALID_NAME = "Part name value is invalid";
        public const string APP_PART_INVALID_CODE = "Part code value is invalid";
        public const string APP_PART_INVALID_CODE_AND_NAME = "Part Code and Name value must be specified";
        public const string APP_PART_SELECTED_ROW_DATA_CHANGE = "Are you sure to reject current data changes?";

        //ARTICLE
        public const string APP_ARTICLE_AUTOMAT_EMPTY = "Automat value should be not empty.";
        public const string APP_ARTICLE_NAME_EMPTY = "Article Name value should be not empty.";
        public const string APP_ARTICLE_CODE_EMPTY = "Article Code value should be not empty.";
        public const string APP_ARTICLE_CODE_NOT_ALLOW_SPECIAL_CHARS = "Article Code value is not allowed special characters.";
        public const string APP_ARTICLE_NAME_NOT_ALLOW_SPECIAL_CHARS = "Article Name value is not allowed special characters.";
        public const string APP_ARTICLE_CREATED_SUCCESS = "Article have created successfully.";
        public const string APP_ARTICLE_UPDATED_SUCCESS = "Data changes have updated successfully.";
        public const string APP_ARTICLE_UPDATED_FAIL = "Article have update failure";
        public const string APP_ARTICLE_CREATED_FAIL = "Article have create failure";
        public const string APP_ARTICLE_NOT_FOUND = "This Article information is not found.";
        public const string APP_ARTICLE_CODE_EXISTED_ALREADY = "The Article Code value is existed already.";
        public const string APP_ARTICLE_INVALID_NAME = "Article name value is invalid";
        public const string APP_ARTICLE_INVALID_CODE = "Article code value is invalid";
        public const string APP_ARTICLE_IS_EXIST = "Article is exist";
        public const string APP_ARTICLE_REMOVED_FAIL = "Removing article {0} is failure. Please check the log file for more detail information.";

        //SUPPLIER
        public const string APP_SUPPLIER_NAME_EMPTY = "Supplier Name value should be not empty.";
        public const string APP_SUPPLIER_CODE_EMPTY = "Supplier Code value should be not empty.";
        public const string APP_SUPPLIER_CODE_NOT_ALLOW_SPECIAL_CHARS = "Supplier Code value is not allowed special characters.";
        public const string APP_SUPPLIER_NAME_NOT_ALLOW_SPECIAL_CHARS = "Supplier Name value is not allowed special characters.";
        public const string APP_SUPPLIER_CREATED_SUCCESS = "Supplier have created successfully.";
        public const string APP_SUPPLIER_UPDATED_SUCCESS = "Data changes have updated successfully.";
        public const string APP_SUPPLIER_EXPORTED_SUCCESS = "Data exported successfully.";
        public const string APP_SUPPLIER_UPDATED_FAIL = "Supplier have update failure";
        public const string APP_SUPPLIER_CREATED_FAIL = "Supplier have create failure";
        public const string APP_SUPPLIER_NOT_FOUND = "This Supplier information is not found.";
        public const string APP_SUPPLIER_CODE_EXISTED_ALREADY = "The Supplier Code value is existed already.";
        public const string APP_SUPPLIER_INVALID_NAME = "Supplier name value is invalid";
        public const string APP_SUPPLIER_INVALID_CODE = "Supplier code value is invalid";
        public const string APP_SUPPLIER_IS_EXIST = "Supplier is exist";
        public const string APP_SUPPLIER_REMOVED_FAIL = "Removing Supplier {0} is failure. Please check the log file for more detail information.";

        // THREAD
        public const string APP_THREAD_NAME_EMPTY = "Thread Name value should be not empty.";
        public const string APP_THREAD_CODE_EMPTY = "Thread Code value should be not empty.";
        public const string APP_THREAD_CODE_NOT_ALLOW_SPECIAL_CHARS = "Thread Code value is not allowed special characters.";
        public const string APP_THREAD_NAME_NOT_ALLOW_SPECIAL_CHARS = "Thread Name value is not allowed special characters.";
        public const string APP_THREAD_CREATED_SUCCESS = "Thread have created successfully.";
        public const string APP_THREAD_UPDATED_SUCCESS = "Data changes have updated successfully.";
        public const string APP_THREAD_UPDATED_FAIL = "Thread have update failure";
        public const string APP_THREAD_CREATED_FAIL = "Thread have create failure";
        public const string APP_THREAD_NOT_FOUND = "This Thread information is not found.";
        public const string APP_THREAD_CODE_EXISTED_ALREADY = "The Thread Code value is existed already.";
        public const string APP_THREAD_INVALID_NAME = "Thread name value is invalid";
        public const string APP_THREAD_INVALID_CODE = "Thread code value is invalid";
        public const string APP_THREAD_IS_EXIST = "Thread is exist";
        public const string APP_THREAD_REMOVED_FAIL = "Removing Thread {0} is failure. Please check the log file for more detail information.";
        public const string APP_THREAD_EXPORTED_SUCCESS = "Data exported successfully.";

        // WINDING PARAM
        public const string APP_WINDING_PARAM_NAME_EMPTY = "Winding Param Name value should be not empty.";
        public const string APP_WINDING_PARAM_CODE_EMPTY = "Winding Param Code value should be not empty.";
        public const string APP_WINDING_PARAM_CODE_NOT_ALLOW_SPECIAL_CHARS = "Winding Param Code value is not allowed special characters.";
        public const string APP_WINDING_PARAM_NAME_NOT_ALLOW_SPECIAL_CHARS = "Winding Param Name value is not allowed special characters.";
        public const string APP_WINDING_PARAM_CREATED_SUCCESS = "Winding Param have created successfully.";
        public const string APP_WINDING_PARAM_UPDATED_SUCCESS = "Data changes have updated successfully.";
        public const string APP_WINDING_PARAM_UPDATED_FAIL = "Winding Param have update failure";
        public const string APP_WINDING_PARAM_CREATED_FAIL = "Winding Param have create failure";
        public const string APP_WINDING_PARAM_NOT_FOUND = "This Thread information is not found.";
        public const string APP_WINDING_PARAM_CODE_EXISTED_ALREADY = "The Thread Code value is existed already.";
        public const string APP_WINDING_PARAM_INVALID_NAME = "Winding Param name value is invalid";
        public const string APP_WINDING_PARAM_INVALID_CODE = "Winding Param code value is invalid";
        public const string APP_WINDING_PARAM_IS_EXIST = "Winding Param is exist";
        public const string APP_WINDING_PARAM_REMOVED_FAIL = "Removing Thread {0} is failure. Please check the log file for more detail information.";

        // BOBBIN
        public const string APP_BOBBIN_NAME_EMPTY = "Bobbin Name value should be not empty.";
        public const string APP_BOBBIN_CODE_EMPTY = "Bobbin Code value should be not empty.";
        public const string APP_BOBBIN_CODE_NOT_ALLOW_SPECIAL_CHARS = "Bobbin Code value is not allowed special characters.";
        public const string APP_BOBBIN_NAME_NOT_ALLOW_SPECIAL_CHARS = "Bobbin Name value is not allowed special characters.";
        public const string APP_BOBBIN_CREATED_SUCCESS = "Bobbin have created successfully.";
        public const string APP_BOBBIN_UPDATED_SUCCESS = "Data changes have updated successfully.";
        public const string APP_BOBBIN_UPDATED_FAIL = "Bobbin have update failure";
        public const string APP_BOBBIN_CREATED_FAIL = "Bobbin have create failure";
        public const string APP_BOBBIN_NOT_FOUND = "This Thread information is not found.";
        public const string APP_BOBBIN_CODE_EXISTED_ALREADY = "The Thread Code value is existed already.";
        public const string APP_BOBBIN_INVALID_NAME = "Bobbin name value is invalid";
        public const string APP_BOBBIN_INVALID_CODE = "Bobbin code value is invalid";
        public const string APP_BOBBIN_IS_EXIST = "Bobbin is exist";
        public const string APP_BOBBIN_REMOVED_FAIL = "Removing Thread {0} is failure. Please check the log file for more detail information.";

        // USER
        //public const string APP_USER_NAME_EMPTY = "User Name value should be not empty.";
        public const string APP_USER_CODE_EMPTY = "User Code value should be not empty.";
        public const string APP_USER_CODE_NOT_ALLOW_SPECIAL_CHARS = "User Code value is not allowed special characters.";
        public const string APP_USER_NAME_NOT_ALLOW_SPECIAL_CHARS = "User Name value is not allowed special characters.";
        public const string APP_USER_CREATED_SUCCESS = "User have created successfully.";
        public const string APP_USER_UPDATED_SUCCESS = "Data changes have updated successfully.";
        public const string APP_USER_UPDATED_FAIL = "User have update failure";
        public const string APP_USER_CREATED_FAIL = "User have create failure";
        //public const string APP_USER_NOT_FOUND = "This Thread information is not found.";
        public const string APP_USER_CODE_EXISTED_ALREADY = "The Thread Code value is existed already.";
        //public const string APP_USER_INVALID_NAME = "User name value is invalid";
        public const string APP_USER_INVALID_CODE = "User code value is invalid";
        public const string APP_USER_IS_EXIST = "User is exist";
        public const string APP_USER_REMOVED_FAIL = "Removing Thread {0} is failure. Please check the log file for more detail information.";
        public const string APP_USER_LOGIN_FAILED = "Invalid Username or Password";

        //BACKUP Database
        public const string APP_BACKUP_SUCCESS = "Backup database successfully!";
        public const string APP_BACKUP_ERROR = "Backup database happens error please go to the log file to get more detail!";
    }
}
