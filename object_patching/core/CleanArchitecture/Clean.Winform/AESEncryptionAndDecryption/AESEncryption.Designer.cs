namespace AESEncryptionAndDecryption
{
    partial class AESEncryption
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtxtInput = new RichTextBox();
            rtxtOutput = new RichTextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            SuspendLayout();
            // 
            // rtxtInput
            // 
            rtxtInput.Location = new Point(12, 12);
            rtxtInput.Name = "rtxtInput";
            rtxtInput.Size = new Size(388, 417);
            rtxtInput.TabIndex = 0;
            rtxtInput.Text = "";
            // 
            // rtxtOutput
            // 
            rtxtOutput.Location = new Point(533, 12);
            rtxtOutput.Name = "rtxtOutput";
            rtxtOutput.Size = new Size(388, 417);
            rtxtOutput.TabIndex = 1;
            rtxtOutput.Text = "";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(419, 170);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(94, 29);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click_1;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(419, 218);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(94, 29);
            btnDecrypt.TabIndex = 3;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // AESEncryption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 441);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(rtxtOutput);
            Controls.Add(rtxtInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AESEncryption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AES Encryption";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxtInput;
        private RichTextBox rtxtOutput;
        private Button btnEncrypt;
        private Button btnDecrypt;
    }
}