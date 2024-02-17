namespace Clean.Win.AppUI.UserControls
{
    partial class ucBobbins
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
            mainGridView = new System.Windows.Forms.DataGridView();
            grpDetail = new System.Windows.Forms.GroupBox();
            txtMachine = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtStitchCount = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtBobbinLabel = new System.Windows.Forms.TextBox();
            txtThreadLabel = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pnlUcOperation = new System.Windows.Forms.Panel();
            btnPrintLabel = new System.Windows.Forms.Button();
            btnRejectChanges = new System.Windows.Forms.Button();
            txtBobbinNo = new System.Windows.Forms.TextBox();
            lblPart = new System.Windows.Forms.Label();
            pnlGrid = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)mainGridView).BeginInit();
            grpDetail.SuspendLayout();
            pnlUcOperation.SuspendLayout();
            pnlGrid.SuspendLayout();
            SuspendLayout();
            // 
            // mainGridView
            // 
            mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            mainGridView.Location = new System.Drawing.Point(0, 0);
            mainGridView.Name = "mainGridView";
            mainGridView.ReadOnly = true;
            mainGridView.RowTemplate.Height = 25;
            mainGridView.Size = new System.Drawing.Size(967, 196);
            mainGridView.TabIndex = 0;
            // 
            // grpDetail
            // 
            grpDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            grpDetail.Controls.Add(txtMachine);
            grpDetail.Controls.Add(label4);
            grpDetail.Controls.Add(txtStitchCount);
            grpDetail.Controls.Add(label3);
            grpDetail.Controls.Add(txtBobbinLabel);
            grpDetail.Controls.Add(txtThreadLabel);
            grpDetail.Controls.Add(label2);
            grpDetail.Controls.Add(label1);
            grpDetail.Controls.Add(pnlUcOperation);
            grpDetail.Controls.Add(txtBobbinNo);
            grpDetail.Controls.Add(lblPart);
            grpDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            grpDetail.Location = new System.Drawing.Point(0, 266);
            grpDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            grpDetail.Name = "grpDetail";
            grpDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            grpDetail.Size = new System.Drawing.Size(967, 249);
            grpDetail.TabIndex = 10;
            grpDetail.TabStop = false;
            grpDetail.Text = "Details";
            // 
            // txtMachine
            // 
            txtMachine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtMachine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtMachine.Location = new System.Drawing.Point(198, 126);
            txtMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMachine.Name = "txtMachine";
            txtMachine.Size = new System.Drawing.Size(1520, 23);
            txtMachine.TabIndex = 11;
            txtMachine.Tag = "PartCode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 129);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 15);
            label4.TabIndex = 10;
            label4.Text = "Machine";
            // 
            // txtStitchCount
            // 
            txtStitchCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtStitchCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtStitchCount.Location = new System.Drawing.Point(198, 99);
            txtStitchCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtStitchCount.Name = "txtStitchCount";
            txtStitchCount.Size = new System.Drawing.Size(1520, 23);
            txtStitchCount.TabIndex = 9;
            txtStitchCount.Tag = "PartCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 15);
            label3.TabIndex = 8;
            label3.Text = "Stitch count";
            // 
            // txtBobbinLabel
            // 
            txtBobbinLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBobbinLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtBobbinLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtBobbinLabel.Location = new System.Drawing.Point(198, 45);
            txtBobbinLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtBobbinLabel.Name = "txtBobbinLabel";
            txtBobbinLabel.Size = new System.Drawing.Size(1520, 23);
            txtBobbinLabel.TabIndex = 7;
            txtBobbinLabel.Tag = "PartName";
            // 
            // txtThreadLabel
            // 
            txtThreadLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtThreadLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtThreadLabel.Location = new System.Drawing.Point(198, 72);
            txtThreadLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtThreadLabel.Name = "txtThreadLabel";
            txtThreadLabel.Size = new System.Drawing.Size(1520, 23);
            txtThreadLabel.TabIndex = 6;
            txtThreadLabel.Tag = "PartCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Thread Label";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Bobbin label";
            // 
            // pnlUcOperation
            // 
            pnlUcOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUcOperation.Controls.Add(btnPrintLabel);
            pnlUcOperation.Controls.Add(btnRejectChanges);
            pnlUcOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlUcOperation.Location = new System.Drawing.Point(3, 186);
            pnlUcOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 20);
            pnlUcOperation.Name = "pnlUcOperation";
            pnlUcOperation.Size = new System.Drawing.Size(961, 61);
            pnlUcOperation.TabIndex = 2;
            // 
            // btnPrintLabel
            // 
            btnPrintLabel.Location = new System.Drawing.Point(443, 8);
            btnPrintLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnPrintLabel.Name = "btnPrintLabel";
            btnPrintLabel.Size = new System.Drawing.Size(121, 38);
            btnPrintLabel.TabIndex = 0;
            btnPrintLabel.Text = "Print Label";
            btnPrintLabel.UseVisualStyleBackColor = true;
            // 
            // btnRejectChanges
            // 
            btnRejectChanges.Location = new System.Drawing.Point(10, 8);
            btnRejectChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRejectChanges.Name = "btnRejectChanges";
            btnRejectChanges.Size = new System.Drawing.Size(121, 38);
            btnRejectChanges.TabIndex = 0;
            btnRejectChanges.Text = "Reject Changes";
            btnRejectChanges.UseVisualStyleBackColor = true;
            // 
            // txtBobbinNo
            // 
            txtBobbinNo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBobbinNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtBobbinNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtBobbinNo.Location = new System.Drawing.Point(198, 16);
            txtBobbinNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtBobbinNo.Name = "txtBobbinNo";
            txtBobbinNo.Size = new System.Drawing.Size(1520, 23);
            txtBobbinNo.TabIndex = 1;
            txtBobbinNo.Tag = "PartName";
            // 
            // lblPart
            // 
            lblPart.AutoSize = true;
            lblPart.Location = new System.Drawing.Point(17, 19);
            lblPart.Name = "lblPart";
            lblPart.Size = new System.Drawing.Size(67, 15);
            lblPart.TabIndex = 0;
            lblPart.Text = "Bobbin No.";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(mainGridView);
            pnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            pnlGrid.Location = new System.Drawing.Point(0, 0);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new System.Drawing.Size(967, 196);
            pnlGrid.TabIndex = 9;
            // 
            // ucBobbins
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpDetail);
            Controls.Add(pnlGrid);
            Name = "ucBobbins";
            Size = new System.Drawing.Size(967, 515);
            Load += onFormLoad;
            ((System.ComponentModel.ISupportInitialize)mainGridView).EndInit();
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            pnlUcOperation.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView mainGridView;
        public System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.TextBox txtThreadLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUcOperation;
        public System.Windows.Forms.Button btnPrintLabel;
        public System.Windows.Forms.Button btnRejectChanges;
        private System.Windows.Forms.TextBox txtBobbinNo;
        public System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TextBox txtMachine;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStitchCount;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBobbinLabel;
    }
}
