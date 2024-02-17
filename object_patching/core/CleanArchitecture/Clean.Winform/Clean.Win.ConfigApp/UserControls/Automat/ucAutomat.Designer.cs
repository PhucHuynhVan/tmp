namespace Clean.Win.AppConfigUI.UserControls.Automat
{
    partial class ucAutomat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAutomat));
            pnlMainAutomat = new System.Windows.Forms.Panel();
            pnlContent = new System.Windows.Forms.Panel();
            tabControl = new System.Windows.Forms.TabControl();
            tpBiasysControl = new System.Windows.Forms.TabPage();
            ucAutomatControl1 = new ucAutomatControl();
            tpBiasysDB = new System.Windows.Forms.TabPage();
            ucAutomatdb1 = new ucAutomatDB();
            pnlContentHeader = new System.Windows.Forms.Panel();
            cbActive = new System.Windows.Forms.CheckBox();
            txtAutomat = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
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
            pnlMainAutomat.SuspendLayout();
            pnlContent.SuspendLayout();
            tabControl.SuspendLayout();
            tpBiasysControl.SuspendLayout();
            tpBiasysDB.SuspendLayout();
            pnlContentHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tsTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainAutomat
            // 
            pnlMainAutomat.Controls.Add(pnlContent);
            pnlMainAutomat.Controls.Add(tsTop);
            pnlMainAutomat.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMainAutomat.Location = new System.Drawing.Point(0, 0);
            pnlMainAutomat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlMainAutomat.Name = "pnlMainAutomat";
            pnlMainAutomat.Size = new System.Drawing.Size(1592, 827);
            pnlMainAutomat.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(tabControl);
            pnlContent.Controls.Add(pnlContentHeader);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 27);
            pnlContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1592, 800);
            pnlContent.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tpBiasysControl);
            tabControl.Controls.Add(tpBiasysDB);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 65);
            tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1592, 735);
            tabControl.TabIndex = 0;
            // 
            // tpBiasysControl
            // 
            tpBiasysControl.Controls.Add(ucAutomatControl1);
            tpBiasysControl.Location = new System.Drawing.Point(4, 29);
            tpBiasysControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpBiasysControl.Name = "tpBiasysControl";
            tpBiasysControl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpBiasysControl.Size = new System.Drawing.Size(1584, 702);
            tpBiasysControl.TabIndex = 0;
            tpBiasysControl.Text = "Automat Parameter / BiasysControl Settings";
            tpBiasysControl.UseVisualStyleBackColor = true;
            // 
            // ucAutomatControl1
            // 
            ucAutomatControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            ucAutomatControl1.Location = new System.Drawing.Point(3, 4);
            ucAutomatControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ucAutomatControl1.Name = "ucAutomatControl1";
            ucAutomatControl1.Size = new System.Drawing.Size(1578, 694);
            ucAutomatControl1.TabIndex = 0;
            // 
            // tpBiasysDB
            // 
            tpBiasysDB.Controls.Add(ucAutomatdb1);
            tpBiasysDB.Location = new System.Drawing.Point(4, 29);
            tpBiasysDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpBiasysDB.Name = "tpBiasysDB";
            tpBiasysDB.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpBiasysDB.Size = new System.Drawing.Size(1584, 702);
            tpBiasysDB.TabIndex = 1;
            tpBiasysDB.Text = "Biasys DB Settings";
            tpBiasysDB.UseVisualStyleBackColor = true;
            // 
            // ucAutomatdb1
            // 
            ucAutomatdb1.Dock = System.Windows.Forms.DockStyle.Fill;
            ucAutomatdb1.Location = new System.Drawing.Point(3, 4);
            ucAutomatdb1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ucAutomatdb1.Name = "ucAutomatdb1";
            ucAutomatdb1.Size = new System.Drawing.Size(1578, 694);
            ucAutomatdb1.TabIndex = 0;
            // 
            // pnlContentHeader
            // 
            pnlContentHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            pnlContentHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlContentHeader.Controls.Add(cbActive);
            pnlContentHeader.Controls.Add(txtAutomat);
            pnlContentHeader.Controls.Add(label2);
            pnlContentHeader.Controls.Add(txtID);
            pnlContentHeader.Controls.Add(txtName);
            pnlContentHeader.Controls.Add(label1);
            pnlContentHeader.Controls.Add(pictureBox1);
            pnlContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlContentHeader.Location = new System.Drawing.Point(0, 0);
            pnlContentHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlContentHeader.Name = "pnlContentHeader";
            pnlContentHeader.Size = new System.Drawing.Size(1592, 65);
            pnlContentHeader.TabIndex = 0;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new System.Drawing.Point(709, 20);
            cbActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbActive.Name = "cbActive";
            cbActive.Size = new System.Drawing.Size(72, 24);
            cbActive.TabIndex = 6;
            cbActive.Tag = "IsActive";
            cbActive.Text = "Active";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // txtAutomat
            // 
            txtAutomat.Location = new System.Drawing.Point(574, 17);
            txtAutomat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAutomat.Name = "txtAutomat";
            txtAutomat.ReadOnly = true;
            txtAutomat.Size = new System.Drawing.Size(114, 27);
            txtAutomat.TabIndex = 5;
            txtAutomat.Tag = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(489, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Automat";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(285, 17);
            txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new System.Drawing.Size(60, 27);
            txtID.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(353, 17);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(114, 27);
            txtName.TabIndex = 2;
            txtName.Tag = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(41, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(238, 20);
            label1.TabIndex = 1;
            label1.Text = "Automat Configuration : ID/Name ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(16, 19);
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
            // ucAutomat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlMainAutomat);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ucAutomat";
            Size = new System.Drawing.Size(1592, 827);
            pnlMainAutomat.ResumeLayout(false);
            pnlMainAutomat.PerformLayout();
            pnlContent.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tpBiasysControl.ResumeLayout(false);
            tpBiasysDB.ResumeLayout(false);
            pnlContentHeader.ResumeLayout(false);
            pnlContentHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tsTop.ResumeLayout(false);
            tsTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlMainAutomat;
        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlContentHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.TextBox txtAutomat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpBiasysControl;
        private System.Windows.Forms.TabPage tpBiasysDB;
        private ucAutomatControl ucAutomatControl1;
        private ucAutomatDB ucAutomatdb1;
    }
}
