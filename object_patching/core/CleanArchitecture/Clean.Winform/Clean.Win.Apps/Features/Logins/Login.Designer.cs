
namespace Clean.Win.AppUI.Features.Logins
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new System.Windows.Forms.Panel();
            txtPassword = new System.Windows.Forms.TextBox();
            txtUserID = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblUserID = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserID);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUserID);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(425, 111);
            panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(113, 64);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(292, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "123456";
            txtPassword.KeyDown += textBox1_KeyDown;
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(113, 20);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new System.Drawing.Size(292, 27);
            txtUserID.TabIndex = 2;
            txtUserID.Text = "admin";
            txtUserID.KeyDown += textBox1_KeyDown;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(25, 64);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new System.Drawing.Point(25, 20);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new System.Drawing.Size(57, 20);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "User ID";
            // 
            // btnLogin
            // 
            btnLogin.Image = (System.Drawing.Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogin.Location = new System.Drawing.Point(200, 18);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(110, 31);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "OK";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(327, 18);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(110, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnLogin);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 137);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(450, 69);
            panel2.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            ClientSize = new System.Drawing.Size(450, 206);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "User Login";
            FormClosed += Login_FormClosed;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
    }
}