using Clean.Win.Apps;
using Clean.Win.AppUI.UICommon;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Clean.Win.AppUI.Features
{
    public partial class CustomLogForm : Form
    {
        public event FormClosed OnFormClose;
        MainForm _mainForm = null;
        private readonly Clean.Win.AppUI.UICommon.UICommon uiCommon = Clean.Win.AppUI.UICommon.UICommon.Instance;
        public CustomLogForm(MainForm main)
        {
            _mainForm = main;
            this.Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\Icons\\" + UIConstants.APP_1_Icon);
            InitializeComponent();
        }

        private void DoClosingForm()
        {
            OnFormClose.Invoke(this);
        }

        private void CustomLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DoClosingForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomLogForm_Load(object sender, EventArgs e)
        {
            this.lblApp.Text = "Application name: " + Application.ProductName;
            this.lblUser.Text = "User id: " + UIUtility.userLogin;
            this.lblLocalTime.Text = "Time: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            //this.lblLanguage.Text = "Language: " + _mainForm.mnuAppLanguage.Text;
            this.richTextError.Focus();
            if (this.richTextError.Text.Length > 0)
            {
                this.richTextError.SelectionStart = this.richTextError.Text.Length;
            }
            else
            {
                richTextError.Text = OpenLogFile();
                richTextError.SelectionStart = richTextError.Text.Length;
                richTextError.ScrollToCaret();
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.richTextError.Text = string.Empty;
            this.richTextError.Focus();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextError.Text))
                Clipboard.SetText(richTextError.Text.Trim());
        }
    }
}
