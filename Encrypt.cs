using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Verschlüsselung
{
    public class Encrypter : IEncoder
    {
        public string Encode(string input)
        {
            Rijndael alg = Rijndael.Create();
            alg.Key = Encoding.UTF8.GetBytes("kaudkwudhtbenwnakaudkwudhtbenwna");
            alg.IV = Encoding.UTF8.GetBytes("HR$2pIjHR$2pIj12");

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
    }
        public class Decrypter : IDecoder
        {
            public string Decode(string input)
            {
                Rijndael alg = Rijndael.Create();
                alg.Key = Encoding.UTF8.GetBytes("kaudkwudhtbenwnakaudkwudhtbenwna");
                alg.IV = Encoding.UTF8.GetBytes("HR$2pIjHR$2pIj12");

                ICryptoTransform decryptor = alg.CreateDecryptor(alg.Key, alg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(Encoding.Unicode.GetBytes(input)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
