namespace Clean.Win.AppConfigUI.UserControls.Automat
{
    partial class ucAutomatParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAutomatParam));
            pnlContent = new System.Windows.Forms.Panel();
            pnlBody = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            lblDescription = new System.Windows.Forms.Label();
            pnlBottom = new System.Windows.Forms.Panel();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            pnlContent.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            pnlBottom.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlBody);
            pnlContent.Controls.Add(pnlBottom);
            pnlContent.Controls.Add(toolStrip1);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1513, 760);
            pnlContent.TabIndex = 0;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(dataGridView1);
            pnlBody.Controls.Add(panel1);
            pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBody.Location = new System.Drawing.Point(0, 28);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new System.Drawing.Size(1513, 607);
            pnlBody.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1513, 482);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescription);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 482);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1513, 125);
            panel1.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDescription.Location = new System.Drawing.Point(0, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(148, 20);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description of Param";
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnCancel);
            pnlBottom.Controls.Add(btnSave);
            pnlBottom.Controls.Add(btnRefresh);
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBottom.Location = new System.Drawing.Point(0, 635);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new System.Drawing.Size(1513, 125);
            pnlBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(1288, 38);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(187, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = (System.Drawing.Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSave.Location = new System.Drawing.Point(270, 38);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(184, 50);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = (System.Drawing.Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRefresh.Location = new System.Drawing.Point(32, 38);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(203, 50);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripSeparator1, toolStripLabel1, toolStripComboBox1, toolStripSeparator2, toolStripComboBox2, toolStripLabel2, toolStripSeparator3, toolStripButton3 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1513, 28);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(128, 25);
            toolStripButton1.Text = "Read from file";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(112, 25);
            toolStripButton2.Text = "Write to file";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(45, 25);
            toolStripLabel1.Text = "Filter:";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(141, 25);
            toolStripLabel2.Text = "Change AccessLevel";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (System.Drawing.Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new System.Drawing.Size(248, 25);
            toolStripButton3.Text = "Show/Hide GroupFilter and Remark";
            // 
            // ucAutomatParam
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlContent);
            Name = "ucAutomatParam";
            Size = new System.Drawing.Size(1513, 760);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlBottom.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel pnlBottom;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
