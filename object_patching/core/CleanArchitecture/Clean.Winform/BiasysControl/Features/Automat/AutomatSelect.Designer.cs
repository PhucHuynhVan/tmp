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
            pnlFooter = new Panel();
            btnUpArrow = new Button();
            btnDownArrow = new Button();
            btnCancel = new Button();
            btnOK = new Button();
            drgSelectDataInput = new DataGridView();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgSelectDataInput).BeginInit();
            SuspendLayout();
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = SystemColors.Control;
            pnlFooter.Controls.Add(btnUpArrow);
            pnlFooter.Controls.Add(btnDownArrow);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnOK);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 283);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(611, 60);
            pnlFooter.TabIndex = 0;
            // 
            // btnUpArrow
            // 
            btnUpArrow.Image = (Image)resources.GetObject("btnUpArrow.Image");
            btnUpArrow.Location = new Point(78, 14);
            btnUpArrow.Name = "btnUpArrow";
            btnUpArrow.Size = new Size(63, 33);
            btnUpArrow.TabIndex = 1;
            btnUpArrow.UseVisualStyleBackColor = true;
            // 
            // btnDownArrow
            // 
            btnDownArrow.Image = (Image)resources.GetObject("btnDownArrow.Image");
            btnDownArrow.Location = new Point(9, 14);
            btnDownArrow.Name = "btnDownArrow";
            btnDownArrow.Size = new Size(63, 33);
            btnDownArrow.TabIndex = 2;
            btnDownArrow.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(495, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 33);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Image = (Image)resources.GetObject("btnOK.Image");
            btnOK.ImageAlign = ContentAlignment.MiddleLeft;
            btnOK.Location = new Point(378, 14);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(107, 33);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // drgSelectDataInput
            // 
            drgSelectDataInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            drgSelectDataInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drgSelectDataInput.Location = new Point(8, 9);
            drgSelectDataInput.Name = "drgSelectDataInput";
            drgSelectDataInput.RowHeadersWidth = 51;
            drgSelectDataInput.RowTemplate.Height = 29;
            drgSelectDataInput.Size = new Size(593, 266);
            drgSelectDataInput.TabIndex = 1;
            // 
            // AutomatSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(611, 343);
            Controls.Add(drgSelectDataInput);
            Controls.Add(pnlFooter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutomatSelect";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select automat";
            FormClosed += AutomatSelect_FormClosed;
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
        private Button btnUpArrow;
        private Button btnDownArrow;
    }
}