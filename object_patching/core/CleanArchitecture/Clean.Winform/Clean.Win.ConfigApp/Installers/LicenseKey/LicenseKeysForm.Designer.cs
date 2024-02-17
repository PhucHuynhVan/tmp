namespace Clean.Win.AppUI.Installers.LicenseKey
{
    partial class LicenseKeysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseKeysForm));
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblDayOfUsage = new System.Windows.Forms.Label();
            cboTrialDays = new System.Windows.Forms.ComboBox();
            txtLicenseKey = new System.Windows.Forms.TextBox();
            radLicenseKey = new System.Windows.Forms.RadioButton();
            radTrialKey = new System.Windows.Forms.RadioButton();
            btnProcess = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDayOfUsage);
            groupBox1.Controls.Add(cboTrialDays);
            groupBox1.Controls.Add(txtLicenseKey);
            groupBox1.Controls.Add(radLicenseKey);
            groupBox1.Controls.Add(radTrialKey);
            groupBox1.Location = new System.Drawing.Point(11, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(534, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "License key information";
            // 
            // lblDayOfUsage
            // 
            lblDayOfUsage.AutoSize = true;
            lblDayOfUsage.Location = new System.Drawing.Point(222, 79);
            lblDayOfUsage.Name = "lblDayOfUsage";
            lblDayOfUsage.Size = new System.Drawing.Size(42, 20);
            lblDayOfUsage.TabIndex = 4;
            lblDayOfUsage.Text = "days.";
            // 
            // cboTrialDays
            // 
            cboTrialDays.FormattingEnabled = true;
            cboTrialDays.Items.AddRange(new object[] { "3", "7", "14", "30" });
            cboTrialDays.Location = new System.Drawing.Point(22, 76);
            cboTrialDays.Name = "cboTrialDays";
            cboTrialDays.Size = new System.Drawing.Size(194, 28);
            cboTrialDays.TabIndex = 3;
            cboTrialDays.SelectedIndexChanged += cboTrialDays_SelectedIndexChanged;
            // 
            // txtLicenseKey
            // 
            txtLicenseKey.Location = new System.Drawing.Point(22, 77);
            txtLicenseKey.Name = "txtLicenseKey";
            txtLicenseKey.Size = new System.Drawing.Size(491, 27);
            txtLicenseKey.TabIndex = 2;
            txtLicenseKey.Visible = false;
            txtLicenseKey.TextChanged += txtLicenseKey_TextChanged;
            // 
            // radLicenseKey
            // 
            radLicenseKey.AutoSize = true;
            radLicenseKey.Location = new System.Drawing.Point(112, 26);
            radLicenseKey.Name = "radLicenseKey";
            radLicenseKey.Size = new System.Drawing.Size(104, 24);
            radLicenseKey.TabIndex = 1;
            radLicenseKey.Text = "License key";
            radLicenseKey.UseVisualStyleBackColor = true;
            radLicenseKey.CheckedChanged += radLicenseKey_CheckedChanged;
            // 
            // radTrialKey
            // 
            radTrialKey.AutoSize = true;
            radTrialKey.Checked = true;
            radTrialKey.Location = new System.Drawing.Point(22, 26);
            radTrialKey.Name = "radTrialKey";
            radTrialKey.Size = new System.Drawing.Size(58, 24);
            radTrialKey.TabIndex = 1;
            radTrialKey.TabStop = true;
            radTrialKey.Text = "Trial";
            radTrialKey.UseVisualStyleBackColor = true;
            radTrialKey.CheckedChanged += radTrialKey_CheckedChanged;
            // 
            // btnProcess
            // 
            btnProcess.Image = (System.Drawing.Image)resources.GetObject("btnProcess.Image");
            btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProcess.Location = new System.Drawing.Point(352, 153);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new System.Drawing.Size(94, 29);
            btnProcess.TabIndex = 1;
            btnProcess.Text = "OK";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(452, 153);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(12, 153);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(0, 20);
            lblStatus.TabIndex = 2;
            // 
            // LicenseKeysForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(558, 194);
            Controls.Add(lblStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnProcess);
            Controls.Add(groupBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LicenseKeysForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "License key information";
            FormClosed += LicenseKeysForm_FormClosed;
            Load += LicenseKeysForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTrialDays;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.RadioButton radLicenseKey;
        private System.Windows.Forms.RadioButton radTrialKey;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDayOfUsage;
        private System.Windows.Forms.Label lblStatus;
    }
}