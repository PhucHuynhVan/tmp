namespace Clean.Win.AppUI.UserControls
{
    partial class ucUserManagement
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
            label1 = new System.Windows.Forms.Label();
            btnRejectChanges = new System.Windows.Forms.Button();
            chkFingerDataAvailable = new System.Windows.Forms.CheckBox();
            chkLoginAllowed = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            pnlUcPartOperation = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            btnImport = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            btnInsert = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            lblPart = new System.Windows.Forms.Label();
            grpDetail = new System.Windows.Forms.GroupBox();
            btnSetPassword = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            btnChangeGroup = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            txtWinAccount02 = new System.Windows.Forms.TextBox();
            txtRole = new System.Windows.Forms.TextBox();
            txtUserId = new System.Windows.Forms.TextBox();
            txtTelephone = new System.Windows.Forms.TextBox();
            chkActive = new System.Windows.Forms.CheckBox();
            txtActive = new System.Windows.Forms.TextBox();
            txtWinAccount01 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            mainGridView = new System.Windows.Forms.DataGridView();
            pnlUcPartOperation.SuspendLayout();
            grpDetail.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // btnRejectChanges
            // 
            btnRejectChanges.Location = new System.Drawing.Point(11, 11);
            btnRejectChanges.Name = "btnRejectChanges";
            btnRejectChanges.Size = new System.Drawing.Size(138, 51);
            btnRejectChanges.TabIndex = 0;
            btnRejectChanges.Text = "Reject Changes";
            btnRejectChanges.UseVisualStyleBackColor = true;
            btnRejectChanges.Click += btnRejectChanges_Click;
            // 
            // chkFingerDataAvailable
            // 
            chkFingerDataAvailable.AutoSize = true;
            chkFingerDataAvailable.Location = new System.Drawing.Point(433, 132);
            chkFingerDataAvailable.Name = "chkFingerDataAvailable";
            chkFingerDataAvailable.Size = new System.Drawing.Size(170, 24);
            chkFingerDataAvailable.TabIndex = 8;
            chkFingerDataAvailable.Text = "Finger data available";
            chkFingerDataAvailable.UseVisualStyleBackColor = true;
            // 
            // chkLoginAllowed
            // 
            chkLoginAllowed.AutoSize = true;
            chkLoginAllowed.Location = new System.Drawing.Point(160, 132);
            chkLoginAllowed.Name = "chkLoginAllowed";
            chkLoginAllowed.Size = new System.Drawing.Size(125, 24);
            chkLoginAllowed.TabIndex = 7;
            chkLoginAllowed.Text = "Login allowed";
            chkLoginAllowed.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 20);
            label2.TabIndex = 5;
            label2.Text = "Win.Account";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtFirstName.Location = new System.Drawing.Point(160, 60);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(637, 27);
            txtFirstName.TabIndex = 4;
            txtFirstName.Tag = "";
            // 
            // pnlUcPartOperation
            // 
            pnlUcPartOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUcPartOperation.Controls.Add(button1);
            pnlUcPartOperation.Controls.Add(btnImport);
            pnlUcPartOperation.Controls.Add(btnExport);
            pnlUcPartOperation.Controls.Add(btnInsert);
            pnlUcPartOperation.Controls.Add(btnSave);
            pnlUcPartOperation.Controls.Add(btnRejectChanges);
            pnlUcPartOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlUcPartOperation.Location = new System.Drawing.Point(3, 312);
            pnlUcPartOperation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            pnlUcPartOperation.Name = "pnlUcPartOperation";
            pnlUcPartOperation.Size = new System.Drawing.Size(1099, 81);
            pnlUcPartOperation.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(655, 11);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(138, 51);
            button1.TabIndex = 1;
            button1.Text = "Print Label";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Location = new System.Drawing.Point(944, 11);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(138, 51);
            btnImport.TabIndex = 0;
            btnImport.Text = "Excel Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new System.Drawing.Point(800, 11);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(138, 51);
            btnExport.TabIndex = 0;
            btnExport.Text = "Excel Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(299, 11);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(138, 51);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(155, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(138, 51);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(160, 24);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(637, 27);
            txtName.TabIndex = 1;
            txtName.Tag = "";
            // 
            // lblPart
            // 
            lblPart.AutoSize = true;
            lblPart.Location = new System.Drawing.Point(21, 24);
            lblPart.Name = "lblPart";
            lblPart.Size = new System.Drawing.Size(49, 20);
            lblPart.TabIndex = 0;
            lblPart.Text = "Name";
            // 
            // grpDetail
            // 
            grpDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            grpDetail.Controls.Add(btnSetPassword);
            grpDetail.Controls.Add(label8);
            grpDetail.Controls.Add(btnChangeGroup);
            grpDetail.Controls.Add(button6);
            grpDetail.Controls.Add(button7);
            grpDetail.Controls.Add(button4);
            grpDetail.Controls.Add(button5);
            grpDetail.Controls.Add(button3);
            grpDetail.Controls.Add(button2);
            grpDetail.Controls.Add(txtWinAccount02);
            grpDetail.Controls.Add(txtRole);
            grpDetail.Controls.Add(txtUserId);
            grpDetail.Controls.Add(txtTelephone);
            grpDetail.Controls.Add(chkActive);
            grpDetail.Controls.Add(txtActive);
            grpDetail.Controls.Add(txtWinAccount01);
            grpDetail.Controls.Add(label6);
            grpDetail.Controls.Add(label7);
            grpDetail.Controls.Add(label3);
            grpDetail.Controls.Add(label4);
            grpDetail.Controls.Add(label5);
            grpDetail.Controls.Add(chkFingerDataAvailable);
            grpDetail.Controls.Add(chkLoginAllowed);
            grpDetail.Controls.Add(label2);
            grpDetail.Controls.Add(txtFirstName);
            grpDetail.Controls.Add(label1);
            grpDetail.Controls.Add(pnlUcPartOperation);
            grpDetail.Controls.Add(txtName);
            grpDetail.Controls.Add(lblPart);
            grpDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            grpDetail.Location = new System.Drawing.Point(0, 291);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new System.Drawing.Size(1105, 396);
            grpDetail.TabIndex = 10;
            grpDetail.TabStop = false;
            grpDetail.Text = "User Group";
            // 
            // btnSetPassword
            // 
            btnSetPassword.Location = new System.Drawing.Point(755, 231);
            btnSetPassword.Name = "btnSetPassword";
            btnSetPassword.Size = new System.Drawing.Size(42, 31);
            btnSetPassword.TabIndex = 29;
            btnSetPassword.Text = "...";
            btnSetPassword.UseVisualStyleBackColor = true;
            btnSetPassword.Click += btnSetPassword_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(683, 236);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 20);
            label8.TabIndex = 28;
            label8.Text = "Password";
            // 
            // btnChangeGroup
            // 
            btnChangeGroup.Location = new System.Drawing.Point(755, 267);
            btnChangeGroup.Name = "btnChangeGroup";
            btnChangeGroup.Size = new System.Drawing.Size(42, 31);
            btnChangeGroup.TabIndex = 27;
            btnChangeGroup.Text = "...";
            btnChangeGroup.UseVisualStyleBackColor = true;
            btnChangeGroup.Click += btnChangeGroup_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(755, 128);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(42, 31);
            button6.TabIndex = 26;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(706, 128);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(42, 31);
            button7.TabIndex = 25;
            button7.Text = "...";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(755, 160);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(42, 31);
            button4.TabIndex = 24;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(706, 160);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(42, 31);
            button5.TabIndex = 23;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(755, 96);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(42, 31);
            button3.TabIndex = 22;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(706, 96);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(42, 31);
            button2.TabIndex = 2;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtWinAccount02
            // 
            txtWinAccount02.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtWinAccount02.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtWinAccount02.Location = new System.Drawing.Point(433, 96);
            txtWinAccount02.Name = "txtWinAccount02";
            txtWinAccount02.Size = new System.Drawing.Size(266, 27);
            txtWinAccount02.TabIndex = 21;
            txtWinAccount02.Tag = "";
            // 
            // txtRole
            // 
            txtRole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtRole.Location = new System.Drawing.Point(160, 268);
            txtRole.Name = "txtRole";
            txtRole.Size = new System.Drawing.Size(588, 27);
            txtRole.TabIndex = 20;
            txtRole.Tag = "";
            // 
            // txtUserId
            // 
            txtUserId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtUserId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtUserId.Location = new System.Drawing.Point(160, 232);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new System.Drawing.Size(501, 27);
            txtUserId.TabIndex = 19;
            txtUserId.Tag = "";
            // 
            // txtTelephone
            // 
            txtTelephone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtTelephone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTelephone.Location = new System.Drawing.Point(160, 196);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(266, 27);
            txtTelephone.TabIndex = 18;
            txtTelephone.Tag = "";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new System.Drawing.Point(160, 165);
            chkActive.Name = "chkActive";
            chkActive.Size = new System.Drawing.Size(18, 17);
            chkActive.TabIndex = 17;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // txtActive
            // 
            txtActive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtActive.Location = new System.Drawing.Point(184, 160);
            txtActive.Name = "txtActive";
            txtActive.Size = new System.Drawing.Size(515, 27);
            txtActive.TabIndex = 16;
            txtActive.Tag = "";
            // 
            // txtWinAccount01
            // 
            txtWinAccount01.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtWinAccount01.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtWinAccount01.Location = new System.Drawing.Point(160, 96);
            txtWinAccount01.Name = "txtWinAccount01";
            txtWinAccount01.Size = new System.Drawing.Size(266, 27);
            txtWinAccount01.TabIndex = 15;
            txtWinAccount01.Tag = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(21, 276);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 20);
            label6.TabIndex = 14;
            label6.Text = "User Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(21, 241);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(55, 20);
            label7.TabIndex = 13;
            label7.Text = "User Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 205);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 20);
            label3.TabIndex = 12;
            label3.Text = "Telephone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 169);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 20);
            label4.TabIndex = 11;
            label4.Text = "Active";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 133);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(123, 20);
            label5.TabIndex = 10;
            label5.Text = "ZK Finger Reader";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlGrid.Controls.Add(mainGridView);
            pnlGrid.Location = new System.Drawing.Point(0, 0);
            pnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new System.Drawing.Size(1105, 284);
            pnlGrid.TabIndex = 9;
            // 
            // mainGridView
            // 
            mainGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainGridView.Location = new System.Drawing.Point(0, 0);
            mainGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainGridView.Name = "mainGridView";
            mainGridView.ReadOnly = true;
            mainGridView.RowHeadersWidth = 51;
            mainGridView.RowTemplate.Height = 25;
            mainGridView.Size = new System.Drawing.Size(1105, 284);
            mainGridView.TabIndex = 0;
            // 
            // ucUserManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpDetail);
            Controls.Add(pnlGrid);
            Name = "ucUserManagement";
            Size = new System.Drawing.Size(1105, 687);
            Load += onFormLoad;
            pnlUcPartOperation.ResumeLayout(false);
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnRejectChanges;
        private System.Windows.Forms.CheckBox chkFingerDataAvailable;
        private System.Windows.Forms.CheckBox chkLoginAllowed;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel pnlUcPartOperation;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblPart;
        public System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView mainGridView;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtActive;
        private System.Windows.Forms.TextBox txtWinAccount01;
        private System.Windows.Forms.TextBox txtWinAccount02;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnSetPassword;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnChangeGroup;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
    }
}
