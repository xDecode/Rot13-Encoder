namespace Verschlüsselung
{
    public class Rot13
    {
        public string Encode(string input)
        {
            string result = "";
            foreach (char currentChar in input)
            {
                int rot13 = -13;
                int adjustmentValue = char.IsLower(currentChar) ? 32 : 0;
                int charValue = currentChar - adjustmentValue;

                if (char.IsLetter(currentChar))
                {
                    if (charValue <= 'M' && charValue >= 'A')
                        rot13 = 13;
                    charValue += adjustmentValue + rot13;
                }
                result = result + (char)charValue;
            }
            return result;
        }
    }
}