namespace Clean.Win.AppUI.UserControls
{
    partial class ucDBInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMainContent = new System.Windows.Forms.Label();
            grpDatabaseInformation = new System.Windows.Forms.GroupBox();
            lblMiscellaneousValue = new System.Windows.Forms.Label();
            lblMiscellaneousName = new System.Windows.Forms.Label();
            lblRequiredVersionValue = new System.Windows.Forms.Label();
            lblRequiredVersionName = new System.Windows.Forms.Label();
            lblOpennedDBValue = new System.Windows.Forms.Label();
            lblOpenedDBName = new System.Windows.Forms.Label();
            lblDBPathFileValue = new System.Windows.Forms.Label();
            lblDBFilePathName = new System.Windows.Forms.Label();
            grpDatabaseInformation.SuspendLayout();
            SuspendLayout();
            // 
            // lblMainContent
            // 
            lblMainContent.AutoSize = true;
            lblMainContent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMainContent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblMainContent.Location = new System.Drawing.Point(18, 18);
            lblMainContent.Name = "lblMainContent";
            lblMainContent.Size = new System.Drawing.Size(269, 31);
            lblMainContent.TabIndex = 1;
            lblMainContent.Text = "Database Configuration";
            // 
            // grpDatabaseInformation
            // 
            grpDatabaseInformation.Controls.Add(lblMiscellaneousValue);
            grpDatabaseInformation.Controls.Add(lblMiscellaneousName);
            grpDatabaseInformation.Controls.Add(lblRequiredVersionValue);
            grpDatabaseInformation.Controls.Add(lblRequiredVersionName);
            grpDatabaseInformation.Controls.Add(lblOpennedDBValue);
            grpDatabaseInformation.Controls.Add(lblOpenedDBName);
            grpDatabaseInformation.Controls.Add(lblDBPathFileValue);
            grpDatabaseInformation.Controls.Add(lblDBFilePathName);
            grpDatabaseInformation.Location = new System.Drawing.Point(9, 66);
            grpDatabaseInformation.Name = "grpDatabaseInformation";
            grpDatabaseInformation.Size = new System.Drawing.Size(823, 567);
            grpDatabaseInformation.TabIndex = 2;
            grpDatabaseInformation.TabStop = false;
            // 
            // lblMiscellaneousValue
            // 
            lblMiscellaneousValue.AutoSize = true;
            lblMiscellaneousValue.Location = new System.Drawing.Point(17, 370);
            lblMiscellaneousValue.Name = "lblMiscellaneousValue";
            lblMiscellaneousValue.Size = new System.Drawing.Size(0, 20);
            lblMiscellaneousValue.TabIndex = 7;
            // 
            // lblMiscellaneousName
            // 
            lblMiscellaneousName.AutoSize = true;
            lblMiscellaneousName.Location = new System.Drawing.Point(17, 338);
            lblMiscellaneousName.Name = "lblMiscellaneousName";
            lblMiscellaneousName.Size = new System.Drawing.Size(105, 20);
            lblMiscellaneousName.TabIndex = 6;
            lblMiscellaneousName.Text = "Miscellaneous:";
            // 
            // lblRequiredVersionValue
            // 
            lblRequiredVersionValue.AutoSize = true;
            lblRequiredVersionValue.Location = new System.Drawing.Point(17, 269);
            lblRequiredVersionValue.Name = "lblRequiredVersionValue";
            lblRequiredVersionValue.Size = new System.Drawing.Size(0, 20);
            lblRequiredVersionValue.TabIndex = 5;
            // 
            // lblRequiredVersionName
            // 
            lblRequiredVersionName.AutoSize = true;
            lblRequiredVersionName.Location = new System.Drawing.Point(14, 226);
            lblRequiredVersionName.Name = "lblRequiredVersionName";
            lblRequiredVersionName.Size = new System.Drawing.Size(123, 20);
            lblRequiredVersionName.TabIndex = 4;
            lblRequiredVersionName.Text = "Required version:";
            // 
            // lblOpennedDBValue
            // 
            lblOpennedDBValue.AutoSize = true;
            lblOpennedDBValue.Location = new System.Drawing.Point(14, 156);
            lblOpennedDBValue.Name = "lblOpennedDBValue";
            lblOpennedDBValue.Size = new System.Drawing.Size(0, 20);
            lblOpennedDBValue.TabIndex = 3;
            // 
            // lblOpenedDBName
            // 
            lblOpenedDBName.AutoSize = true;
            lblOpenedDBName.Location = new System.Drawing.Point(14, 120);
            lblOpenedDBName.Name = "lblOpenedDBName";
            lblOpenedDBName.Size = new System.Drawing.Size(138, 20);
            lblOpenedDBName.TabIndex = 2;
            lblOpenedDBName.Text = "Openned database:";
            // 
            // lblDBPathFileValue
            // 
            lblDBPathFileValue.AutoSize = true;
            lblDBPathFileValue.Location = new System.Drawing.Point(14, 58);
            lblDBPathFileValue.Name = "lblDBPathFileValue";
            lblDBPathFileValue.Size = new System.Drawing.Size(0, 20);
            lblDBPathFileValue.TabIndex = 1;
            // 
            // lblDBFilePathName
            // 
            lblDBFilePathName.AutoSize = true;
            lblDBFilePathName.Location = new System.Drawing.Point(14, 23);
            lblDBFilePathName.Name = "lblDBFilePathName";
            lblDBFilePathName.Size = new System.Drawing.Size(126, 20);
            lblDBFilePathName.TabIndex = 0;
            lblDBFilePathName.Text = "Connected to file:";
            // 
            // ucDBInformation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpDatabaseInformation);
            Controls.Add(lblMainContent);
            Name = "ucDBInformation";
            Size = new System.Drawing.Size(990, 636);
            grpDatabaseInformation.ResumeLayout(false);
            grpDatabaseInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMainContent;
        private System.Windows.Forms.GroupBox grpDatabaseInformation;
        private System.Windows.Forms.Label lblMiscellaneousValue;
        private System.Windows.Forms.Label lblMiscellaneousName;
        private System.Windows.Forms.Label lblRequiredVersionValue;
        private System.Windows.Forms.Label lblRequiredVersionName;
        private System.Windows.Forms.Label lblOpennedDBValue;
        private System.Windows.Forms.Label lblOpenedDBName;
        private System.Windows.Forms.Label lblDBPathFileValue;
        private System.Windows.Forms.Label lblDBFilePathName;
    }
}
