using Clean.WinF.Common.Utilities;
using System.Configuration;

namespace AESEncryptionAndDecryption
{
    public partial class AESEncryption : Form
    {
        public AESEncryption()
        {
            InitializeComponent();
        }
        string encryptKey = string.Empty;
        string encryptIV = string.Empty;
        private void AESEncryption_Load(object sender, EventArgs e)
        {
            encryptKey = ConfigurationManager.AppSettings["EncryptionKey"];
            encryptIV = ConfigurationManager.AppSettings["EncryptionIV"];
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            if (this.rtxtInput.Text.Length > 0)
            {
                this.rtxtOutput.Text = string.Empty;
                encryptKey = ConfigurationManager.AppSettings["EncryptionKey"];
                encryptIV = ConfigurationManager.AppSettings["EncryptionIV"];
                var result = EncryptUtility.EncryptString(rtxtInput.Text.Trim(), encryptKey, encryptIV);
                this.rtxtOutput.Text = result;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (this.rtxtOutput.Text.Length > 0)
            {
                this.rtxtInput.Text = string.Empty;
                encryptKey = ConfigurationManager.AppSettings["EncryptionKey"];
                encryptIV = ConfigurationManager.AppSettings["EncryptionIV"];
                var result = EncryptUtility.DecryptString(rtxtOutput.Text.Trim(), encryptKey, encryptIV);
                this.rtxtInput.Text = result;
            }
        }
    }
}