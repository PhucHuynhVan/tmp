namespace Clean.Win.AppUI.UserControls
{
    partial class ucComputer
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
            System.Windows.Forms.Label lblInterfaceBarcodePrinter;
            panel1 = new System.Windows.Forms.Panel();
            mainGridView = new System.Windows.Forms.DataGridView();
            txtDirectoryinProtocolFiles = new System.Windows.Forms.TextBox();
            lblDirectoryinProtocolFiles = new System.Windows.Forms.Label();
            txtDirectoryOfProtocolDatabases = new System.Windows.Forms.TextBox();
            lblDirectoryOfProtocolDatabases = new System.Windows.Forms.Label();
            txtArchiveAllProtocolAfterXdays = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            pnlUcOperation = new System.Windows.Forms.Panel();
            btnRejectChanges = new System.Windows.Forms.Button();
            lblArchiveAllProtocolAfterXdays = new System.Windows.Forms.Label();
            txtInterfaceBarcodePrinter = new System.Windows.Forms.TextBox();
            btnLanguageBiasysDB = new System.Windows.Forms.Button();
            txtLanguageBiasysDB = new System.Windows.Forms.TextBox();
            lblLanguageBiasysDB = new System.Windows.Forms.Label();
            btnLanguageBiasysControl = new System.Windows.Forms.Button();
            txtLanguageBiasysControl = new System.Windows.Forms.TextBox();
            lblLanguageBiasysControl = new System.Windows.Forms.Label();
            grpDetail = new System.Windows.Forms.GroupBox();
            lblInterfaceBarcodePrinter = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).BeginInit();
            pnlUcOperation.SuspendLayout();
            grpDetail.SuspendLayout();
            SuspendLayout();
            // 
            // lblInterfaceBarcodePrinter
            // 
            lblInterfaceBarcodePrinter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblInterfaceBarcodePrinter.AutoSize = true;
            lblInterfaceBarcodePrinter.Location = new System.Drawing.Point(38, 143);
            lblInterfaceBarcodePrinter.Name = "lblInterfaceBarcodePrinter";
            lblInterfaceBarcodePrinter.Size = new System.Drawing.Size(173, 20);
            lblInterfaceBarcodePrinter.TabIndex = 10;
            lblInterfaceBarcodePrinter.Text = "Interface Barcode Printer";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(mainGridView);
            panel1.Location = new System.Drawing.Point(3, 1);
            panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(360, 597);
            panel1.TabIndex = 16;
            // 
            // mainGridView
            // 
            mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            mainGridView.Location = new System.Drawing.Point(0, 0);
            mainGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainGridView.Name = "mainGridView";
            mainGridView.ReadOnly = true;
            mainGridView.RowHeadersWidth = 51;
            mainGridView.RowTemplate.Height = 25;
            mainGridView.Size = new System.Drawing.Size(358, 595);
            mainGridView.TabIndex = 12;
            // 
            // txtDirectoryinProtocolFiles
            // 
            txtDirectoryinProtocolFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDirectoryinProtocolFiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtDirectoryinProtocolFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtDirectoryinProtocolFiles.Location = new System.Drawing.Point(38, 479);
            txtDirectoryinProtocolFiles.Name = "txtDirectoryinProtocolFiles";
            txtDirectoryinProtocolFiles.Size = new System.Drawing.Size(650, 27);
            txtDirectoryinProtocolFiles.TabIndex = 21;
            txtDirectoryinProtocolFiles.Tag = "PartName";
            // 
            // lblDirectoryinProtocolFiles
            // 
            lblDirectoryinProtocolFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDirectoryinProtocolFiles.AutoSize = true;
            lblDirectoryinProtocolFiles.Location = new System.Drawing.Point(38, 456);
            lblDirectoryinProtocolFiles.Name = "lblDirectoryinProtocolFiles";
            lblDirectoryinProtocolFiles.Size = new System.Drawing.Size(562, 20);
            lblDirectoryinProtocolFiles.TabIndex = 20;
            lblDirectoryinProtocolFiles.Text = "Directory in that Protocol Files (=Production Data Files) are written by BiasysControl";
            // 
            // txtDirectoryOfProtocolDatabases
            // 
            txtDirectoryOfProtocolDatabases.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDirectoryOfProtocolDatabases.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtDirectoryOfProtocolDatabases.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtDirectoryOfProtocolDatabases.Location = new System.Drawing.Point(38, 373);
            txtDirectoryOfProtocolDatabases.Name = "txtDirectoryOfProtocolDatabases";
            txtDirectoryOfProtocolDatabases.Size = new System.Drawing.Size(650, 27);
            txtDirectoryOfProtocolDatabases.TabIndex = 19;
            txtDirectoryOfProtocolDatabases.Tag = "PartName";
            // 
            // lblDirectoryOfProtocolDatabases
            // 
            lblDirectoryOfProtocolDatabases.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDirectoryOfProtocolDatabases.AutoSize = true;
            lblDirectoryOfProtocolDatabases.Location = new System.Drawing.Point(38, 350);
            lblDirectoryOfProtocolDatabases.Name = "lblDirectoryOfProtocolDatabases";
            lblDirectoryOfProtocolDatabases.Size = new System.Drawing.Size(306, 20);
            lblDirectoryOfProtocolDatabases.TabIndex = 18;
            lblDirectoryOfProtocolDatabases.Text = "Directory of the archived Protocol Databases";
            // 
            // txtArchiveAllProtocolAfterXdays
            // 
            txtArchiveAllProtocolAfterXdays.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtArchiveAllProtocolAfterXdays.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtArchiveAllProtocolAfterXdays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtArchiveAllProtocolAfterXdays.Location = new System.Drawing.Point(38, 263);
            txtArchiveAllProtocolAfterXdays.Name = "txtArchiveAllProtocolAfterXdays";
            txtArchiveAllProtocolAfterXdays.Size = new System.Drawing.Size(200, 27);
            txtArchiveAllProtocolAfterXdays.TabIndex = 17;
            txtArchiveAllProtocolAfterXdays.Tag = "PartName";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(164, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(138, 51);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pnlUcOperation
            // 
            pnlUcOperation.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlUcOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUcOperation.Controls.Add(btnSave);
            pnlUcOperation.Controls.Add(btnRejectChanges);
            pnlUcOperation.Location = new System.Drawing.Point(3, 604);
            pnlUcOperation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            pnlUcOperation.Name = "pnlUcOperation";
            pnlUcOperation.Size = new System.Drawing.Size(1099, 81);
            pnlUcOperation.TabIndex = 14;
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
            // lblArchiveAllProtocolAfterXdays
            // 
            lblArchiveAllProtocolAfterXdays.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblArchiveAllProtocolAfterXdays.AutoSize = true;
            lblArchiveAllProtocolAfterXdays.Location = new System.Drawing.Point(38, 240);
            lblArchiveAllProtocolAfterXdays.Name = "lblArchiveAllProtocolAfterXdays";
            lblArchiveAllProtocolAfterXdays.Size = new System.Drawing.Size(237, 20);
            lblArchiveAllProtocolAfterXdays.TabIndex = 16;
            lblArchiveAllProtocolAfterXdays.Text = "Archive all protocols after [X] days";
            // 
            // txtInterfaceBarcodePrinter
            // 
            txtInterfaceBarcodePrinter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtInterfaceBarcodePrinter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtInterfaceBarcodePrinter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtInterfaceBarcodePrinter.Location = new System.Drawing.Point(38, 166);
            txtInterfaceBarcodePrinter.Name = "txtInterfaceBarcodePrinter";
            txtInterfaceBarcodePrinter.ReadOnly = true;
            txtInterfaceBarcodePrinter.Size = new System.Drawing.Size(200, 27);
            txtInterfaceBarcodePrinter.TabIndex = 15;
            txtInterfaceBarcodePrinter.Tag = "PartName";
            // 
            // btnLanguageBiasysDB
            // 
            btnLanguageBiasysDB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnLanguageBiasysDB.Location = new System.Drawing.Point(523, 72);
            btnLanguageBiasysDB.Name = "btnLanguageBiasysDB";
            btnLanguageBiasysDB.Size = new System.Drawing.Size(40, 27);
            btnLanguageBiasysDB.TabIndex = 14;
            btnLanguageBiasysDB.UseVisualStyleBackColor = true;
            btnLanguageBiasysDB.Click += btnLanguageBiasysDB_Click;
            // 
            // txtLanguageBiasysDB
            // 
            txtLanguageBiasysDB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLanguageBiasysDB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtLanguageBiasysDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtLanguageBiasysDB.Location = new System.Drawing.Point(317, 72);
            txtLanguageBiasysDB.Name = "txtLanguageBiasysDB";
            txtLanguageBiasysDB.ReadOnly = true;
            txtLanguageBiasysDB.Size = new System.Drawing.Size(200, 27);
            txtLanguageBiasysDB.TabIndex = 13;
            txtLanguageBiasysDB.Tag = "PartName";
            // 
            // lblLanguageBiasysDB
            // 
            lblLanguageBiasysDB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLanguageBiasysDB.AutoSize = true;
            lblLanguageBiasysDB.Location = new System.Drawing.Point(317, 49);
            lblLanguageBiasysDB.Name = "lblLanguageBiasysDB";
            lblLanguageBiasysDB.Size = new System.Drawing.Size(138, 20);
            lblLanguageBiasysDB.TabIndex = 12;
            lblLanguageBiasysDB.Text = "Language BiasysDB";
            // 
            // btnLanguageBiasysControl
            // 
            btnLanguageBiasysControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnLanguageBiasysControl.Location = new System.Drawing.Point(244, 72);
            btnLanguageBiasysControl.Name = "btnLanguageBiasysControl";
            btnLanguageBiasysControl.Size = new System.Drawing.Size(40, 27);
            btnLanguageBiasysControl.TabIndex = 11;
            btnLanguageBiasysControl.UseVisualStyleBackColor = true;
            btnLanguageBiasysControl.Click += btnLanguageBiasysControl_Click;
            // 
            // txtLanguageBiasysControl
            // 
            txtLanguageBiasysControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLanguageBiasysControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtLanguageBiasysControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtLanguageBiasysControl.Location = new System.Drawing.Point(38, 72);
            txtLanguageBiasysControl.Name = "txtLanguageBiasysControl";
            txtLanguageBiasysControl.ReadOnly = true;
            txtLanguageBiasysControl.Size = new System.Drawing.Size(200, 27);
            txtLanguageBiasysControl.TabIndex = 1;
            txtLanguageBiasysControl.Tag = "PartName";
            // 
            // lblLanguageBiasysControl
            // 
            lblLanguageBiasysControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLanguageBiasysControl.AutoSize = true;
            lblLanguageBiasysControl.Location = new System.Drawing.Point(38, 49);
            lblLanguageBiasysControl.Name = "lblLanguageBiasysControl";
            lblLanguageBiasysControl.Size = new System.Drawing.Size(167, 20);
            lblLanguageBiasysControl.TabIndex = 0;
            lblLanguageBiasysControl.Text = "Language BiasysControl";
            // 
            // grpDetail
            // 
            grpDetail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            grpDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            grpDetail.Controls.Add(txtDirectoryinProtocolFiles);
            grpDetail.Controls.Add(lblDirectoryinProtocolFiles);
            grpDetail.Controls.Add(txtDirectoryOfProtocolDatabases);
            grpDetail.Controls.Add(lblDirectoryOfProtocolDatabases);
            grpDetail.Controls.Add(txtArchiveAllProtocolAfterXdays);
            grpDetail.Controls.Add(lblArchiveAllProtocolAfterXdays);
            grpDetail.Controls.Add(txtInterfaceBarcodePrinter);
            grpDetail.Controls.Add(btnLanguageBiasysDB);
            grpDetail.Controls.Add(txtLanguageBiasysDB);
            grpDetail.Controls.Add(lblLanguageBiasysDB);
            grpDetail.Controls.Add(btnLanguageBiasysControl);
            grpDetail.Controls.Add(lblInterfaceBarcodePrinter);
            grpDetail.Controls.Add(txtLanguageBiasysControl);
            grpDetail.Controls.Add(lblLanguageBiasysControl);
            grpDetail.Location = new System.Drawing.Point(369, 1);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new System.Drawing.Size(733, 597);
            grpDetail.TabIndex = 15;
            grpDetail.TabStop = false;
            // 
            // ucComputer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pnlUcOperation);
            Controls.Add(grpDetail);
            Name = "ucComputer";
            Size = new System.Drawing.Size(1105, 687);
            Load += onFormLoad;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainGridView).EndInit();
            pnlUcOperation.ResumeLayout(false);
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.TextBox txtDirectoryinProtocolFiles;
        public System.Windows.Forms.Label lblDirectoryinProtocolFiles;
        private System.Windows.Forms.TextBox txtDirectoryOfProtocolDatabases;
        public System.Windows.Forms.Label lblDirectoryOfProtocolDatabases;
        private System.Windows.Forms.TextBox txtArchiveAllProtocolAfterXdays;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlUcOperation;
        public System.Windows.Forms.Button btnRejectChanges;
        public System.Windows.Forms.Label lblArchiveAllProtocolAfterXdays;
        private System.Windows.Forms.TextBox txtInterfaceBarcodePrinter;
        public System.Windows.Forms.Button btnLanguageBiasysDB;
        private System.Windows.Forms.TextBox txtLanguageBiasysDB;
        public System.Windows.Forms.Label lblLanguageBiasysDB;
        public System.Windows.Forms.Button btnLanguageBiasysControl;
        private System.Windows.Forms.TextBox txtLanguageBiasysControl;
        public System.Windows.Forms.Label lblLanguageBiasysControl;
        public System.Windows.Forms.GroupBox grpDetail;
    }
}
