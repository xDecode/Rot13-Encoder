using System;

namespace Verschlüsselung
{
    public class Rot13
    {
        private const int v = 13;
        public string Encode(string TextToEncode)
        {
            char[] wort = TextToEncode.ToCharArray();
            for (int i = 0; i < wort.Length; i++)
            {
                int number = wort[i];
               
                if (number >= 'a' && number <= 'z' || number >= 'A' && number <= 'Z')
                {
                    if (number <= 'm' && number >= 'a' || number <= 'M' && number >= 'A')
                    {
                        number += v;
                    }
                    else 
                    {
                        number -= v;
                    }
                }
                wort[i] = (char)number;
            }
            return new string(wort);
        }
    }
}