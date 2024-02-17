namespace Clean.Win.AppUI.Forms
{
    partial class SelectInputForm
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
            pnlFooter = new System.Windows.Forms.Panel();
            btnCancel = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            drgSelectDataInput = new System.Windows.Forms.DataGridView();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgSelectDataInput).BeginInit();
            SuspendLayout();
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.SystemColors.Control;
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnOK);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlFooter.Location = new System.Drawing.Point(0, 328);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(693, 60);
            pnlFooter.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(575, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(107, 33);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(458, 14);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(107, 33);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // drgSelectDataInput
            // 
            drgSelectDataInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            drgSelectDataInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drgSelectDataInput.Location = new System.Drawing.Point(8, 9);
            drgSelectDataInput.Name = "drgSelectDataInput";
            drgSelectDataInput.RowHeadersWidth = 51;
            drgSelectDataInput.RowTemplate.Height = 29;
            drgSelectDataInput.Size = new System.Drawing.Size(675, 309);
            drgSelectDataInput.TabIndex = 1;
            // 
            // SelectInputForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(693, 388);
            Controls.Add(drgSelectDataInput);
            Controls.Add(pnlFooter);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectInputForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Select automat";
            Load += SelectInputForm_Load;
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drgSelectDataInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView drgSelectDataInput;
    }
}