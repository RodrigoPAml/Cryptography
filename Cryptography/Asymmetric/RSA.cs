using System.Security.Cryptography;
using System.Text;

namespace Cryptography.Asymmetric
{
    public static class RSA
    {
        public static byte[] Encrypt(string plainText, string publicKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);

                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);

                return rsa.Encrypt(dataToEncrypt, false);
            }
        }

        public static string Decrypt(byte[] encryptedBytes, string privateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);

                byte[] decryptedData = rsa.Decrypt(encryptedBytes, false);

                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }
}
