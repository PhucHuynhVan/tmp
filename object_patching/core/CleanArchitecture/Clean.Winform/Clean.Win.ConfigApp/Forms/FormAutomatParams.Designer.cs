namespace Clean.Win.AppConfigUI.Forms
{
    partial class FormAutomatParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutomatParams));
            pnlContentHeader = new System.Windows.Forms.Panel();
            txtID = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tabControl = new System.Windows.Forms.TabControl();
            tpAutomatParameter = new System.Windows.Forms.TabPage();
            ucAutomatParam1 = new UserControls.Automat.ucAutomatParam();
            tpUserdefine = new System.Windows.Forms.TabPage();
            tpEndlabel = new System.Windows.Forms.TabPage();
            pnlContent = new System.Windows.Forms.Panel();
            pnlContentHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            tpAutomatParameter.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentHeader
            // 
            pnlContentHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            pnlContentHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlContentHeader.Controls.Add(txtID);
            pnlContentHeader.Controls.Add(txtName);
            pnlContentHeader.Controls.Add(label1);
            pnlContentHeader.Controls.Add(pictureBox1);
            pnlContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlContentHeader.Location = new System.Drawing.Point(0, 0);
            pnlContentHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlContentHeader.Name = "pnlContentHeader";
            pnlContentHeader.Size = new System.Drawing.Size(1521, 65);
            pnlContentHeader.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(201, 17);
            txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new System.Drawing.Size(263, 27);
            txtID.TabIndex = 3;
            txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new System.Drawing.Point(493, 17);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(772, 27);
            txtName.TabIndex = 2;
            txtName.Tag = "Name";
            txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Automat:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1300, 12);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(32, 32);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tpAutomatParameter);
            tabControl.Controls.Add(tpUserdefine);
            tabControl.Controls.Add(tpEndlabel);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 65);
            tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1521, 793);
            tabControl.TabIndex = 2;
            // 
            // tpAutomatParameter
            // 
            tpAutomatParameter.Controls.Add(ucAutomatParam1);
            tpAutomatParameter.Location = new System.Drawing.Point(4, 29);
            tpAutomatParameter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpAutomatParameter.Name = "tpAutomatParameter";
            tpAutomatParameter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpAutomatParameter.Size = new System.Drawing.Size(1513, 760);
            tpAutomatParameter.TabIndex = 0;
            tpAutomatParameter.Text = "Automat Parameter";
            tpAutomatParameter.UseVisualStyleBackColor = true;
            // 
            // ucAutomatParam1
            // 
            ucAutomatParam1.BackColor = System.Drawing.SystemColors.Control;
            ucAutomatParam1.Dock = System.Windows.Forms.DockStyle.Fill;
            ucAutomatParam1.Location = new System.Drawing.Point(3, 4);
            ucAutomatParam1.Name = "ucAutomatParam1";
            ucAutomatParam1.Size = new System.Drawing.Size(1507, 752);
            ucAutomatParam1.TabIndex = 0;
            // 
            // tpUserdefine
            // 
            tpUserdefine.Location = new System.Drawing.Point(4, 29);
            tpUserdefine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpUserdefine.Name = "tpUserdefine";
            tpUserdefine.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpUserdefine.Size = new System.Drawing.Size(1513, 760);
            tpUserdefine.TabIndex = 1;
            tpUserdefine.Text = "Userdefined Parameter / Endlabel Definition";
            tpUserdefine.UseVisualStyleBackColor = true;
            // 
            // tpEndlabel
            // 
            tpEndlabel.Location = new System.Drawing.Point(4, 29);
            tpEndlabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpEndlabel.Name = "tpEndlabel";
            tpEndlabel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tpEndlabel.Size = new System.Drawing.Size(1513, 760);
            tpEndlabel.TabIndex = 2;
            tpEndlabel.Text = "Endlabel Printer Script";
            tpEndlabel.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(tabControl);
            pnlContent.Controls.Add(pnlContentHeader);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1521, 858);
            pnlContent.TabIndex = 1;
            // 
            // FormAutomatParams
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1521, 858);
            Controls.Add(pnlContent);
            Name = "FormAutomatParams";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormAutomatParams";
            pnlContentHeader.ResumeLayout(false);
            pnlContentHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl.ResumeLayout(false);
            tpAutomatParameter.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContentHeader;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpAutomatParameter;
        private System.Windows.Forms.TabPage tpUserdefine;
        private System.Windows.Forms.TabPage tpEndlabel;
        private UserControls.Automat.ucAutomatParam ucAutomatParam1;
        private System.Windows.Forms.Panel pnlContent;
    }
}