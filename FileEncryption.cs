using System;
using System.IO;
using System.Text;
using Verschlüsselung;
namespace Verschlüsselung
{
    public class FileEncryption
    {

        public string EncodeDatei(string Datei, ICrypto coder)
        {
            string readText = File.ReadAllText(Datei, Encoding.UTF7);
            string Encodedtext = coder.Encode(readText);

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
        public string DecodeDatei(string Datei, ICrypto coder)
        {
            string readText = File.ReadAllText(Datei, Encoding.UTF7);
            string Encodedtext = coder.Decode(readText);

            try
            {
                string newDateiPfad = @"C:\Users\Marvin.Lehnert\Desktop\DecodedText.txt";
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