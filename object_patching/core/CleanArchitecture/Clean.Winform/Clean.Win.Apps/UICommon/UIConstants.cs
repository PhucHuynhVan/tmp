namespace Clean.Win.AppUI.UICommon
{
    public static class UIConstants
    {
        //Application name
        public const string APP_0_Name = "App0";
        //Device.contrast-white.ico
        public const string APP_0_Icon = "Device.contrast-white.ico";

        //Group GUI codes for multiple language translation text
        public const string Main_GUI = "Main_GUI";
        public const string ucParts_GUI = "ucParts_GUI";
        public const string ucThreads_GUI = "ucThreads_GUI";
        public const string ucSupplier_GUI = "ucSupplier_GUI";
        public const string ucStockThreads_GUI = "ucStockThreads_GUI";
        public const string ucStockParts_GUI = "ucStockParts_GUI";
        public const string ucOrders_GUI = "ucParts_GUI";
        public const string ucBobbins_GUI = "ucBobbins_GUI";
        public const string Login_GUI = "Login_GUI";
        public const string DebugLog_GUI = "Login_GUI";
        public const string TextInputForm_GUI = "TextInputForm_GUI";
        public const string Backup_GUI = "Backup_GUI";

        public const string MSG_MAIN_FORM_CLOSING = "There are some changes so are you sure to exit application?";

        //MSGBOX ICON
        public const string MSGBOX_ICON_WARNING_STYLE = "WARNING";
        public const string MSGBOX_ICON_QUESTION_STYLE = "QUESTION";
        public const string MSGBOX_ICON_ERROR_STYLE = "ERROR";
        public const string MSGBOX_ICON_INFORMATION_STYLE = "INFORMATION";

        ////Data grid columns definitions
        //public const string GRID_COLUMNS_PART_HEADER_Name = "Code||Name||CreatedBy||CreatedOn||UpdatedBy||UpdatedOn";
        //public const string GRID_COLUMNS_PART_HEADER_Text = "Parts Code||Parts Name||Created by||Created on||Updated by||Updated on";
        public const string GRID_COLUMNS_PART_HEADER_Name = "Code||Name||ID";//this headers name definition should be mapped with properties with entity
        public const string GRID_COLUMNS_PART_HEADER_Text = "Parts Code||Parts Name||ID";
        public const string GRID_COLUMNS_ARTICLE_HEADER_Name = "Code||Name||Automat|| ||Endlabel|| ||Version||CreatedBy";//this headers name definition should be mapped with properties with entity
        public const string GRID_COLUMNS_ARTICLE_HEADER_Text = "Article Code||Name||Automat|| ||Endlabel Script|| ||Version||CreatedBy";

        //

        //Panel content name
        public const string PANEL_CONTENT_NAME = "pnlContent";

        //user control name
        public const string UC_PART_NAME = "ucParts";
        public const string UC_ARTICLE_NAME = "ucArticle";
        public const string UC_SUPPLIER_NAME = "ucSupplier";
        public const string UC_THREAD_NAME = "ucThread";
        public const string UC_PRODUCTION_DATA_NAME = "ucProductionData";
        public const string UC_STOCK_THREAD_NAME = "ucStockThreads";
        public const string UC_STOCK_PART_NAME = "ucStockParts";
        public const string UC_USER_MANAGEMENT_NAME = "ucUserManagements";
        public const string UC_USER_GROUP_NAME = "ucUserGroups";
        public const string UC_MACHINE_NAME = "ucMachine";
        public const string UC_BOBBIN_NAME = "ucBobbins";
        public const string UC_COMPUTER_NAME = "ucComputerConfiguration";


    }
    public static class UITagControlConstants
    {
        //Tags value for controls
        public const string MAIN_GRID_TAG_VALUE = "MAIN_PART_FEATURE";
    }

    public static class UIFormNameConstants
    {
        public const string LOGIN = "Login";
        public const string TEXTINPUTFORM = "TextInputForm";
        public const string BACKUPDB = "BackupDBForm";
        public const string LICENSEKEY = "LicenseKeysForm";
        public const string DEBUGLOG = "DebugLogForm";
        public const string CUSTOMLOG = "CustomLogForm";
        public const string ABOUT = "AboutForm";
    }

}
