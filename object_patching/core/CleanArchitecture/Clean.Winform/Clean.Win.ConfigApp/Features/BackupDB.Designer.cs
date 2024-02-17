namespace Clean.Win.AppUI.Features.BackupDB
{
    partial class BackupDBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupDBForm));
            grpDBInformation = new System.Windows.Forms.GroupBox();
            btnSourceOpen = new System.Windows.Forms.Button();
            txtBackupDatabase = new System.Windows.Forms.TextBox();
            txtSourceDatabase = new System.Windows.Forms.TextBox();
            lblBakupDestination = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnOpenBackupDB = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnProcess = new System.Windows.Forms.Button();
            grpDBInformation.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDBInformation
            // 
            grpDBInformation.Controls.Add(btnSourceOpen);
            grpDBInformation.Controls.Add(txtBackupDatabase);
            grpDBInformation.Controls.Add(txtSourceDatabase);
            grpDBInformation.Controls.Add(lblBakupDestination);
            grpDBInformation.Controls.Add(label1);
            grpDBInformation.Location = new System.Drawing.Point(12, 1);
            grpDBInformation.Name = "grpDBInformation";
            grpDBInformation.Size = new System.Drawing.Size(819, 157);
            grpDBInformation.TabIndex = 0;
            grpDBInformation.TabStop = false;
            grpDBInformation.Text = "Database information";
            // 
            // btnSourceOpen
            // 
            btnSourceOpen.Location = new System.Drawing.Point(773, 42);
            btnSourceOpen.Name = "btnSourceOpen";
            btnSourceOpen.Size = new System.Drawing.Size(33, 29);
            btnSourceOpen.TabIndex = 5;
            btnSourceOpen.Text = "...";
            btnSourceOpen.UseVisualStyleBackColor = true;
            btnSourceOpen.Click += btnSourceOpen_Click;
            // 
            // txtBackupDatabase
            // 
            txtBackupDatabase.Enabled = false;
            txtBackupDatabase.Location = new System.Drawing.Point(139, 98);
            txtBackupDatabase.Name = "txtBackupDatabase";
            txtBackupDatabase.Size = new System.Drawing.Size(628, 27);
            txtBackupDatabase.TabIndex = 3;
            // 
            // txtSourceDatabase
            // 
            txtSourceDatabase.Location = new System.Drawing.Point(139, 42);
            txtSourceDatabase.Name = "txtSourceDatabase";
            txtSourceDatabase.ReadOnly = true;
            txtSourceDatabase.Size = new System.Drawing.Size(628, 27);
            txtSourceDatabase.TabIndex = 2;
            // 
            // lblBakupDestination
            // 
            lblBakupDestination.AutoSize = true;
            lblBakupDestination.Location = new System.Drawing.Point(8, 98);
            lblBakupDestination.Name = "lblBakupDestination";
            lblBakupDestination.Size = new System.Drawing.Size(125, 20);
            lblBakupDestination.TabIndex = 1;
            lblBakupDestination.Text = "Backup database:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Source database:";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnOpenBackupDB);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnProcess);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 172);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(844, 57);
            panel1.TabIndex = 2;
            // 
            // btnOpenBackupDB
            // 
            btnOpenBackupDB.Enabled = false;
            btnOpenBackupDB.Image = (System.Drawing.Image)resources.GetObject("btnOpenBackupDB.Image");
            btnOpenBackupDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOpenBackupDB.Location = new System.Drawing.Point(19, 15);
            btnOpenBackupDB.Name = "btnOpenBackupDB";
            btnOpenBackupDB.Size = new System.Drawing.Size(194, 29);
            btnOpenBackupDB.TabIndex = 7;
            btnOpenBackupDB.Text = "Open BackupDB path";
            btnOpenBackupDB.UseVisualStyleBackColor = true;
            btnOpenBackupDB.Click += btnOpenBackupDB_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(732, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(97, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnProcess
            // 
            btnProcess.Image = (System.Drawing.Image)resources.GetObject("btnProcess.Image");
            btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProcess.Location = new System.Drawing.Point(603, 15);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new System.Drawing.Size(121, 29);
            btnProcess.TabIndex = 5;
            btnProcess.Text = "BackupDB";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // BackupDBForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(844, 229);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(grpDBInformation);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BackupDBForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Backup database";
            FormClosed += BackupDBForm_FormClosed;
            Load += BackupDBForm_Load;
            grpDBInformation.ResumeLayout(false);
            grpDBInformation.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDBInformation;

        private System.Windows.Forms.TextBox txtBackupDatabase;
        private System.Windows.Forms.TextBox txtSourceDatabase;
        private System.Windows.Forms.Label lblBakupDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnSourceOpen;
        private System.Windows.Forms.Button btnOpenBackupDB;
    }
}