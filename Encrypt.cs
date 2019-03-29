using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Verschlüsselung
{
    public class Rijndael : ICrypto
    {
        public string Encode(string input)
        {
            System.Security.Cryptography.Rijndael alg = System.Security.Cryptography.Rijndael.Create();
            alg.Key = Encoding.UTF8.GetBytes("kaudkwudhtbenwnakaudkwudhtbenwna");
            alg.IV = Encoding.UTF8.GetBytes("HR$2pIjHR$2pIj12");
            alg.Padding = PaddingMode.Zeros;

            ICryptoTransform encryptor = alg.CreateEncryptor(alg.Key, alg.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(input);
                    }
                    return Encoding.Unicode.GetString(msEncrypt.ToArray());
                }
            }
        }
        public string Decode(string input)
        {
            System.Security.Cryptography.Rijndael alg = System.Security.Cryptography.Rijndael.Create();
            alg.Key = Encoding.UTF8.GetBytes("kaudkwudhtbenwnakaudkwudhtbenwna");
            alg.IV = Encoding.UTF8.GetBytes("HR$2pIjHR$2pIj12");
            alg.Padding = PaddingMode.Zeros;
            string result;
            ICryptoTransform decryptor = alg.CreateDecryptor(alg.Key, alg.IV);
            using (MemoryStream msDecrypt = new MemoryStream(Encoding.Unicode.GetBytes(input)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        result = srDecrypt.ReadToEnd();
                    }
                }
            }
            return result;
        }
    }
}

