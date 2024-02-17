namespace Clean.Win.AppUI.Forms
{
    partial class InputDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDataForm));
            panel2 = new System.Windows.Forms.Panel();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            pnlTextbox = new System.Windows.Forms.Panel();
            txtTextInput = new System.Windows.Forms.TextBox();
            lblFieldName = new System.Windows.Forms.Label();
            pnlDataGridView = new System.Windows.Forms.Panel();
            dataGridView = new System.Windows.Forms.DataGridView();
            pnlUserConfig = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            pnlTextbox.SuspendLayout();
            pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            panel2.Controls.Add(btnOK);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(439, 56);
            panel2.TabIndex = 7;
            // 
            // btnOK
            // 
            btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOK.Image = (System.Drawing.Image)resources.GetObject("btnOK.Image");
            btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOK.Location = new System.Drawing.Point(205, 11);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(107, 32);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(327, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(107, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnlTextbox
            // 
            pnlTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlTextbox.Controls.Add(txtTextInput);
            pnlTextbox.Controls.Add(lblFieldName);
            pnlTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTextbox.Location = new System.Drawing.Point(0, 0);
            pnlTextbox.Name = "pnlTextbox";
            pnlTextbox.Size = new System.Drawing.Size(439, 97);
            pnlTextbox.TabIndex = 6;
            // 
            // txtTextInput
            // 
            txtTextInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTextInput.Location = new System.Drawing.Point(14, 49);
            txtTextInput.Name = "txtTextInput";
            txtTextInput.Size = new System.Drawing.Size(412, 27);
            txtTextInput.TabIndex = 3;
            txtTextInput.KeyPress += txtTextInput_KeyPress;
            // 
            // lblFieldName
            // 
            lblFieldName.AutoSize = true;
            lblFieldName.Location = new System.Drawing.Point(14, 11);
            lblFieldName.Name = "lblFieldName";
            lblFieldName.Size = new System.Drawing.Size(0, 20);
            lblFieldName.TabIndex = 2;
            // 
            // pnlDataGridView
            // 
            pnlDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlDataGridView.Controls.Add(dataGridView);
            pnlDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDataGridView.Location = new System.Drawing.Point(0, 0);
            pnlDataGridView.Name = "pnlDataGridView";
            pnlDataGridView.Size = new System.Drawing.Size(439, 97);
            pnlDataGridView.TabIndex = 7;
            pnlDataGridView.Visible = false;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new System.Drawing.Size(437, 95);
            dataGridView.TabIndex = 3;
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;
            dataGridView.KeyPress += txtTextInput_KeyPress;
            // 
            // pnlUserConfig
            // 
            pnlUserConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUserConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlUserConfig.Location = new System.Drawing.Point(0, 0);
            pnlUserConfig.Name = "pnlUserConfig";
            pnlUserConfig.Size = new System.Drawing.Size(439, 153);
            pnlUserConfig.TabIndex = 8;
            pnlUserConfig.Visible = false;
            // 
            // InputDataForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(439, 153);
            Controls.Add(pnlTextbox);
            Controls.Add(pnlDataGridView);
            Controls.Add(panel2);
            Controls.Add(pnlUserConfig);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "InputDataForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "InputDataForm";
            FormClosed += InputDataForm_FormClosed;
            Load += InputDataForm_Load;
            panel2.ResumeLayout(false);
            pnlTextbox.ResumeLayout(false);
            pnlTextbox.PerformLayout();
            pnlDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlTextbox;
        private System.Windows.Forms.TextBox txtTextInput;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel pnlUserConfig;
    }
}