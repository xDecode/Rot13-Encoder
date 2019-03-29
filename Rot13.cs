namespace Verschlüsselung
{
    public class Rot13 : ICrypto
    {
        //Encoding and Decoding
        public string Encode(string input)
        {
            string result = "";
            foreach (char currentChar in input)
            {
                int rot13 = -13;
                int adjustmentValue = char.IsLower(currentChar) ? 32 : 0;
                int charValue = currentChar - adjustmentValue;

                if (char.IsLetter(currentChar) && checkUmlaut(currentChar) == false)
                {
                    if (charValue <= 'M' && charValue >= 'A')
                        rot13 = 13;
                    charValue += adjustmentValue + rot13;
                }

                if (checkUmlaut(currentChar) == true)
                {
                    result += currentChar;
                }
                else
                {
                    result += (char)charValue;
                }

            }
            return result;
        }
        public bool checkUmlaut(char Umlaut)
        {
            if (Umlaut == 'ä' || Umlaut == 'ü' || Umlaut == 'ö' || Umlaut == 'ß' || Umlaut == 'Ä' || Umlaut == 'Ü' || Umlaut == 'Ö')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Decode(string input)
        {
            string result = "";
            foreach (char currentChar in input)
            {
                int rot13 = -13;
                int adjustmentValue = char.IsLower(currentChar) ? 32 : 0;
                int charValue = currentChar - adjustmentValue;

                if (char.IsLetter(currentChar) && checkUmlaut(currentChar) == false)
                {
                    if (charValue <= 'M' && charValue >= 'A')
                        rot13 = 13;
                    charValue += adjustmentValue + rot13;
                }

                if (checkUmlaut(currentChar) == true)
                {
                    result += currentChar;
                }
                else
                {
                    result += (char)charValue;
                }

            }
            return result;
        }
    }
}
