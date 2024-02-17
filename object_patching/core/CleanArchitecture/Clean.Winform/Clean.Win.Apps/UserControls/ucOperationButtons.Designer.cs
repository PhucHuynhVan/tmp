namespace Clean.Win.AppUI.UserControls
{
    partial class ucOperationButtons
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
            btnImport = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            btnInsert = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnRejectChanges = new System.Windows.Forms.Button();
            //this.lnkStockFaric = new System.Windows.Forms.LinkLabel();
            this.lnkProductionData = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.Location = new System.Drawing.Point(833, 12);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(151, 51);
            btnImport.TabIndex = 0;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new System.Drawing.Point(676, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(151, 51);
            btnExport.TabIndex = 0;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(324, 12);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(151, 51);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(167, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(151, 51);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRejectChanges
            // 
            btnRejectChanges.Location = new System.Drawing.Point(10, 12);
            btnRejectChanges.Name = "btnRejectChanges";
            btnRejectChanges.Size = new System.Drawing.Size(151, 51);
            btnRejectChanges.TabIndex = 0;
            btnRejectChanges.Text = "Reject Changes";
            btnRejectChanges.UseVisualStyleBackColor = true;
            // 
            // lnkStockFaric
            // 
            //this.lnkStockFaric.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            //this.lnkStockFaric.AutoSize = true;
            //this.lnkStockFaric.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.lnkStockFaric.Location = new System.Drawing.Point(1006, 13);
            //this.lnkStockFaric.Name = "lnkStockFaric";
            //this.lnkStockFaric.Size = new System.Drawing.Size(94, 20);
            //this.lnkStockFaric.TabIndex = 2;
            //this.lnkStockFaric.TabStop = true;
            //this.lnkStockFaric.Text = "Stock Fabrics";
            // 
            // lnkProductionData
            // 
            this.lnkProductionData.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lnkProductionData.AutoSize = true;
            this.lnkProductionData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkProductionData.Location = new System.Drawing.Point(983, 43);
            this.lnkProductionData.Name = "lnkProductionData";
            this.lnkProductionData.Size = new System.Drawing.Size(117, 20);
            this.lnkProductionData.TabIndex = 3;
            this.lnkProductionData.TabStop = true;
            this.lnkProductionData.Text = "Production Data";
            // 
            // ucOperationButtons
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnRejectChanges);
            Controls.Add(btnSave);
            Controls.Add(btnInsert);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            //Controls.Add(this.lnkStockFaric);
            Controls.Add(this.lnkProductionData);
            Name = "ucOperationButtons";
            Size = new System.Drawing.Size(1105, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkStockFabrics;
        private System.Windows.Forms.LinkLabel lnkProductionData;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnRejectChanges;
        private System.Windows.Forms.LinkLabel lnkStockFarics;
        
    }
}
