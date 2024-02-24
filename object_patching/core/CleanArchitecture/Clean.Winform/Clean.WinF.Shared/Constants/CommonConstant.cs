namespace Clean.WinF.Shared.Constants
{
    public static class CommonConstant
    {

        public const string ADMIN = "Admin";
        public const string FormClosed = "FormClosed";
        public const string InputDataFinished = "InputDataFinished";
        public const string UpdateDataFinished = "UpdateDataFinished";
    }

    public static class RegistryKeyConstants
    {
        //registry key
        public const string ProductName = "CleanWinF";
        public const string OrganizationName = "EET";

        public const string RegisteredDate = "RegisteredDate";
        public const string UsageOfDays = "UsageOfDays";
        public const string IsTrial = "IsTrial";
        public const string LicenseKey = "LicenseKey";
        public const string AllowingTrialCount = "AllowingTrialCount";
    }

    public static class AppConfigurationConstants
    {
        //Appsetting configuration
        public const string AppsettingEncryptionKey = "EncryptionKey";
        public const string AppsettingEncryptionIV = "EncryptionIV";
        public const string AppsettingIsAllowedApplicationTimeout = "IsAllowedSessionTimeout";
        public const string AppsettingApplicationTimeoutValue = "ApplicationTimeoutValue";
        public const string InitialBobbinRowGridView = "InitialBobbinRowGridView";
        public const string AppsettingBiasysControlPath = "BiasysControlPath";
    }

    public static class CRUDPermissionMessageContants
    {
        public const string INSERT_FUNC_MSG = "You don't have a permission to execute this function.";
        public const string DELETE_FUNC_MSG = "{0} don't have any permission to execute this function.";
        public const string EXECUTE_FUNC_MSG = "You don't have a permission to execute this function.";
        public const string READ_FUNC_MSG = "{0} don't have any permission to execute this function.";
    }
}
