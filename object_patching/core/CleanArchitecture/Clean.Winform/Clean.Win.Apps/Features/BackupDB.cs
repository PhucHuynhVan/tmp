using Clean.Win.Apps;
using Clean.Win.AppUI.UICommon;
using Clean.WinF.Shared.ErrorMessage;
using Microsoft.Data.Sqlite;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Features.BackupDB
{
    public partial class BackupDBForm : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        private readonly Clean.Win.AppUI.UICommon.UICommon uiCommon = Clean.Win.AppUI.UICommon.UICommon.Instance;
        public BackupDBForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_0_Icon);
        }

        private string GetPathDatasourceValue(string connString)
        {
            var result = "";
            var arr = Clean.WinF.Common.Utilities.CleanWinFUtility.ConvertStringToArray(connString, "=");
            result = arr[arr.Length - 1].Replace(";", "");
            return result;
        }

        private void BackupDBForm_Load(object sender, EventArgs e)
        {
            var SQLiteConnection = ConfigurationManager.ConnectionStrings["SQLiteDefaultConnection"].ConnectionString;
            this.txtSourceDatabase.Text = GetPathDatasourceValue(SQLiteConnection);
            var SQLiteBackupConnection = ConfigurationManager.ConnectionStrings["SQLiteBackupConnection"].ConnectionString;
            this.txtBackupDatabase.Text = GetPathDatasourceValue(SQLiteBackupConnection);
            this.txtBackupDatabase.Focus();
            InitializeLanguages();
        }

        private void DoClosingForm()
        {
            OnFormClose.Invoke(this);
        }

        private void BackupDBForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeLanguages()
        {
            uiCommon.ProcessMultipleLanguages(_mainForm, this, UIConstants.Backup_GUI, _mainForm.Tag.ToString().Trim());
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            var destinationPath = this.txtBackupDatabase.Text.Trim();
            var sourcePath = this.txtSourceDatabase.Text.Trim();
            var SQLiteConnection = ConfigurationManager.ConnectionStrings["SQLiteDefaultConnection"].ConnectionString;
            using (var backup = new SqliteConnection($"Data Source={destinationPath}"))
            {
                var sourceConnection = new SqliteConnection($"Data Source={sourcePath}");
                sourceConnection.Open();
                // Attach the destination database
                using (var attachCommand = new SqliteCommand($"ATTACH DATABASE '{destinationPath}' AS BackupDB;", sourceConnection))
                {
                    attachCommand.ExecuteNonQuery();
                }
            }
            UIUtility.AppShowMsg(CustomErrorMessage.APP_BACKUP_SUCCESS, UIConstants.MSGBOX_ICON_INFORMATION_STYLE);
            btnOpenBackupDB.Enabled = true;
        }

        private void btnSourceOpen_Click(object sender, EventArgs e)
        {
            var dbFilePath = this.txtSourceDatabase.Text.Trim().Length > 0 ? this.txtSourceDatabase.Text.Trim() : string.Empty;
            var parentFolder = Path.GetDirectoryName(dbFilePath);

            //create folder path
            if (!Directory.Exists(parentFolder))
                Directory.CreateDirectory(parentFolder);

            Process.Start("explorer.exe", parentFolder);
        }

        private void btnOpenBackupDB_Click(object sender, EventArgs e)
        {
            var dbFilePath = this.txtBackupDatabase.Text.Trim().Length > 0 ? this.txtBackupDatabase.Text.Trim() : string.Empty;
            OpenBackupDatabase(dbFilePath);
        }

        private void OpenBackupDatabase(string dbFilePath)
        {
            var parentFolder = Path.GetDirectoryName(dbFilePath);
            if (!Directory.Exists(parentFolder))
                Directory.CreateDirectory(parentFolder);

            if (!File.Exists(dbFilePath))
            {
                var sourceFilePath = this.txtSourceDatabase.Text.Trim().Length > 0 ? this.txtSourceDatabase.Text.Trim() : string.Empty;
                if (sourceFilePath.Length > 0)
                    File.Copy(sourceFilePath, dbFilePath);
            }

            Process.Start("explorer.exe", parentFolder);
        }
    }
}
