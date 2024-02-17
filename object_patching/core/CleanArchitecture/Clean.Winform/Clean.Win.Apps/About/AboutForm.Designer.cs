namespace Clean.Win.AppUI.About
{
    partial class AboutForm
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
            lblVersion = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblDevMode = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            linkContact = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(31, 78);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(91, 20);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version 1.0.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 165);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 20);
            label3.TabIndex = 2;
            // 
            // lblDevMode
            // 
            lblDevMode.AutoSize = true;
            lblDevMode.Location = new System.Drawing.Point(31, 118);
            lblDevMode.Name = "lblDevMode";
            lblDevMode.Size = new System.Drawing.Size(230, 20);
            lblDevMode.TabIndex = 3;
            lblDevMode.Text = "Product is in Development mode.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(31, 321);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 20);
            label5.TabIndex = 4;
            label5.Text = "Copyright © Ltd";
            // 
            // linkContact
            // 
            linkContact.AutoSize = true;
            linkContact.Location = new System.Drawing.Point(31, 161);
            linkContact.Name = "linkContact";
            linkContact.Size = new System.Drawing.Size(144, 20);
            linkContact.TabIndex = 5;
            linkContact.TabStop = true;
            linkContact.Text = "Contact@gmail.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 213);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 20);
            label1.TabIndex = 6;
            label1.Text = "Company's information";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(692, 350);
            Controls.Add(label1);
            Controls.Add(linkContact);
            Controls.Add(label5);
            Controls.Add(lblDevMode);
            Controls.Add(label3);
            Controls.Add(lblVersion);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "About";
            FormClosed += AboutForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDevMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkContact;
        private System.Windows.Forms.Label label1;
    }
}