namespace BiasysControl.Features.Bobbin
{
    partial class BobbinNumberInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BobbinNumberInput));
            panel1 = new Panel();
            txtNumberOfStitches = new TextBox();
            lblBobbinNumber = new Label();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnDel = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btnDot = new Button();
            pnlLine = new Panel();
            btnOK = new Button();
            txtBobbinNumber = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNumberOfStitches);
            panel1.Controls.Add(lblBobbinNumber);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btnDot);
            panel1.Controls.Add(pnlLine);
            panel1.Controls.Add(btnOK);
            panel1.Controls.Add(txtBobbinNumber);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 226);
            panel1.TabIndex = 1;
            // 
            // txtNumberOfStitches
            // 
            txtNumberOfStitches.Location = new Point(13, 50);
            txtNumberOfStitches.Name = "txtNumberOfStitches";
            txtNumberOfStitches.Size = new Size(417, 27);
            txtNumberOfStitches.TabIndex = 10;
            txtNumberOfStitches.Text = "1";
            txtNumberOfStitches.TextAlign = HorizontalAlignment.Center;
            txtNumberOfStitches.Visible = false;
            txtNumberOfStitches.MouseLeave += txtNumberOfStitches_MouseLeave;
            // 
            // lblBobbinNumber
            // 
            lblBobbinNumber.AutoSize = true;
            lblBobbinNumber.Location = new Point(13, 11);
            lblBobbinNumber.Name = "lblBobbinNumber";
            lblBobbinNumber.Size = new Size(150, 20);
            lblBobbinNumber.TabIndex = 9;
            lblBobbinNumber.Text = "Input Bobbin number";
            // 
            // btn5
            // 
            btn5.ImageAlign = ContentAlignment.MiddleLeft;
            btn5.Location = new Point(10, 164);
            btn5.Name = "btn5";
            btn5.Size = new Size(83, 51);
            btn5.TabIndex = 7;
            btn5.Tag = "5";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn0_Click;
            // 
            // btn6
            // 
            btn6.ImageAlign = ContentAlignment.MiddleLeft;
            btn6.Location = new Point(97, 164);
            btn6.Name = "btn6";
            btn6.Size = new Size(83, 51);
            btn6.TabIndex = 7;
            btn6.Tag = "6";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.ImageAlign = ContentAlignment.MiddleLeft;
            btn7.Location = new Point(185, 164);
            btn7.Name = "btn7";
            btn7.Size = new Size(83, 51);
            btn7.TabIndex = 7;
            btn7.Tag = "7";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.ImageAlign = ContentAlignment.MiddleLeft;
            btn9.Location = new Point(360, 164);
            btn9.Name = "btn9";
            btn9.Size = new Size(83, 51);
            btn9.TabIndex = 7;
            btn9.Tag = "9";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.ImageAlign = ContentAlignment.MiddleLeft;
            btn8.Location = new Point(273, 164);
            btn8.Name = "btn8";
            btn8.Size = new Size(83, 51);
            btn8.TabIndex = 7;
            btn8.Tag = "8";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn0_Click;
            // 
            // btnDel
            // 
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(448, 164);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(102, 51);
            btnDel.TabIndex = 7;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btn0_Click;
            // 
            // btn0
            // 
            btn0.ImageAlign = ContentAlignment.MiddleLeft;
            btn0.Location = new Point(10, 110);
            btn0.Name = "btn0";
            btn0.Size = new Size(83, 51);
            btn0.TabIndex = 8;
            btn0.Tag = "0";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            btn1.Location = new Point(97, 110);
            btn1.Name = "btn1";
            btn1.Size = new Size(83, 51);
            btn1.TabIndex = 8;
            btn1.Tag = "1";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.ImageAlign = ContentAlignment.MiddleLeft;
            btn2.Location = new Point(185, 110);
            btn2.Name = "btn2";
            btn2.Size = new Size(83, 51);
            btn2.TabIndex = 8;
            btn2.Tag = "2";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn0_Click;
            // 
            // btn4
            // 
            btn4.ImageAlign = ContentAlignment.MiddleLeft;
            btn4.Location = new Point(360, 110);
            btn4.Name = "btn4";
            btn4.Size = new Size(83, 51);
            btn4.TabIndex = 8;
            btn4.Tag = "4";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn0_Click;
            // 
            // btn3
            // 
            btn3.ImageAlign = ContentAlignment.MiddleLeft;
            btn3.Location = new Point(273, 110);
            btn3.Name = "btn3";
            btn3.Size = new Size(83, 51);
            btn3.TabIndex = 8;
            btn3.Tag = "3";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.ImageAlign = ContentAlignment.MiddleLeft;
            btnDot.Location = new Point(448, 110);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(102, 51);
            btnDot.TabIndex = 8;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btn0_Click;
            // 
            // pnlLine
            // 
            pnlLine.BackColor = SystemColors.ActiveCaptionText;
            pnlLine.Location = new Point(10, 94);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(540, 5);
            pnlLine.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.Image = (Image)resources.GetObject("btnOK.Image");
            btnOK.ImageAlign = ContentAlignment.MiddleLeft;
            btnOK.Location = new Point(448, 11);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(102, 69);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtBobbinNumber
            // 
            txtBobbinNumber.Location = new Point(13, 50);
            txtBobbinNumber.Name = "txtBobbinNumber";
            txtBobbinNumber.Size = new Size(417, 27);
            txtBobbinNumber.TabIndex = 2;
            txtBobbinNumber.Text = "1";
            txtBobbinNumber.TextAlign = HorizontalAlignment.Center;
            txtBobbinNumber.MouseLeave += txtBobbinNumber_MouseLeave;
            // 
            // BobbinNumberInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 248);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BobbinNumberInput";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bobbin number";
            FormClosed += BobbinNumberInput_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btnDel;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn4;
        private Button btn3;
        private Button btnDot;
        private Panel pnlLine;
        private Button btnOK;
        private TextBox txtBobbinNumber;
        private Label lblBobbinNumber;
        private TextBox txtNumberOfStitches;
    }
}