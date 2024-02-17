namespace Clean.Win.AppUI.Features
{
    partial class DebugLogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugLogForm));
            pnl = new System.Windows.Forms.Panel();
            dgrDBLog = new System.Windows.Forms.DataGridView();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTimespan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLogLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colErrorMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Properties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            richTextError = new System.Windows.Forms.RichTextBox();
            btnClose = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblToLog = new System.Windows.Forms.Label();
            lblFromLog = new System.Windows.Forms.Label();
            lblLogLevel = new System.Windows.Forms.Label();
            dtLogTo = new System.Windows.Forms.DateTimePicker();
            dtLogFrom = new System.Windows.Forms.DateTimePicker();
            cboLevel = new System.Windows.Forms.ComboBox();
            btnCopy = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDBLog).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl
            // 
            pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl.Controls.Add(dgrDBLog);
            pnl.Controls.Add(richTextError);
            pnl.Location = new System.Drawing.Point(5, 80);
            pnl.Name = "pnl";
            pnl.Size = new System.Drawing.Size(1097, 550);
            pnl.TabIndex = 0;
            // 
            // dgrDBLog
            // 
            dgrDBLog.AllowUserToAddRows = false;
            dgrDBLog.AllowUserToResizeColumns = false;
            dgrDBLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgrDBLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrDBLog.ColumnHeadersHeight = 29;
            dgrDBLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgrDBLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colTimespan, colLogLevel, colErrorMsg, Properties });
            dgrDBLog.Location = new System.Drawing.Point(7, 8);
            dgrDBLog.Name = "dgrDBLog";
            dgrDBLog.ReadOnly = true;
            dgrDBLog.RowHeadersWidth = 51;
            dgrDBLog.RowTemplate.Height = 29;
            dgrDBLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrDBLog.Size = new System.Drawing.Size(1078, 238);
            dgrDBLog.TabIndex = 1;
            dgrDBLog.CellClick += dgrDBLog_CellClick;
            dgrDBLog.RowStateChanged += dgrDBLog_RowStateChanged;
            // 
            // colID
            // 
            colID.DataPropertyName = "Id";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 75;
            // 
            // colTimespan
            // 
            colTimespan.DataPropertyName = "TimeStamp";
            colTimespan.HeaderText = "Date";
            colTimespan.MinimumWidth = 6;
            colTimespan.Name = "colTimespan";
            colTimespan.ReadOnly = true;
            colTimespan.Width = 165;
            // 
            // colLogLevel
            // 
            colLogLevel.DataPropertyName = "Level";
            colLogLevel.HeaderText = "Level";
            colLogLevel.MinimumWidth = 6;
            colLogLevel.Name = "colLogLevel";
            colLogLevel.ReadOnly = true;
            colLogLevel.Width = 145;
            // 
            // colErrorMsg
            // 
            colErrorMsg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colErrorMsg.DataPropertyName = "RenderedMessage";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            colErrorMsg.DefaultCellStyle = dataGridViewCellStyle2;
            colErrorMsg.HeaderText = "Message";
            colErrorMsg.MinimumWidth = 6;
            colErrorMsg.Name = "colErrorMsg";
            colErrorMsg.ReadOnly = true;
            // 
            // Properties
            // 
            Properties.DataPropertyName = "Properties";
            Properties.HeaderText = "App Name";
            Properties.MinimumWidth = 6;
            Properties.Name = "Properties";
            Properties.ReadOnly = true;
            Properties.Width = 125;
            // 
            // richTextError
            // 
            richTextError.Location = new System.Drawing.Point(6, 252);
            richTextError.Name = "richTextError";
            richTextError.Size = new System.Drawing.Size(1077, 286);
            richTextError.TabIndex = 0;
            richTextError.Text = "";
            richTextError.KeyDown += rich_KeyDown;
            // 
            // btnClose
            // 
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(995, 636);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(108, 33);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblToLog);
            groupBox1.Controls.Add(lblFromLog);
            groupBox1.Controls.Add(lblLogLevel);
            groupBox1.Controls.Add(dtLogTo);
            groupBox1.Controls.Add(dtLogFrom);
            groupBox1.Controls.Add(cboLevel);
            groupBox1.Location = new System.Drawing.Point(5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1025, 67);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lblToLog
            // 
            lblToLog.AutoSize = true;
            lblToLog.Location = new System.Drawing.Point(589, 32);
            lblToLog.Name = "lblToLog";
            lblToLog.Size = new System.Drawing.Size(28, 20);
            lblToLog.TabIndex = 4;
            lblToLog.Text = "To:";
            // 
            // lblFromLog
            // 
            lblFromLog.AutoSize = true;
            lblFromLog.Location = new System.Drawing.Point(299, 31);
            lblFromLog.Name = "lblFromLog";
            lblFromLog.Size = new System.Drawing.Size(46, 20);
            lblFromLog.TabIndex = 3;
            lblFromLog.Text = "From:";
            // 
            // lblLogLevel
            // 
            lblLogLevel.AutoSize = true;
            lblLogLevel.Location = new System.Drawing.Point(16, 31);
            lblLogLevel.Name = "lblLogLevel";
            lblLogLevel.Size = new System.Drawing.Size(69, 20);
            lblLogLevel.TabIndex = 2;
            lblLogLevel.Text = "Log level";
            // 
            // dtLogTo
            // 
            dtLogTo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtLogTo.Enabled = false;
            dtLogTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtLogTo.Location = new System.Drawing.Point(624, 28);
            dtLogTo.Name = "dtLogTo";
            dtLogTo.Size = new System.Drawing.Size(179, 27);
            dtLogTo.TabIndex = 1;
            dtLogTo.ValueChanged += dtLogTo_ValueChanged;
            // 
            // dtLogFrom
            // 
            dtLogFrom.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtLogFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtLogFrom.Location = new System.Drawing.Point(348, 28);
            dtLogFrom.Name = "dtLogFrom";
            dtLogFrom.Size = new System.Drawing.Size(180, 27);
            dtLogFrom.TabIndex = 1;
            dtLogFrom.ValueChanged += dtLogFrom_ValueChanged;
            // 
            // cboLevel
            // 
            cboLevel.FormattingEnabled = true;
            cboLevel.Items.AddRange(new object[] { "All", "Debug", "Information", "Warning", "Error", "Fatal" });
            cboLevel.Location = new System.Drawing.Point(92, 27);
            cboLevel.Name = "cboLevel";
            cboLevel.Size = new System.Drawing.Size(187, 28);
            cboLevel.TabIndex = 0;
            cboLevel.Text = "All";
            cboLevel.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnCopy
            // 
            btnCopy.Image = (System.Drawing.Image)resources.GetObject("btnCopy.Image");
            btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCopy.Location = new System.Drawing.Point(816, 636);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(172, 33);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "Copy to clipboard";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(5, 636);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(148, 33);
            button1.TabIndex = 5;
            button1.Text = "Send as report";
            button1.UseVisualStyleBackColor = true;
            // 
            // DebugLogForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1114, 677);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(btnCopy);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(pnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DebugLogForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DBLog information";
            FormClosing += DebugLogForm_FormClosing;
            FormClosed += DebugLogForm_FormClosed;
            Load += DebugLogForm_Load;
            pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrDBLog).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimespan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Properties;
    }
}