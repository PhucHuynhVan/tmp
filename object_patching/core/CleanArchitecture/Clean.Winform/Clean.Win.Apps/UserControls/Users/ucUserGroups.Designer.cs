namespace Clean.Win.AppUI.UserControls.Users
{
    partial class ucUserGroups
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
            grpUserPermissions = new System.Windows.Forms.GroupBox();
            txtUserGroup = new System.Windows.Forms.TextBox();
            lblUserGroup = new System.Windows.Forms.Label();
            pnlUserPermissions = new System.Windows.Forms.Panel();
            userPermissionsGridView = new System.Windows.Forms.DataGridView();
            pnlOperations = new System.Windows.Forms.Panel();
            btnInsert = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnRejectChanges = new System.Windows.Forms.Button();
            grpUserGroup = new System.Windows.Forms.GroupBox();
            panel3 = new System.Windows.Forms.Panel();
            userGroupGridView = new System.Windows.Forms.DataGridView();
            grpUserPermissions.SuspendLayout();
            pnlUserPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPermissionsGridView).BeginInit();
            pnlOperations.SuspendLayout();
            grpUserGroup.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userGroupGridView).BeginInit();
            SuspendLayout();
            // 
            // grpUserPermissions
            // 
            grpUserPermissions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpUserPermissions.Controls.Add(txtUserGroup);
            grpUserPermissions.Controls.Add(lblUserGroup);
            grpUserPermissions.Controls.Add(pnlUserPermissions);
            grpUserPermissions.Controls.Add(pnlOperations);
            grpUserPermissions.Location = new System.Drawing.Point(3, 200);
            grpUserPermissions.Name = "grpUserPermissions";
            grpUserPermissions.Size = new System.Drawing.Size(1099, 484);
            grpUserPermissions.TabIndex = 0;
            grpUserPermissions.TabStop = false;
            grpUserPermissions.Text = "User Permissions";
            // 
            // txtUserGroup
            // 
            txtUserGroup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtUserGroup.Location = new System.Drawing.Point(119, 33);
            txtUserGroup.Name = "txtUserGroup";
            txtUserGroup.Size = new System.Drawing.Size(967, 27);
            txtUserGroup.TabIndex = 3;
            // 
            // lblUserGroup
            // 
            lblUserGroup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUserGroup.AutoSize = true;
            lblUserGroup.Location = new System.Drawing.Point(6, 35);
            lblUserGroup.Name = "lblUserGroup";
            lblUserGroup.Size = new System.Drawing.Size(83, 20);
            lblUserGroup.TabIndex = 2;
            lblUserGroup.Text = "User Group";
            // 
            // pnlUserPermissions
            // 
            pnlUserPermissions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlUserPermissions.Controls.Add(userPermissionsGridView);
            pnlUserPermissions.Location = new System.Drawing.Point(6, 72);
            pnlUserPermissions.Name = "pnlUserPermissions";
            pnlUserPermissions.Size = new System.Drawing.Size(1087, 315);
            pnlUserPermissions.TabIndex = 1;
            // 
            // userPermissionsGridView
            // 
            userPermissionsGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            userPermissionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userPermissionsGridView.Location = new System.Drawing.Point(0, 0);
            userPermissionsGridView.Name = "userPermissionsGridView";
            userPermissionsGridView.RowHeadersWidth = 51;
            userPermissionsGridView.RowTemplate.Height = 29;
            userPermissionsGridView.Size = new System.Drawing.Size(1087, 315);
            userPermissionsGridView.TabIndex = 0;
            // 
            // pnlOperations
            // 
            pnlOperations.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlOperations.Controls.Add(btnInsert);
            pnlOperations.Controls.Add(btnSave);
            pnlOperations.Controls.Add(btnRejectChanges);
            pnlOperations.Location = new System.Drawing.Point(6, 393);
            pnlOperations.Name = "pnlOperations";
            pnlOperations.Size = new System.Drawing.Size(1087, 85);
            pnlOperations.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnInsert.Location = new System.Drawing.Point(364, 16);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(138, 51);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnSave.Location = new System.Drawing.Point(193, 16);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(138, 51);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRejectChanges
            // 
            btnRejectChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRejectChanges.Location = new System.Drawing.Point(22, 16);
            btnRejectChanges.Name = "btnRejectChanges";
            btnRejectChanges.Size = new System.Drawing.Size(138, 51);
            btnRejectChanges.TabIndex = 0;
            btnRejectChanges.Text = "Reject Changes";
            btnRejectChanges.UseVisualStyleBackColor = true;
            btnRejectChanges.Click += btnRejectChanges_Click;
            // 
            // grpUserGroup
            // 
            grpUserGroup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpUserGroup.Controls.Add(panel3);
            grpUserGroup.Location = new System.Drawing.Point(7, 7);
            grpUserGroup.Name = "grpUserGroup";
            grpUserGroup.Size = new System.Drawing.Size(1095, 194);
            grpUserGroup.TabIndex = 1;
            grpUserGroup.TabStop = false;
            grpUserGroup.Text = "User Group";
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel3.Controls.Add(userGroupGridView);
            panel3.Location = new System.Drawing.Point(11, 28);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1075, 156);
            panel3.TabIndex = 0;
            // 
            // userGroupGridView
            // 
            userGroupGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            userGroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGroupGridView.Location = new System.Drawing.Point(0, 0);
            userGroupGridView.Name = "userGroupGridView";
            userGroupGridView.RowHeadersWidth = 51;
            userGroupGridView.RowTemplate.Height = 29;
            userGroupGridView.Size = new System.Drawing.Size(1075, 156);
            userGroupGridView.TabIndex = 0;
            // 
            // ucUserGroups
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpUserGroup);
            Controls.Add(grpUserPermissions);
            Name = "ucUserGroups";
            Size = new System.Drawing.Size(1105, 687);
            Load += onFormLoad;
            grpUserPermissions.ResumeLayout(false);
            grpUserPermissions.PerformLayout();
            pnlUserPermissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userPermissionsGridView).EndInit();
            pnlOperations.ResumeLayout(false);
            grpUserGroup.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userGroupGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpUserPermissions;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRejectChanges;
        private System.Windows.Forms.Label lblUserGroup;
        private System.Windows.Forms.Panel pnlUserPermissions;
        private System.Windows.Forms.TextBox txtUserGroup;
        private System.Windows.Forms.DataGridView userPermissionsGridView;
        private System.Windows.Forms.GroupBox grpUserGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView userGroupGridView;
    }
}
