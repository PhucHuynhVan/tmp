namespace Clean.Win.AppUI.UserControls
{
    partial class ucThreads
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
            pnlGrid = new System.Windows.Forms.Panel();
            mainGridView = new System.Windows.Forms.DataGridView();
            grpDetail = new System.Windows.Forms.GroupBox();
            btnEditWindingParam = new System.Windows.Forms.Button();
            chkBobbinThread = new System.Windows.Forms.CheckBox();
            chkUpperThread = new System.Windows.Forms.CheckBox();
            txtColour = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtWindingParameter = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            pnlUcPartOperation = new System.Windows.Forms.Panel();
            btnImport = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            btnInsert = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnRejectChanges = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            txtCode = new System.Windows.Forms.TextBox();
            lblPart = new System.Windows.Forms.Label();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).BeginInit();
            grpDetail.SuspendLayout();
            pnlUcPartOperation.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlGrid.Controls.Add(mainGridView);
            pnlGrid.Location = new System.Drawing.Point(0, 0);
            pnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new System.Drawing.Size(1105, 465);
            pnlGrid.TabIndex = 0;
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
            mainGridView.Size = new System.Drawing.Size(1105, 465);
            mainGridView.TabIndex = 0;
            // 
            // grpDetail
            // 
            grpDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            grpDetail.Controls.Add(btnEditWindingParam);
            grpDetail.Controls.Add(chkBobbinThread);
            grpDetail.Controls.Add(chkUpperThread);
            grpDetail.Controls.Add(txtColour);
            grpDetail.Controls.Add(label2);
            grpDetail.Controls.Add(txtWindingParameter);
            grpDetail.Controls.Add(label1);
            grpDetail.Controls.Add(pnlUcPartOperation);
            grpDetail.Controls.Add(txtName);
            grpDetail.Controls.Add(txtCode);
            grpDetail.Controls.Add(lblPart);
            grpDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            grpDetail.Location = new System.Drawing.Point(0, 472);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new System.Drawing.Size(1105, 215);
            grpDetail.TabIndex = 8;
            grpDetail.TabStop = false;
            grpDetail.Text = "Details";
            // 
            // btnEditWindingParam
            // 
            btnEditWindingParam.Location = new System.Drawing.Point(509, 56);
            btnEditWindingParam.Name = "btnEditWindingParam";
            btnEditWindingParam.Size = new System.Drawing.Size(94, 29);
            btnEditWindingParam.TabIndex = 9;
            btnEditWindingParam.Text = "select";
            btnEditWindingParam.UseVisualStyleBackColor = true;
            btnEditWindingParam.Click += btnEditWindingParam_Click;
            // 
            // chkBobbinThread
            // 
            chkBobbinThread.AutoSize = true;
            chkBobbinThread.Location = new System.Drawing.Point(759, 57);
            chkBobbinThread.Name = "chkBobbinThread";
            chkBobbinThread.Size = new System.Drawing.Size(129, 24);
            chkBobbinThread.TabIndex = 8;
            chkBobbinThread.Text = "Bobbin Thread";
            chkBobbinThread.UseVisualStyleBackColor = true;
            // 
            // chkUpperThread
            // 
            chkUpperThread.AutoSize = true;
            chkUpperThread.Location = new System.Drawing.Point(621, 59);
            chkUpperThread.Name = "chkUpperThread";
            chkUpperThread.Size = new System.Drawing.Size(122, 24);
            chkUpperThread.TabIndex = 7;
            chkUpperThread.Text = "Upper Thread";
            chkUpperThread.UseVisualStyleBackColor = true;
            // 
            // txtColour
            // 
            txtColour.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtColour.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtColour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtColour.Location = new System.Drawing.Point(226, 95);
            txtColour.Name = "txtColour";
            txtColour.Size = new System.Drawing.Size(860, 27);
            txtColour.TabIndex = 6;
            txtColour.Tag = "PartCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 97);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 20);
            label2.TabIndex = 5;
            label2.Text = "Thread Colour";
            // 
            // txtWindingParameter
            // 
            txtWindingParameter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtWindingParameter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtWindingParameter.Location = new System.Drawing.Point(226, 59);
            txtWindingParameter.Name = "txtWindingParameter";
            txtWindingParameter.Size = new System.Drawing.Size(266, 27);
            txtWindingParameter.TabIndex = 4;
            txtWindingParameter.Tag = "PartCode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(180, 20);
            label1.TabIndex = 3;
            label1.Text = "Thread/Winding Paramter";
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
            pnlUcPartOperation.Location = new System.Drawing.Point(3, 131);
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
            // txtName
            // 
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(499, 23);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(587, 27);
            txtName.TabIndex = 1;
            txtName.Tag = "PartName";
            // 
            // txtCode
            // 
            txtCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtCode.Location = new System.Drawing.Point(226, 23);
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
            lblPart.Size = new System.Drawing.Size(55, 20);
            lblPart.TabIndex = 0;
            lblPart.Text = "Thread";
            // 
            // ucThreads
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpDetail);
            Controls.Add(pnlGrid);
            Name = "ucThreads";
            Size = new System.Drawing.Size(1105, 687);
            Load += onFormLoad;
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainGridView).EndInit();
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            pnlUcPartOperation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.TextBox txtColour;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWindingParameter;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.Panel pnlUcPartOperation;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnRejectChanges;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.CheckBox chkBobbinThread;
        private System.Windows.Forms.CheckBox chkUpperThread;
        private System.Windows.Forms.Button btnEditWindingParam;
    }
}
