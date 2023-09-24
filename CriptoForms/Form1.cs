using Cryptography.Asymmetric;
using Cryptography.Symmetric;
using Cryptography.Utils;

namespace CriptoForms
{
    public partial class CryptoForm : Form
    {
        
        public CryptoForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click_1(object sender, EventArgs e)
        {
            textBoxPrivateKey.Text = string.Empty;
            textBoxPublicKey.Text = string.Empty;
            textBoxIV.Text = string.Empty;

            if (radioAESBtn.Checked)
            {
                textBoxPrivateKey.Text = Utils.ToString(Utils.GenerateRandomKey(32));
                textBoxIV.Text = Utils.ToString(Utils.GenerateRandomKey(16));
            }
               
            if (radioRSABtn.Checked)
            {
                (string publicKey, string privateKey) = Utils.GenerateRSAKeys(2048);

                textBoxPrivateKey.Text = privateKey;
                textBoxPublicKey.Text = publicKey;
            }
        }

        private void radioAESBtn_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrivateKey.Text = string.Empty;
            textBoxPublicKey.Text = string.Empty;
            textBoxIV.Text = string.Empty;

            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                textBoxIV.Enabled = true;
                textBoxPublicKey.Enabled = false;
                textBoxPrivateKey.Enabled = true;
            }
        }

        private void radioRSABtn_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrivateKey.Text = string.Empty;
            textBoxPublicKey.Text = string.Empty;
            textBoxIV.Text = string.Empty;

            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                textBoxIV.Enabled = false;
                textBoxPublicKey.Enabled = true;
                textBoxPrivateKey.Enabled = true;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (checkBoxDecrypt.Checked)
            {
                try
                {
                    if(radioAESBtn.Checked)
                    {
                        var text = Convert.FromBase64String(textBoxEncryptedText.Text);
                        var iv = Convert.FromBase64String(textBoxIV.Text);
                        var key = Convert.FromBase64String(textBoxPrivateKey.Text);

                        textBoxPlainText.Text = AES.Decrypt(text, key, iv);
                    }
                    else
                    {
                        var text = Convert.FromBase64String(textBoxEncryptedText.Text);
                        textBoxPlainText.Text = RSA.Decrypt(text, textBoxPrivateKey.Text);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
            else if(checkBoxEncrypt.Checked)
            {
                try
                {
                    if (radioAESBtn.Checked)
                    {
                        var text = textBoxPlainText.Text;
                        var iv = Convert.FromBase64String(textBoxIV.Text);
                        var key = Convert.FromBase64String(textBoxPrivateKey.Text);

                        textBoxEncryptedText.Text = Convert.ToBase64String(AES.Encrypt(text, key, iv));
                    }
                    else
                    {
                        var text = textBoxPlainText.Text;
                        textBoxEncryptedText.Text = Convert.ToBase64String(RSA.Encrypt(text, textBoxPublicKey.Text));
                    }
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void checkBoxEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlainText.Text = string.Empty;
            textBoxEncryptedText.Text = string.Empty;
            
            CheckBox box = (CheckBox)sender;    

            if(box.Checked)
            {
                checkBoxDecrypt.Checked = false;
            }
        }

        private void checkBoxDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlainText.Text = string.Empty;
            textBoxEncryptedText.Text = string.Empty;

            CheckBox box = (CheckBox)sender;

            if (box.Checked)
            {
                checkBoxEncrypt.Checked = false;
            }
        }
    }
}