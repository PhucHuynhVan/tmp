namespace Clean.Win.AppUI.Features
{
    partial class DBLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBLogForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnl = new Panel();
            dgrDBLog = new DataGridView();
            richTextError = new RichTextBox();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            cboAppName = new ComboBox();
            lblToLog = new Label();
            lblFromLog = new Label();
            lblLogLevel = new Label();
            dtLogTo = new DateTimePicker();
            dtLogFrom = new DateTimePicker();
            cboLevel = new ComboBox();
            btnCopy = new Button();
            btnSendError = new Button();
            tabMain = new TabControl();
            tabChart = new TabPage();
            pnlChart = new Panel();
            tabDetail = new TabPage();
            colID = new DataGridViewTextBoxColumn();
            colTimespan = new DataGridViewTextBoxColumn();
            colLogLevel = new DataGridViewTextBoxColumn();
            colErrorMsg = new DataGridViewTextBoxColumn();
            Properties = new DataGridViewTextBoxColumn();
            pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDBLog).BeginInit();
            groupBox1.SuspendLayout();
            tabMain.SuspendLayout();
            tabChart.SuspendLayout();
            tabDetail.SuspendLayout();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Controls.Add(dgrDBLog);
            pnl.Controls.Add(richTextError);
            pnl.Location = new Point(8, 8);
            pnl.Name = "pnl";
            pnl.Size = new Size(1308, 593);
            pnl.TabIndex = 0;
            // 
            // dgrDBLog
            // 
            dgrDBLog.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrDBLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrDBLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDBLog.Columns.AddRange(new DataGridViewColumn[] { colID, colTimespan, colLogLevel, colErrorMsg, Properties });
            dgrDBLog.Location = new Point(7, 8);
            dgrDBLog.Name = "dgrDBLog";
            dgrDBLog.ReadOnly = true;
            dgrDBLog.RowHeadersVisible = false;
            dgrDBLog.RowHeadersWidth = 51;
            dgrDBLog.RowTemplate.Height = 29;
            dgrDBLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDBLog.Size = new Size(1292, 238);
            dgrDBLog.TabIndex = 1;
            dgrDBLog.CellClick += dgrDBLog_CellClick;
            dgrDBLog.RowStateChanged += dgrDBLog_RowStateChanged;
            // 
            // richTextError
            // 
            richTextError.Location = new Point(6, 253);
            richTextError.Name = "richTextError";
            richTextError.Size = new Size(1289, 328);
            richTextError.TabIndex = 0;
            richTextError.Text = "";
            richTextError.KeyDown += rich_KeyDown;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1227, 727);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(108, 33);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboAppName);
            groupBox1.Controls.Add(lblToLog);
            groupBox1.Controls.Add(lblFromLog);
            groupBox1.Controls.Add(lblLogLevel);
            groupBox1.Controls.Add(dtLogTo);
            groupBox1.Controls.Add(dtLogFrom);
            groupBox1.Controls.Add(cboLevel);
            groupBox1.Location = new Point(5, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1321, 68);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // cboAppName
            // 
            cboAppName.FormattingEnabled = true;
            cboAppName.Items.AddRange(new object[] { "All", "Clean.Win.AppUI", "Clean.Win.AppConfigUI" });
            cboAppName.Location = new Point(105, 31);
            cboAppName.Name = "cboAppName";
            cboAppName.Size = new Size(172, 28);
            cboAppName.TabIndex = 5;
            cboAppName.Text = "All";
            cboAppName.SelectedIndexChanged += cboAppName_SelectedIndexChanged;
            // 
            // lblToLog
            // 
            lblToLog.AutoSize = true;
            lblToLog.Location = new Point(730, 31);
            lblToLog.Name = "lblToLog";
            lblToLog.Size = new Size(28, 20);
            lblToLog.TabIndex = 4;
            lblToLog.Text = "To:";
            // 
            // lblFromLog
            // 
            lblFromLog.AutoSize = true;
            lblFromLog.Location = new Point(476, 31);
            lblFromLog.Name = "lblFromLog";
            lblFromLog.Size = new Size(46, 20);
            lblFromLog.TabIndex = 3;
            lblFromLog.Text = "From:";
            // 
            // lblLogLevel
            // 
            lblLogLevel.AutoSize = true;
            lblLogLevel.Location = new Point(5, 31);
            lblLogLevel.Name = "lblLogLevel";
            lblLogLevel.Size = new Size(98, 20);
            lblLogLevel.TabIndex = 2;
            lblLogLevel.Text = "DBLogs filter:";
            // 
            // dtLogTo
            // 
            dtLogTo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtLogTo.Format = DateTimePickerFormat.Custom;
            dtLogTo.Location = new Point(765, 31);
            dtLogTo.Name = "dtLogTo";
            dtLogTo.Size = new Size(179, 27);
            dtLogTo.TabIndex = 1;
            dtLogTo.ValueChanged += dtLogTo_ValueChanged;
            // 
            // dtLogFrom
            // 
            dtLogFrom.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtLogFrom.Format = DateTimePickerFormat.Custom;
            dtLogFrom.Location = new Point(525, 31);
            dtLogFrom.Name = "dtLogFrom";
            dtLogFrom.Size = new Size(180, 27);
            dtLogFrom.TabIndex = 1;
            dtLogFrom.ValueChanged += dtLogFrom_ValueChanged;
            // 
            // cboLevel
            // 
            cboLevel.FormattingEnabled = true;
            cboLevel.Items.AddRange(new object[] { "All", "Debug", "Information", "Warning", "Error", "Fatal" });
            cboLevel.Location = new Point(287, 31);
            cboLevel.Name = "cboLevel";
            cboLevel.Size = new Size(173, 28);
            cboLevel.TabIndex = 0;
            cboLevel.Text = "All";
            cboLevel.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnCopy
            // 
            btnCopy.Enabled = false;
            btnCopy.Image = (Image)resources.GetObject("btnCopy.Image");
            btnCopy.ImageAlign = ContentAlignment.MiddleLeft;
            btnCopy.Location = new Point(1046, 727);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(172, 33);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "Copy to clipboard";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnSendError
            // 
            btnSendError.Enabled = false;
            btnSendError.Image = (Image)resources.GetObject("btnSendError.Image");
            btnSendError.ImageAlign = ContentAlignment.MiddleLeft;
            btnSendError.Location = new Point(8, 727);
            btnSendError.Name = "btnSendError";
            btnSendError.Size = new Size(142, 33);
            btnSendError.TabIndex = 5;
            btnSendError.Text = "Send as report";
            btnSendError.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabChart);
            tabMain.Controls.Add(tabDetail);
            tabMain.Location = new Point(5, 80);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1333, 643);
            tabMain.TabIndex = 6;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
            // 
            // tabChart
            // 
            tabChart.BorderStyle = BorderStyle.FixedSingle;
            tabChart.Controls.Add(pnlChart);
            tabChart.Location = new Point(4, 29);
            tabChart.Name = "tabChart";
            tabChart.Padding = new Padding(3);
            tabChart.Size = new Size(1325, 610);
            tabChart.TabIndex = 0;
            tabChart.Text = "Charts";
            tabChart.UseVisualStyleBackColor = true;
            // 
            // pnlChart
            // 
            pnlChart.BorderStyle = BorderStyle.FixedSingle;
            pnlChart.Location = new Point(8, 8);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(1308, 594);
            pnlChart.TabIndex = 0;
            // 
            // tabDetail
            // 
            tabDetail.BorderStyle = BorderStyle.FixedSingle;
            tabDetail.Controls.Add(pnl);
            tabDetail.Location = new Point(4, 29);
            tabDetail.Name = "tabDetail";
            tabDetail.Padding = new Padding(3);
            tabDetail.Size = new Size(1325, 610);
            tabDetail.TabIndex = 1;
            tabDetail.Text = "DBLog";
            tabDetail.UseVisualStyleBackColor = true;
            // 
            // colID
            // 
            colID.DataPropertyName = "Id";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Resizable = DataGridViewTriState.False;
            colID.Width = 55;
            // 
            // colTimespan
            // 
            colTimespan.DataPropertyName = "TimeStamp";
            colTimespan.HeaderText = "Date";
            colTimespan.MinimumWidth = 6;
            colTimespan.Name = "colTimespan";
            colTimespan.ReadOnly = true;
            colTimespan.Resizable = DataGridViewTriState.False;
            colTimespan.Width = 175;
            // 
            // colLogLevel
            // 
            colLogLevel.DataPropertyName = "Level";
            colLogLevel.HeaderText = "Level";
            colLogLevel.MinimumWidth = 6;
            colLogLevel.Name = "colLogLevel";
            colLogLevel.ReadOnly = true;
            colLogLevel.Resizable = DataGridViewTriState.False;
            colLogLevel.Width = 145;
            // 
            // colErrorMsg
            // 
            colErrorMsg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colErrorMsg.DataPropertyName = "RenderedMessage";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            colErrorMsg.DefaultCellStyle = dataGridViewCellStyle2;
            colErrorMsg.HeaderText = "Message";
            colErrorMsg.MinimumWidth = 6;
            colErrorMsg.Name = "colErrorMsg";
            colErrorMsg.ReadOnly = true;
            colErrorMsg.Resizable = DataGridViewTriState.False;
            // 
            // Properties
            // 
            Properties.DataPropertyName = "Properties";
            Properties.HeaderText = "App name";
            Properties.MinimumWidth = 6;
            Properties.Name = "Properties";
            Properties.ReadOnly = true;
            Properties.Resizable = DataGridViewTriState.False;
            Properties.Width = 185;
            // 
            // DBLogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 768);
            Controls.Add(btnSendError);
            Controls.Add(btnCopy);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(tabMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DBLogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DBLog information";
            FormClosing += DebugLogForm_FormClosing;
            FormClosed += DebugLogForm_FormClosed;
            Load += DebugLogForm_Load;
            pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrDBLog).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabMain.ResumeLayout(false);
            tabChart.ResumeLayout(false);
            tabDetail.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.RichTextBox richTextError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblToLog;
        private System.Windows.Forms.Label lblFromLog;
        private System.Windows.Forms.Label lblLogLevel;
        private System.Windows.Forms.DateTimePicker dtLogTo;
        private System.Windows.Forms.DateTimePicker dtLogFrom;
        private System.Windows.Forms.ComboBox cboLevel;
        public System.Windows.Forms.DataGridView dgrDBLog;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSendError;
        private ComboBox cboAppName;
        private TabControl tabMain;
        private TabPage tabChart;
        private TabPage tabDetail;
        private Panel pnlChart;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTimespan;
        private DataGridViewTextBoxColumn colLogLevel;
        private DataGridViewTextBoxColumn colErrorMsg;
        private DataGridViewTextBoxColumn Properties;
    }
}