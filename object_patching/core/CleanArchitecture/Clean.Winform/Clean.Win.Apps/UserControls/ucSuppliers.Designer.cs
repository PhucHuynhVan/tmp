namespace Clean.Win.AppUI.UserControls
{
    partial class ucSuppliers
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
            txtSupplierPlace = new System.Windows.Forms.TextBox();
            txtSupplierName = new System.Windows.Forms.TextBox();
            btnRejectChanges = new System.Windows.Forms.Button();
            txtSupplierRemark = new System.Windows.Forms.TextBox();
            lblSupplierRemark = new System.Windows.Forms.Label();
            txtSupplierFax = new System.Windows.Forms.TextBox();
            lblSupplierFax = new System.Windows.Forms.Label();
            txtSupplierTelephone = new System.Windows.Forms.TextBox();
            txtSupplierStreet = new System.Windows.Forms.TextBox();
            txtSupplierZip = new System.Windows.Forms.TextBox();
            lblSupplierTelepone = new System.Windows.Forms.Label();
            lblSupplierAddress = new System.Windows.Forms.Label();
            pnlUcPartOperation = new System.Windows.Forms.Panel();
            btnImport = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            btnInsert = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtSupplierCode = new System.Windows.Forms.TextBox();
            lblSuppiler = new System.Windows.Forms.Label();
            grpDetail = new System.Windows.Forms.GroupBox();
            mainGridView = new System.Windows.Forms.DataGridView();
            pnlGrid = new System.Windows.Forms.Panel();
            pnlUcPartOperation.SuspendLayout();
            grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).BeginInit();
            pnlGrid.SuspendLayout();
            SuspendLayout();
            // 
            // txtSupplierPlace
            // 
            txtSupplierPlace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtSupplierPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSupplierPlace.Location = new System.Drawing.Point(159, 95);
            txtSupplierPlace.Name = "txtSupplierPlace";
            txtSupplierPlace.Size = new System.Drawing.Size(927, 27);
            txtSupplierPlace.TabIndex = 6;
            txtSupplierPlace.Tag = "PartCode";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSupplierName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSupplierName.Location = new System.Drawing.Point(367, 25);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new System.Drawing.Size(1624, 27);
            txtSupplierName.TabIndex = 1;
            txtSupplierName.Tag = "PartName";
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
            // txtSupplierRemark
            // 
            txtSupplierRemark.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtSupplierRemark.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSupplierRemark.Location = new System.Drawing.Point(159, 198);
            txtSupplierRemark.Name = "txtSupplierRemark";
            txtSupplierRemark.Size = new System.Drawing.Size(927, 27);
            txtSupplierRemark.TabIndex = 13;
            txtSupplierRemark.Tag = "PartCode";
            // 
            // lblSupplierRemark
            // 
            lblSupplierRemark.AutoSize = true;
            lblSupplierRemark.Location = new System.Drawing.Point(21, 205);
            lblSupplierRemark.Name = "lblSupplierRemark";
            lblSupplierRemark.Size = new System.Drawing.Size(59, 20);
            lblSupplierRemark.TabIndex = 12;
            lblSupplierRemark.Text = "Remark";
            // 
            // txtSupplierFax
            // 
            txtSupplierFax.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtSupplierFax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSupplierFax.Location = new System.Drawing.Point(159, 161);
            txtSupplierFax.Name = "txtSupplierFax";
            txtSupplierFax.Size = new System.Drawing.Size(927, 27);
            txtSupplierFax.TabIndex = 11;
            txtSupplierFax.Tag = "PartCode";
            // 
            // lblSupplierFax
            // 
            lblSupplierFax.AutoSize = true;
            lblSupplierFax.Location = new System.Drawing.Point(21, 168);
            lblSupplierFax.Name = "lblSupplierFax";
            lblSupplierFax.Size = new System.Drawing.Size(30, 20);
            lblSupplierFax.TabIndex = 10;
            lblSupplierFax.Text = "Fax";
            // 
            // txtSupplierTelephone
            // 
            txtSupplierTelephone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtSupplierTelephone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSupplierTelephone.Location = new System.Drawing.Point(159, 128);
            txtSupplierTelephone.Name = "txtSupplierTelephone";
            txtSupplierTelephone.Size = new System.Drawing.Size(927, 27);
            txtSupplierTelephone.TabIndex = 9;
            txtSupplierTelephone.Tag = "PartCode";
            // 
            // txtSupplierStreet
            // 
            txtSupplierStreet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSupplierStreet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtSupplierStreet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSupplierStreet.Location = new System.Drawing.Point(367, 62);
            txtSupplierStreet.Name = "txtSupplierStreet";
            txtSupplierStreet.Size = new System.Drawing.Size(1624, 27);
            txtSupplierStreet.TabIndex = 8;
            txtSupplierStreet.Tag = "PartName";
            // 
            // txtSupplierZip
            // 
            txtSupplierZip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtSupplierZip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSupplierZip.Location = new System.Drawing.Point(159, 62);
            txtSupplierZip.Name = "txtSupplierZip";
            txtSupplierZip.Size = new System.Drawing.Size(191, 27);
            txtSupplierZip.TabIndex = 7;
            txtSupplierZip.Tag = "PartCode";
            // 
            // lblSupplierTelepone
            // 
            lblSupplierTelepone.AutoSize = true;
            lblSupplierTelepone.Location = new System.Drawing.Point(21, 135);
            lblSupplierTelepone.Name = "lblSupplierTelepone";
            lblSupplierTelepone.Size = new System.Drawing.Size(78, 20);
            lblSupplierTelepone.TabIndex = 5;
            lblSupplierTelepone.Text = "Telephone";
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Location = new System.Drawing.Point(21, 61);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new System.Drawing.Size(62, 20);
            lblSupplierAddress.TabIndex = 3;
            lblSupplierAddress.Text = "Address";
            // 
            // pnlUcPartOperation
            // 
            pnlUcPartOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUcPartOperation.Controls.Add(btnImport);
            pnlUcPartOperation.Controls.Add(btnExport);
            pnlUcPartOperation.Controls.Add(btnInsert);
            pnlUcPartOperation.Controls.Add(btnSave);
            pnlUcPartOperation.Controls.Add(btnRejectChanges);
            pnlUcPartOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlUcPartOperation.Location = new System.Drawing.Point(3, 245);
            pnlUcPartOperation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            pnlUcPartOperation.Name = "pnlUcPartOperation";
            pnlUcPartOperation.Size = new System.Drawing.Size(1099, 81);
            pnlUcPartOperation.TabIndex = 2;
            // 
            // btnImport
            // 
            btnImport.Location = new System.Drawing.Point(944, 11);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(138, 51);
            btnImport.TabIndex = 0;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new System.Drawing.Point(800, 11);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(138, 51);
            btnExport.TabIndex = 0;
            btnExport.Text = "Export";
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
            // txtSupplierCode
            // 
            txtSupplierCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtSupplierCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSupplierCode.Location = new System.Drawing.Point(159, 25);
            txtSupplierCode.Name = "txtSupplierCode";
            txtSupplierCode.Size = new System.Drawing.Size(191, 27);
            txtSupplierCode.TabIndex = 1;
            txtSupplierCode.Tag = "PartCode";
            // 
            // lblSuppiler
            // 
            lblSuppiler.AutoSize = true;
            lblSuppiler.Location = new System.Drawing.Point(21, 25);
            lblSuppiler.Name = "lblSuppiler";
            lblSuppiler.Size = new System.Drawing.Size(64, 20);
            lblSuppiler.TabIndex = 0;
            lblSuppiler.Text = "Suppiler";
            // 
            // grpDetail
            // 
            grpDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            grpDetail.Controls.Add(txtSupplierRemark);
            grpDetail.Controls.Add(lblSupplierRemark);
            grpDetail.Controls.Add(txtSupplierFax);
            grpDetail.Controls.Add(lblSupplierFax);
            grpDetail.Controls.Add(txtSupplierTelephone);
            grpDetail.Controls.Add(txtSupplierStreet);
            grpDetail.Controls.Add(txtSupplierZip);
            grpDetail.Controls.Add(txtSupplierPlace);
            grpDetail.Controls.Add(lblSupplierTelepone);
            grpDetail.Controls.Add(lblSupplierAddress);
            grpDetail.Controls.Add(pnlUcPartOperation);
            grpDetail.Controls.Add(txtSupplierName);
            grpDetail.Controls.Add(txtSupplierCode);
            grpDetail.Controls.Add(lblSuppiler);
            grpDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            grpDetail.Location = new System.Drawing.Point(0, 358);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new System.Drawing.Size(1105, 329);
            grpDetail.TabIndex = 12;
            grpDetail.TabStop = false;
            grpDetail.Text = "Details";
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
            mainGridView.Size = new System.Drawing.Size(1105, 351);
            mainGridView.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(mainGridView);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            pnlGrid.Location = new System.Drawing.Point(0, 0);
            pnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new System.Drawing.Size(1105, 351);
            pnlGrid.TabIndex = 11;
            // 
            // ucSuppliers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpDetail);
            Controls.Add(pnlGrid);
            Name = "ucSuppliers";
            Size = new System.Drawing.Size(1105, 687);
            Load += onFormLoad;
            pnlUcPartOperation.ResumeLayout(false);
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).EndInit();
            pnlGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtSupplierPlace;
        private System.Windows.Forms.TextBox txtSupplierName;
        public System.Windows.Forms.Button btnRejectChanges;
        private System.Windows.Forms.TextBox txtSupplierRemark;
        public System.Windows.Forms.Label lblSupplierRemark;
        private System.Windows.Forms.TextBox txtSupplierFax;
        public System.Windows.Forms.Label lblSupplierFax;
        private System.Windows.Forms.TextBox txtSupplierTelephone;
        private System.Windows.Forms.TextBox txtSupplierStreet;
        private System.Windows.Forms.TextBox txtSupplierZip;
        public System.Windows.Forms.Label lblSupplierTelepone;
        public System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Panel pnlUcPartOperation;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSupplierCode;
        public System.Windows.Forms.Label lblSuppiler;
        public System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.Panel pnlGrid;
    }
}
