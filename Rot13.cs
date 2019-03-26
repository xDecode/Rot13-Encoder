using System;

namespace Verschlüsselung
{
    public class Rot13
    {
        public string Encode(string TextToEncode)
        {
            char[] wort = TextToEncode.ToCharArray();
            for (int i = 0; i < wort.Length; i++)
            {
                int number = wort[i];
                if (number >= 'a' && number <= 'z')
                {
                    if (number <= 'm')
                    {
                        number += 13;
                    }
                    else
                    {
                        number -= 13;
                    }
                }
                if (number >= 'A' && number <= 'Z')
                {
                    if (number <= 'M')
                    {
                        number += 13;
                    }
                    else
                    {
                        number -= 13;
                    }
                }
                wort[i] = (char)number;
            }
            return new string(wort);
        }
    }
}