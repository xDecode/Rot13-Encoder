namespace Verschlüsselung
{
    public interface ICrypto
    {
        string Decode(string input);
        string Encode(string input);
    }
}