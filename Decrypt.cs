// using System;
// using System.IO;
// using System.Security.Cryptography;
// using System.Text;

// namespace Verschlüsselung
// {
//     public class Decrypter : IDecoder
//     {
//         public string Decode(string input)
//         {
//             Rijndael alg = Rijndael.Create();
//             alg.Key = Encoding.UTF8.GetBytes("kaudkwudhtbenwnakaudkwudhtbenwna");
//             alg.IV = Encoding.UTF8.GetBytes("HR$2pIjHR$2pIj12");

//             ICryptoTransform decryptor = alg.CreateDecryptor(alg.Key, alg.IV);
//             using (MemoryStream msDecrypt = new MemoryStream(Encoding.Unicode.GetBytes(input)))
//             {
//                 using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
//                 {
//                     using (StreamReader srDecrypt = new StreamReader(csDecrypt))
//                     {
//                         return srDecrypt.ReadToEnd();
//                     }
//                 }
//             }
//         }
//     }
//}