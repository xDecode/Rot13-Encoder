using System;
using System.IO;
using System.Text;
using Verschlüsselung;
namespace Verschlüsselung
{
    public class FileEncryption
    {

        public string EncodeDatei(string Datei, IEncoder encoder)
        {
            string readText = File.ReadAllText(Datei, Encoding.UTF7);
            string Encodedtext = encoder.Encode(readText);

            try
            {
                string newDateiPfad = @"C:\Users\Marvin.Lehnert\Desktop\EncodedText.txt";
                File.WriteAllText(newDateiPfad, Encodedtext, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Encodedtext;

        }
    }
}