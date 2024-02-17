//using Clean.Win.Apps;
//using Clean.Win.AppUI.UICommon;
using Clean.WinF.Applications.Features.Systems.Log;
using Clean.WinF.Common.Utilities;

//using DocumentFormat.OpenXml.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Clean.Win.AppUI.Features
{
    public partial class DBLogForm : Form
    {
        bool isLoadForm = false;

        public IDBLogQueryServices _dBLogQueryServices;

        //private Chart chart;
        public DBLogForm(IDBLogQueryServices dBLogQueryServices)
        {
            _dBLogQueryServices = dBLogQueryServices;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DebugLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void DoClosingForm()
        {
            //OnFormClose.Invoke(this);
        }

        private void rich_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void InitializeLanguages()
        {
            //uiCommon.ProcessMultipleLanguages(_mainForm, this, UIConstants.DebugLog_GUI, _mainForm.Tag.ToString().Trim());
        }

        private void DebugLogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void DebugLogForm_Load(object sender, EventArgs e)
        {
            isLoadForm = true;
            this.dtLogFrom.Value = DateTime.Now.AddDays(-30);
            this.dtLogTo.Value = DateTime.Now;
            this.tabMain.SelectedIndex = 1;
            GetLogByCondition();
            this.richTextError.Text = GetSelectedRow();
            if (this.richTextError.Text.Length > 0)
                this.richTextError.SelectionStart = this.richTextError.Text.Length;

            isLoadForm = false;
        }

        private async void LoadLogDB()
        {
            this.dgrDBLog.AllowUserToAddRows = false;
            this.dgrDBLog.ReadOnly = false;
            this.dgrDBLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgrDBLog.AllowUserToResizeColumns = false;
            this.dgrDBLog.AllowUserToResizeRows = false;
            this.dgrDBLog.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrDBLog.RowTemplate.Resizable = DataGridViewTriState.False;
            this.dgrDBLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgrDBLog.ScrollBars = ScrollBars.Both;
            this.dgrDBLog.AutoGenerateColumns = false;
            this.dgrDBLog.MultiSelect = false;

            var result = await _dBLogQueryServices.GetAllDBLogs();
            var dbData = GetFormatDataFromDatasource((List<DBLogDto>)result);
            this.dgrDBLog.DataSource = dbData;
            this.dgrDBLog.Refresh();
        }

        private IList<DBLogDto> GetFormatDataFromDatasource(List<DBLogDto> sources)
        {
            var result = new List<DBLogDto>();
            if (sources != null && sources.Count > 0)
            {
                foreach (var source in sources)
                {
                    var dbLogDto = new DBLogDto()
                    {
                        Id = source.Id,
                        Level = source.Level,
                        Properties = GetAppName(source.Properties),
                        RenderedMessage = source.RenderedMessage,
                        TimeStamp = source.TimeStamp
                    };
                    result.Add(dbLogDto);
                }
            }
            return result;
        }

        private string GetAppName(string orgAppName)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(orgAppName)) return string.Empty;
            var arrAppNames = CleanWinFUtility.ConvertStringToArray(orgAppName, ":");
            if (arrAppNames != null && arrAppNames.Length > 0)
            {
                var appName = arrAppNames[1];
                result = appName.Replace("\"", string.Empty).Replace("}", string.Empty);
            }
            return result;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
            string directoryPath = Path.Combine(assemblyDirectory, @"Logs");
            Process.Start(directoryPath);
        }

        private void btnOpenLogInformation_Click(object sender, EventArgs e)
        {
            richTextError.Text = string.Empty;
            richTextError.Text = OpenLogFile();
            richTextError.SelectionStart = richTextError.Text.Length;
            richTextError.ScrollToCaret();
        }

        private string OpenLogFile()
        {
            StringBuilder logfile = new StringBuilder();
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);

            string directoryPath = Path.Combine(assemblyDirectory, @"Logs");
            // Get a list of .log files in the directory
            string[] logFiles = Directory.GetFiles(directoryPath, "*.log");
            // Sort the files based on their last modified date in descending order
            Array.Sort(logFiles, (f1, f2) => File.GetLastWriteTime(f2).CompareTo(File.GetLastWriteTime(f1)));
            // Open the latest .log file
            if (logFiles.Length > 0)
            {
                string latestLogFile = logFiles[0];
                using (StreamReader sr = File.OpenText(latestLogFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        logfile.Append(string.Concat(line, Environment.NewLine));
                    }
                }
            }
            else
            {
                MessageBox.Show("No .log file found in the directory", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return logfile.ToString();
        }

        private void dgrDBLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                getErrorMsgContent(e.RowIndex);
        }

        private void getErrorMsgContent(int rowIdx)
        {
            DataGridViewRow clickedRow = dgrDBLog.Rows[rowIdx];
            string errorMsg = clickedRow.Cells[3].Value.ToString();
            this.richTextError.Text = errorMsg;
        }

        private string GetSelectedRow()
        {
            var result = string.Empty;
            if (this.dgrDBLog.Rows != null && this.dgrDBLog.Rows.Count > 0)
            {
                for (var i = 0; i < dgrDBLog.Rows.Count; i++)
                {
                    if (this.dgrDBLog.Rows[i].Selected)
                    {
                        result = this.dgrDBLog.Rows[i].Cells[3].Value.ToString();
                        break;
                    }
                }
            }
            return result;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextError.Text))
                Clipboard.SetText(richTextError.Text.Trim());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadForm)
            {
                GetLogByCondition();
            }
        }

        private void dtLogFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoadForm)
            {
                GetLogByCondition();
            }
        }

        private void dtLogTo_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoadForm)
            {
                GetLogByCondition();
            }
        }

        private bool isValidDateFromToValue()
        {
            var result = false;
            var dtFrom = dtLogFrom.Value != null ? dtLogFrom.Value : DateTime.Now;
            var dtTo = dtLogTo.Value != null ? dtLogTo.Value : DateTime.Now;
            if (dtFrom <= dtTo)
                result = true;
            return result;
        }

        private async void GetLogByCondition()
        {
            if (isValidDateFromToValue())
            {
                var dtFrom = dtLogFrom.Value != null ? dtLogFrom.Value : DateTime.Now.Date;
                var dtTo = dtLogTo.Value != null ? dtLogTo.Value : DateTime.Now;
                if (dtFrom == dtTo) dtFrom = dtFrom.Date;
                var appName = cboAppName.SelectedItem is null || cboAppName.SelectedItem.ToString().Equals("All") ? string.Empty : cboAppName.SelectedItem.ToString().Trim();
                var level = cboLevel.SelectedItem is null || cboLevel.SelectedItem.ToString().Equals("All") ? string.Empty : cboLevel.SelectedItem.ToString().Trim();
                var result = await _dBLogQueryServices.GetDBLogByConditions(appName, level, dtFrom, dtTo);
                var dbData = GetFormatDataFromDatasource((List<DBLogDto>)result);
                this.dgrDBLog.DataSource = dbData;
                this.dgrDBLog.Refresh();
            }
            else
            {
                MessageBox.Show("From date should be less than to date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cboAppName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadForm)
            {
                GetLogByCondition();
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 1)
            {
                btnCopy.Enabled = true;
            }
            else
            {
                btnCopy.Enabled = false;
            }
        }

        private void dgrDBLog_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Index >= 0)
                getErrorMsgContent(e.Row.Index);
        }
    }
}
