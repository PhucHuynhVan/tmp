using BiasysControl.UICommon;
using Clean.WinF.Applications.Features.Systems.Log;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace BiasysControl.Features
{
    public partial class DebugLogForm : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        bool isLoadForm = false;
        private readonly BiasysControl.UICommon.UICommon uiCommon = BiasysControl.UICommon.UICommon.Instance;
        public DebugLogForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_0_Icon);
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
            OnFormClose.Invoke(this);
        }

        private void rich_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void InitializeLanguages()
        {
            uiCommon.ProcessMultipleLanguages(_mainForm, this, UIConstants.DebugLog_GUI, _mainForm.Tag.ToString().Trim());
        }

        private void DebugLogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoClosingForm();
        }

        private void DebugLogForm_Load(object sender, EventArgs e)
        {
            isLoadForm = true;
            this.dtLogFrom.Value = DateTime.Now;
            this.dtLogTo.Value = DateTime.Now;
            LoadLogDB();

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
            this.dgrDBLog.ScrollBars = ScrollBars.Both;
            this.dgrDBLog.AutoGenerateColumns = false;
            this.dgrDBLog.MultiSelect = false;
            var result = await _mainForm._dBLogQueryServices.GetAllDBLogs();
            var dbData = (List<DBLogDto>)result;
            this.dgrDBLog.DataSource = dbData;
            this.dgrDBLog.Refresh();
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
                UIUtility.AppShowMsg("No .log files found in the directory");
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
                var dtTo = dtLogTo.Value != null ? dtLogFrom.Value : DateTime.Now;
                if (dtFrom == dtTo) dtFrom = dtFrom.Date;
                var level = cboLevel.SelectedItem is null || cboLevel.SelectedItem.ToString().Equals("All") ? string.Empty : cboLevel.SelectedItem.ToString().Trim();
                var result = await _mainForm._dBLogQueryServices.GetDBLogByConditions(Application.ProductName, level, dtFrom, dtTo);
                var dbData = (List<DBLogDto>)result;
                this.dgrDBLog.DataSource = dbData;
                this.dgrDBLog.Refresh();
            }
            else
            {
                UIUtility.AppShowMsg("From date should be less than to date");
                return;
            }
        }

        private void dgrDBLog_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Index >= 0)
                getErrorMsgContent(e.Row.Index);
        }
    }
}
