namespace Clean.Win.AppConfigUI.UserControls.Automat
{
    partial class ucAutomatControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAutomatControl));
            panel5 = new System.Windows.Forms.Panel();
            txtDescription = new System.Windows.Forms.TextBox();
            label24 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            label19 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtAutoLogout = new System.Windows.Forms.TextBox();
            cbIsAutoLogout = new System.Windows.Forms.CheckBox();
            label15 = new System.Windows.Forms.Label();
            txtMinETMMeasVal = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btnAutomatParam = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            button11 = new System.Windows.Forms.Button();
            cbxSerial = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button7 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            comboBox8 = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            panel6 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnEdit1 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            cbResetType = new System.Windows.Forms.ComboBox();
            cbCountertype = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel5.Controls.Add(txtDescription);
            panel5.Controls.Add(label24);
            panel5.Location = new System.Drawing.Point(3, 849);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1461, 173);
            panel5.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDescription.Location = new System.Drawing.Point(0, 40);
            txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(1459, 131);
            txtDescription.TabIndex = 31;
            txtDescription.Tag = "ControllDescription";
            // 
            // label24
            // 
            label24.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label24.Dock = System.Windows.Forms.DockStyle.Top;
            label24.Location = new System.Drawing.Point(0, 0);
            label24.Name = "label24";
            label24.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            label24.Size = new System.Drawing.Size(1459, 40);
            label24.TabIndex = 0;
            label24.Text = "Description / Remarks";
            label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1473, 1031);
            panel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(txtAutoLogout);
            panel4.Controls.Add(cbIsAutoLogout);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(txtMinETMMeasVal);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label18);
            panel4.Location = new System.Drawing.Point(3, 671);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(1461, 173);
            panel4.TabIndex = 10;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = System.Drawing.Color.Beige;
            label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label19.Location = new System.Drawing.Point(346, 120);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(926, 22);
            label19.TabIndex = 36;
            label19.Text = "Automatic logout(y/n) after x seconds of inactivity (0s ... 3600s); info: 300s=5min. ; 600s=10min. ; 900=15min. ; 1800s=30min. ; 3600s=1hour";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Beige;
            label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label10.Location = new System.Drawing.Point(346, 63);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(692, 22);
            label10.TabIndex = 35;
            label10.Text = "Minimum number of ETM measurements compared to the total num,ber of stitches in percent (0 ... 100)";
            // 
            // txtAutoLogout
            // 
            txtAutoLogout.Location = new System.Drawing.Point(221, 116);
            txtAutoLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAutoLogout.Name = "txtAutoLogout";
            txtAutoLogout.Size = new System.Drawing.Size(103, 27);
            txtAutoLogout.TabIndex = 34;
            txtAutoLogout.Tag = "AutoLogout";
            // 
            // cbIsAutoLogout
            // 
            cbIsAutoLogout.AutoSize = true;
            cbIsAutoLogout.Location = new System.Drawing.Point(185, 121);
            cbIsAutoLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbIsAutoLogout.Name = "cbIsAutoLogout";
            cbIsAutoLogout.Size = new System.Drawing.Size(18, 17);
            cbIsAutoLogout.TabIndex = 33;
            cbIsAutoLogout.Tag = "IsAutoLogout";
            cbIsAutoLogout.UseVisualStyleBackColor = true;
            cbIsAutoLogout.CheckedChanged += cbIsAutoLogout_CheckedChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(10, 120);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(159, 20);
            label15.TabIndex = 32;
            label15.Text = "Auto Logout [seconds]";
            // 
            // txtMinETMMeasVal
            // 
            txtMinETMMeasVal.Location = new System.Drawing.Point(221, 59);
            txtMinETMMeasVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMinETMMeasVal.Name = "txtMinETMMeasVal";
            txtMinETMMeasVal.Size = new System.Drawing.Size(103, 27);
            txtMinETMMeasVal.TabIndex = 31;
            txtMinETMMeasVal.Tag = "MinETMMeasVal";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(10, 63);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(183, 20);
            label16.TabIndex = 6;
            label16.Text = "Min. ETM meas. values [%]";
            // 
            // label18
            // 
            label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label18.Dock = System.Windows.Forms.DockStyle.Top;
            label18.Location = new System.Drawing.Point(0, 0);
            label18.Name = "label18";
            label18.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            label18.Size = new System.Drawing.Size(1459, 40);
            label18.TabIndex = 0;
            label18.Text = "Miscellaneous Control Parameter";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(btnAutomatParam);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(cbxSerial);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label17);
            panel3.Location = new System.Drawing.Point(5, 401);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1460, 263);
            panel3.TabIndex = 9;
            // 
            // btnAutomatParam
            // 
            btnAutomatParam.BackColor = System.Drawing.Color.White;
            btnAutomatParam.Location = new System.Drawing.Point(930, 144);
            btnAutomatParam.Name = "btnAutomatParam";
            btnAutomatParam.Size = new System.Drawing.Size(524, 109);
            btnAutomatParam.TabIndex = 31;
            btnAutomatParam.Tag = "";
            btnAutomatParam.Text = "Automat Configuration Parameters\r\nEndlabeldefinition\r\nParamesters for the Printerscript\r\nEndlabel-Printerscript";
            btnAutomatParam.UseVisualStyleBackColor = false;
            btnAutomatParam.Click += btnAutomatParam_Click;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Beige;
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.Location = new System.Drawing.Point(9, 52);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(1445, 82);
            label6.TabIndex = 29;
            label6.Text = "\r\n\r\n\r\n\r\n";
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(453, 151);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(87, 32);
            button11.TabIndex = 18;
            button11.Tag = "";
            button11.Text = "Edit";
            button11.UseVisualStyleBackColor = true;
            // 
            // cbxSerial
            // 
            cbxSerial.FormattingEnabled = true;
            cbxSerial.Location = new System.Drawing.Point(122, 152);
            cbxSerial.Name = "cbxSerial";
            cbxSerial.Size = new System.Drawing.Size(323, 28);
            cbxSerial.TabIndex = 7;
            cbxSerial.SelectedIndexChanged += cbxSerial_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(5, 160);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(101, 20);
            label11.TabIndex = 6;
            label11.Text = "Serial number";
            // 
            // label17
            // 
            label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label17.Dock = System.Windows.Forms.DockStyle.Top;
            label17.Location = new System.Drawing.Point(0, 0);
            label17.Name = "label17";
            label17.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            label17.Size = new System.Drawing.Size(1458, 40);
            label17.TabIndex = 0;
            label17.Text = "Endlabel-PrinterScript";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label14);
            panel2.Location = new System.Drawing.Point(998, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(467, 393);
            panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(9, 128);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(437, 200);
            dataGridView1.TabIndex = 19;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(233, 89);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(213, 32);
            button7.TabIndex = 18;
            button7.Tag = "";
            button7.Text = "Delete selected display";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(9, 89);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(137, 32);
            button6.TabIndex = 17;
            button6.Tag = "";
            button6.Text = "Add displays";
            button6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 51);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(199, 20);
            label4.TabIndex = 8;
            label4.Text = "Used display/process picture";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new System.Drawing.Point(122, 341);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new System.Drawing.Size(323, 28);
            comboBox8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(5, 349);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(91, 20);
            label9.TabIndex = 6;
            label9.Text = "Start display";
            // 
            // label14
            // 
            label14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label14.Dock = System.Windows.Forms.DockStyle.Top;
            label14.Location = new System.Drawing.Point(0, 0);
            label14.Name = "label14";
            label14.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            label14.Size = new System.Drawing.Size(465, 40);
            label14.TabIndex = 0;
            label14.Text = "Program Control - Displays";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel6.Controls.Add(label3);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(btnEdit1);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(cbResetType);
            panel6.Controls.Add(cbCountertype);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label8);
            panel6.Location = new System.Drawing.Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(992, 393);
            panel6.TabIndex = 7;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Beige;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Location = new System.Drawing.Point(9, 52);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(977, 159);
            label3.TabIndex = 29;
            label3.Text = resources.GetString("label3.Text");
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(479, 345);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(87, 32);
            button2.TabIndex = 18;
            button2.Tag = "";
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(479, 309);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(87, 32);
            button1.TabIndex = 17;
            button1.Tag = "";
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEdit1
            // 
            btnEdit1.Location = new System.Drawing.Point(479, 273);
            btnEdit1.Name = "btnEdit1";
            btnEdit1.Size = new System.Drawing.Size(87, 32);
            btnEdit1.TabIndex = 16;
            btnEdit1.Tag = "";
            btnEdit1.Text = "Edit";
            btnEdit1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(122, 229);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 20);
            label5.TabIndex = 14;
            label5.Text = "Endlabel 1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(148, 346);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(323, 28);
            comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 349);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 20);
            label1.TabIndex = 6;
            label1.Text = "Duplicate(DB)";
            // 
            // cbResetType
            // 
            cbResetType.FormattingEnabled = true;
            cbResetType.Location = new System.Drawing.Point(148, 310);
            cbResetType.Name = "cbResetType";
            cbResetType.Size = new System.Drawing.Size(323, 28);
            cbResetType.TabIndex = 5;
            // 
            // cbCountertype
            // 
            cbCountertype.FormattingEnabled = true;
            cbCountertype.Location = new System.Drawing.Point(148, 273);
            cbCountertype.Name = "cbCountertype";
            cbCountertype.Size = new System.Drawing.Size(323, 28);
            cbCountertype.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(5, 313);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(132, 20);
            label13.TabIndex = 2;
            label13.Text = "Duplicate(Control)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(5, 276);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(126, 20);
            label12.TabIndex = 1;
            label12.Text = "Original-Endlabel";
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label8.Dock = System.Windows.Forms.DockStyle.Top;
            label8.Location = new System.Drawing.Point(0, 0);
            label8.Name = "label8";
            label8.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            label8.Size = new System.Drawing.Size(990, 40);
            label8.TabIndex = 0;
            label8.Text = "Endlabel-PrinterScript";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAutomatControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ucAutomatControl";
            Size = new System.Drawing.Size(1473, 1031);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAutoLogout;
        private System.Windows.Forms.CheckBox cbIsAutoLogout;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMinETMMeasVal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbResetType;
        private System.Windows.Forms.ComboBox cbCountertype;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbxSerial;
        private System.Windows.Forms.Button btnAutomatParam;
    }
}
