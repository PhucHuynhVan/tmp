namespace Clean.Win.AppUI.UserControls
{
    partial class ucPartConfig
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
            txtName = new System.Windows.Forms.TextBox();
            btnRejectChanges = new System.Windows.Forms.Button();
            pnlUcPartOperation = new System.Windows.Forms.Panel();
            btnImport = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            btnInsert = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtCode = new System.Windows.Forms.TextBox();
            lblPart = new System.Windows.Forms.Label();
            grpDetail = new System.Windows.Forms.GroupBox();
            mainGridView = new System.Windows.Forms.DataGridView();
            pnlGrid = new System.Windows.Forms.Panel();
            pnlUcPartOperation.SuspendLayout();
            grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).BeginInit();
            pnlGrid.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(369, 22);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(1492, 27);
            txtName.TabIndex = 1;
            txtName.Tag = "PartName";
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
            // pnlUcPartOperation
            // 
            pnlUcPartOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUcPartOperation.Controls.Add(btnImport);
            pnlUcPartOperation.Controls.Add(btnExport);
            pnlUcPartOperation.Controls.Add(btnInsert);
            pnlUcPartOperation.Controls.Add(btnSave);
            pnlUcPartOperation.Controls.Add(btnRejectChanges);
            pnlUcPartOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlUcPartOperation.Location = new System.Drawing.Point(3, 61);
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
            // 
            // btnExport
            // 
            btnExport.Location = new System.Drawing.Point(800, 11);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(138, 51);
            btnExport.TabIndex = 0;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
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
            // txtCode
            // 
            txtCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtCode.Location = new System.Drawing.Point(96, 22);
            txtCode.Name = "txtCode";
            txtCode.Size = new System.Drawing.Size(266, 27);
            txtCode.TabIndex = 1;
            txtCode.Tag = "PartCode";
            // 
            // lblPart
            // 
            lblPart.AutoSize = true;
            lblPart.Location = new System.Drawing.Point(21, 25);
            lblPart.Name = "lblPart";
            lblPart.Size = new System.Drawing.Size(34, 20);
            lblPart.TabIndex = 0;
            lblPart.Text = "Part";
            // 
            // grpDetail
            // 
            grpDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            grpDetail.Controls.Add(pnlUcPartOperation);
            grpDetail.Controls.Add(txtName);
            grpDetail.Controls.Add(txtCode);
            grpDetail.Controls.Add(lblPart);
            grpDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            grpDetail.Location = new System.Drawing.Point(0, 542);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new System.Drawing.Size(1105, 145);
            grpDetail.TabIndex = 10;
            grpDetail.TabStop = false;
            grpDetail.Text = "Details";
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
            mainGridView.Size = new System.Drawing.Size(2010, 909);
            mainGridView.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlGrid.Controls.Add(mainGridView);
            pnlGrid.Location = new System.Drawing.Point(0, 0);
            pnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new System.Drawing.Size(1105, 544);
            pnlGrid.TabIndex = 9;
            // 
            // ucParts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(grpDetail);
            Controls.Add(pnlGrid);
            Name = "ucParts";
            Size = new System.Drawing.Size(1105, 687);
            Tag = "ucParts_GUI";
            Load += onFormLoad;
            pnlUcPartOperation.ResumeLayout(false);
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).EndInit();
            pnlGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Button btnRejectChanges;
        private System.Windows.Forms.Panel pnlUcPartOperation;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.Label lblPart;
        public System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.Panel pnlGrid;
    }
}
