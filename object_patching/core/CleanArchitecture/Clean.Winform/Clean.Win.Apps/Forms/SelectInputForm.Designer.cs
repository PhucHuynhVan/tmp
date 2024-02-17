namespace Clean.Win.AppUI.Forms
{
    partial class AutomatSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomatSelect));
            pnlFooter = new System.Windows.Forms.Panel();
            btnCancel = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            dgrAutomatSelect = new System.Windows.Forms.DataGridView();
            btnUpArrow = new System.Windows.Forms.Button();
            btnDownArrow = new System.Windows.Forms.Button();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrAutomatSelect).BeginInit();
            SuspendLayout();
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.SystemColors.Control;
            pnlFooter.Controls.Add(btnDownArrow);
            pnlFooter.Controls.Add(btnUpArrow);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnOK);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlFooter.Location = new System.Drawing.Point(0, 272);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(599, 60);
            pnlFooter.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(494, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(98, 33);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Image = (System.Drawing.Image)resources.GetObject("btnOK.Image");
            btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOK.Location = new System.Drawing.Point(392, 14);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(98, 33);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // dgrAutomatSelect
            // 
            dgrAutomatSelect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgrAutomatSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrAutomatSelect.Location = new System.Drawing.Point(9, 9);
            dgrAutomatSelect.Name = "dgrAutomatSelect";
            dgrAutomatSelect.RowHeadersWidth = 51;
            dgrAutomatSelect.RowTemplate.Height = 29;
            dgrAutomatSelect.Size = new System.Drawing.Size(582, 259);
            dgrAutomatSelect.TabIndex = 1;
            // 
            // btnUpArrow
            // 
            btnUpArrow.Image = (System.Drawing.Image)resources.GetObject("btnUpArrow.Image");
            btnUpArrow.Location = new System.Drawing.Point(111, 14);
            btnUpArrow.Name = "btnUpArrow";
            btnUpArrow.Size = new System.Drawing.Size(98, 33);
            btnUpArrow.TabIndex = 1;
            btnUpArrow.UseVisualStyleBackColor = true;
            // 
            // btnDownArrow
            // 
            btnDownArrow.Image = (System.Drawing.Image)resources.GetObject("btnDownArrow.Image");
            btnDownArrow.Location = new System.Drawing.Point(8, 13);
            btnDownArrow.Name = "btnDownArrow";
            btnDownArrow.Size = new System.Drawing.Size(98, 33);
            btnDownArrow.TabIndex = 2;
            btnDownArrow.UseVisualStyleBackColor = true;
            // 
            // AutomatSelect
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(599, 332);
            Controls.Add(dgrAutomatSelect);
            Controls.Add(pnlFooter);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutomatSelect";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Select automat";
            Load += SelectInputForm_Load;
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrAutomatSelect).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgrAutomatSelect;
        private System.Windows.Forms.Button btnDownArrow;
        private System.Windows.Forms.Button btnUpArrow;
    }
}