using System.Security.Cryptography;

namespace Cryptography.Utils
{
    public static class Utils
    {
        public static string ToString(byte[] data)
        {
            return Convert.ToBase64String(data);
        }

        public static byte[] ToByte(string data)
        {
            return Convert.FromBase64String(data);
        }

        public static byte[] GenerateRandomKey(int byteLength)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] keyBytes = new byte[byteLength];

                rng.GetBytes(keyBytes);

                return keyBytes;
            }
        }

        public static (string, string) GenerateRSAKeys(int keySize)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize))
            {
                string publicKeyXml = rsa.ToXmlString(false);
                string privateKeyXml = rsa.ToXmlString(true);
                return (publicKeyXml, privateKeyXml);
            }
        }
    }
}
