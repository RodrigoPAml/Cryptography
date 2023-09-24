using Cryptography.Asymmetric;
using Cryptography.Symmetric;
using Cryptography.Utils;

namespace Program
{
    public class Program
    {
        static void ExampleAES()
        {
            var key = Utils.GenerateRandomKey(32);
            var iv = Utils.GenerateRandomKey(16);

            var result = AES.Encrypt("text_to_hide", key, iv);

            Console.WriteLine(AES.Decrypt(result, key, iv)); 
        }

        static void ExampleRSA()
        {
            (string publicKey, string privateKey) = Utils.GenerateRSAKeys(2048);

            var result = RSA.Encrypt("text_to_hide", publicKey);

            Console.WriteLine(RSA.Decrypt(result, privateKey));
        }

        static void Main()
        {
            ExampleAES();
            ExampleRSA();
        }
    }
}