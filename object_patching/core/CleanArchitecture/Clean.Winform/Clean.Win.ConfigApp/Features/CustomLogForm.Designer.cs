namespace Clean.Win.AppUI.Features
{
    partial class CustomLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomLogForm));
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblLanguage = new System.Windows.Forms.Label();
            lblLocalTime = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            lblApp = new System.Windows.Forms.Label();
            richTextError = new System.Windows.Forms.RichTextBox();
            btnClose = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnCopy = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblLanguage);
            groupBox1.Controls.Add(lblLocalTime);
            groupBox1.Controls.Add(lblUser);
            groupBox1.Controls.Add(lblApp);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(870, 90);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new System.Drawing.Point(316, 52);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new System.Drawing.Size(77, 20);
            lblLanguage.TabIndex = 0;
            lblLanguage.Text = "Language:";
            // 
            // lblLocalTime
            // 
            lblLocalTime.AutoSize = true;
            lblLocalTime.Location = new System.Drawing.Point(316, 23);
            lblLocalTime.Name = "lblLocalTime";
            lblLocalTime.Size = new System.Drawing.Size(81, 20);
            lblLocalTime.TabIndex = 0;
            lblLocalTime.Text = "Local time:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(15, 53);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(41, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "User:";
            // 
            // lblApp
            // 
            lblApp.AutoSize = true;
            lblApp.Location = new System.Drawing.Point(15, 23);
            lblApp.Name = "lblApp";
            lblApp.Size = new System.Drawing.Size(40, 20);
            lblApp.TabIndex = 0;
            lblApp.Text = "App:";
            // 
            // richTextError
            // 
            richTextError.Location = new System.Drawing.Point(11, 111);
            richTextError.Name = "richTextError";
            richTextError.Size = new System.Drawing.Size(872, 419);
            richTextError.TabIndex = 1;
            richTextError.Text = "";
            // 
            // btnClose
            // 
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(789, 538);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 33);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Image = (System.Drawing.Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClear.Location = new System.Drawing.Point(689, 538);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 33);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCopy
            // 
            btnCopy.Image = (System.Drawing.Image)resources.GetObject("btnCopy.Image");
            btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCopy.Location = new System.Drawing.Point(511, 538);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(172, 33);
            btnCopy.TabIndex = 3;
            btnCopy.Text = "Copy to clipboard";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(11, 538);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(148, 33);
            button1.TabIndex = 3;
            button1.Text = "Send as report";
            button1.UseVisualStyleBackColor = true;
            // 
            // CustomLogForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(894, 578);
            ControlBox = false;
            Controls.Add(btnCopy);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(richTextError);
            Controls.Add(groupBox1);
            Name = "CustomLogForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DEBUGLOG(tracking error application)";
            FormClosing += CustomLogForm_FormClosing;
            Load += CustomLogForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblLocalTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox richTextError;
    }
}