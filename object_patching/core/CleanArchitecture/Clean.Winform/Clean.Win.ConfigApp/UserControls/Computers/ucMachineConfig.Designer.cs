namespace Clean.Win.AppConfigUI.UserControls.Computers
{
    partial class ucMachineConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMachineConfig));
            pnlMainSewingmachine = new System.Windows.Forms.Panel();
            pnlContent = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            btnSetDefaultSetting = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            dgwConnectedDeviced = new System.Windows.Forms.DataGridView();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            dgSewingParameter = new System.Windows.Forms.DataGridView();
            pnlContentHeader = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cbACtive = new System.Windows.Forms.CheckBox();
            txtSerialNumber = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtMachineNumber = new System.Windows.Forms.TextBox();
            txtAlterMachineNumber = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tsTop = new System.Windows.Forms.ToolStrip();
            tsbRefresh = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbCopy = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsbDelete = new System.Windows.Forms.ToolStripButton();
            pnlMainSewingmachine.SuspendLayout();
            pnlContent.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwConnectedDeviced).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSewingParameter).BeginInit();
            pnlContentHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tsTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainSewingmachine
            // 
            pnlMainSewingmachine.Controls.Add(pnlContent);
            pnlMainSewingmachine.Controls.Add(tsTop);
            pnlMainSewingmachine.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMainSewingmachine.Location = new System.Drawing.Point(0, 0);
            pnlMainSewingmachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlMainSewingmachine.Name = "pnlMainSewingmachine";
            pnlMainSewingmachine.Size = new System.Drawing.Size(1592, 827);
            pnlMainSewingmachine.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(panel3);
            pnlContent.Controls.Add(panel2);
            pnlContent.Controls.Add(label7);
            pnlContent.Controls.Add(label6);
            pnlContent.Controls.Add(panel1);
            pnlContent.Controls.Add(pnlContentHeader);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 27);
            pnlContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1592, 800);
            pnlContent.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnSetDefaultSetting);
            panel3.Location = new System.Drawing.Point(1045, 435);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(480, 351);
            panel3.TabIndex = 5;
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.SystemColors.Info;
            label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(3, 38);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(474, 313);
            label8.TabIndex = 1;
            label8.Text = resources.GetString("label8.Text");
            // 
            // btnSetDefaultSetting
            // 
            btnSetDefaultSetting.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSetDefaultSetting.Location = new System.Drawing.Point(16, 3);
            btnSetDefaultSetting.Name = "btnSetDefaultSetting";
            btnSetDefaultSetting.Size = new System.Drawing.Size(224, 32);
            btnSetDefaultSetting.TabIndex = 0;
            btnSetDefaultSetting.Text = "Set Default Settings";
            btnSetDefaultSetting.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgwConnectedDeviced);
            panel2.Location = new System.Drawing.Point(43, 435);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(996, 351);
            panel2.TabIndex = 4;
            // 
            // dgwConnectedDeviced
            // 
            dgwConnectedDeviced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwConnectedDeviced.Dock = System.Windows.Forms.DockStyle.Fill;
            dgwConnectedDeviced.Location = new System.Drawing.Point(0, 0);
            dgwConnectedDeviced.Name = "dgwConnectedDeviced";
            dgwConnectedDeviced.RowHeadersWidth = 51;
            dgwConnectedDeviced.RowTemplate.Height = 29;
            dgwConnectedDeviced.Size = new System.Drawing.Size(996, 351);
            dgwConnectedDeviced.TabIndex = 0;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label7.Location = new System.Drawing.Point(43, 382);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(1493, 39);
            label7.TabIndex = 3;
            label7.Text = "Conected Devices";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label7.UseMnemonic = false;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.Location = new System.Drawing.Point(43, 157);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(1493, 39);
            label6.TabIndex = 0;
            label6.Text = "Sewing Machine Parameter";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgSewingParameter);
            panel1.Location = new System.Drawing.Point(43, 226);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1482, 137);
            panel1.TabIndex = 2;
            // 
            // dgSewingParameter
            // 
            dgSewingParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSewingParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            dgSewingParameter.Location = new System.Drawing.Point(0, 0);
            dgSewingParameter.Name = "dgSewingParameter";
            dgSewingParameter.RowHeadersWidth = 51;
            dgSewingParameter.RowTemplate.Height = 29;
            dgSewingParameter.Size = new System.Drawing.Size(1482, 137);
            dgSewingParameter.TabIndex = 0;
            // 
            // pnlContentHeader
            // 
            pnlContentHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            pnlContentHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlContentHeader.Controls.Add(label4);
            pnlContentHeader.Controls.Add(label3);
            pnlContentHeader.Controls.Add(cbACtive);
            pnlContentHeader.Controls.Add(txtSerialNumber);
            pnlContentHeader.Controls.Add(label2);
            pnlContentHeader.Controls.Add(txtMachineNumber);
            pnlContentHeader.Controls.Add(txtAlterMachineNumber);
            pnlContentHeader.Controls.Add(label1);
            pnlContentHeader.Controls.Add(pictureBox1);
            pnlContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlContentHeader.Location = new System.Drawing.Point(0, 0);
            pnlContentHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlContentHeader.Name = "pnlContentHeader";
            pnlContentHeader.Size = new System.Drawing.Size(1592, 135);
            pnlContentHeader.TabIndex = 0;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.SystemColors.Info;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Location = new System.Drawing.Point(42, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(1510, 52);
            label4.TabIndex = 8;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(311, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(199, 20);
            label3.TabIndex = 7;
            label3.Text = "Alternative Machine Number";
            // 
            // cbACtive
            // 
            cbACtive.AutoSize = true;
            cbACtive.Location = new System.Drawing.Point(687, 86);
            cbACtive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbACtive.Name = "cbACtive";
            cbACtive.Size = new System.Drawing.Size(72, 24);
            cbACtive.TabIndex = 6;
            cbACtive.Text = "Active";
            cbACtive.UseVisualStyleBackColor = true;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new System.Drawing.Point(918, 84);
            txtSerialNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new System.Drawing.Size(203, 27);
            txtSerialNumber.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(808, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Serial Number";
            // 
            // txtMachineNumber
            // 
            txtMachineNumber.Location = new System.Drawing.Point(225, 87);
            txtMachineNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMachineNumber.Name = "txtMachineNumber";
            txtMachineNumber.Size = new System.Drawing.Size(60, 27);
            txtMachineNumber.TabIndex = 3;
            // 
            // txtAlterMachineNumber
            // 
            txtAlterMachineNumber.Location = new System.Drawing.Point(536, 83);
            txtAlterMachineNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAlterMachineNumber.Name = "txtAlterMachineNumber";
            txtAlterMachineNumber.Size = new System.Drawing.Size(58, 27);
            txtAlterMachineNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 90);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 20);
            label1.TabIndex = 1;
            label1.Text = "Main Machine Number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 46);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(18, 21);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tsTop
            // 
            tsTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbRefresh, toolStripSeparator1, tsbSave, toolStripSeparator2, tsbCopy, toolStripSeparator3, tsbDelete });
            tsTop.Location = new System.Drawing.Point(0, 0);
            tsTop.Name = "tsTop";
            tsTop.Size = new System.Drawing.Size(1592, 27);
            tsTop.TabIndex = 0;
            tsTop.Text = "toolStrip1";
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = (System.Drawing.Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new System.Drawing.Size(82, 24);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSave
            // 
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(64, 24);
            tsbSave.Text = "Save";
            tsbSave.Click += tsbSave_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbCopy
            // 
            tsbCopy.Image = (System.Drawing.Image)resources.GetObject("tsbCopy.Image");
            tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbCopy.Name = "tsbCopy";
            tsbCopy.Size = new System.Drawing.Size(67, 24);
            tsbCopy.Text = "Copy";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (System.Drawing.Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new System.Drawing.Size(77, 24);
            tsbDelete.Text = "Delete";
            // 
            // ucMachineConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlMainSewingmachine);
            Name = "ucMachineConfig";
            Size = new System.Drawing.Size(1592, 827);
            Load += onFormLoad;
            pnlMainSewingmachine.ResumeLayout(false);
            pnlMainSewingmachine.PerformLayout();
            pnlContent.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwConnectedDeviced).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSewingParameter).EndInit();
            pnlContentHeader.ResumeLayout(false);
            pnlContentHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tsTop.ResumeLayout(false);
            tsTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMainSewingmachine;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlContentHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbACtive;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMachineNumber;
        private System.Windows.Forms.TextBox txtAlterMachineNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgSewingParameter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSetDefaultSetting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwConnectedDeviced;
    }
}
