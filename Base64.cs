using System;
using System.Text;

namespace Verschlüsselung
{
    public class encodeBase64 : IEncoder
    {
        public string Encode(string input)
        {
            string encodedText = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
            return encodedText;
        }
    }
    public class decodeBase64 : IEncoder
    {
        public string Encode(string input)
        {
            string decodedText = Encoding.UTF8.GetString(Convert.FromBase64String(input));
            return decodedText;
        }
    }
}

