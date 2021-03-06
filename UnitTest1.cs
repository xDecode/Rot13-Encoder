using Xunit;
namespace Verschlüsselung
{
    public class UnitTest1
    {
        [Fact]
        public void TestEncodeForN()
        {
            var verschlüsseler = new Rot13();
            Assert.Equal("n o p q r s t u v w x y z a b c d e f g h i j k l m", verschlüsseler.Encode("a b c d e f g h i j k l m n o p q r s t u v w x y z"));
        }

        [Fact]
        public void TestEncodeUmlaute()
        {
            var verschlüsseler = new Rot13();
            Assert.Equal("äüöß", verschlüsseler.Encode("äüöß"));
        }

        [Fact]
        public void TestEncode()
        {
            var verschlüsseler = new Rot13();
            Assert.Equal("Qnf vfg Trurvz", verschlüsseler.Encode("Das ist Geheim"));
        }

        [Fact]
        public void TestEncodeSentence()
        {
            var verschlüsseler = new Rot13();
            Assert.Equal("N O P Q R S T U V W X Y Z A B C D E F G H I D K L M", verschlüsseler.Encode("A B C D E F G H I J K L M N O P Q R S T U V Q X Y Z"));
        }

        [Fact]
        public void TestEncodeDatei()
        {
            var Fileverschlüsseler = new FileEncryption();
            ICrypto rot13 = new Rot13();
            ICrypto base64 = new Base64();
            ICrypto encrypter = new Rijndael();

            // var verschlüsselt = Fileverschlüsseler.EncodeDatei("C:/Users/Marvin.Lehnert/Desktop/Text.txt", encrypter);
            // var entschlüsselt = decrypter.Code(verschlüsselt);
            // Assert.Equal("Dies ist ein Test", Fileverschlüsseler.EncodeDatei("C:/Users/Marvin.Lehnert/Desktop/Text.txt", encrypter));      
            Assert.Equal("Dies ist ein Test", Fileverschlüsseler.DecodeDatei("C:/Users/Marvin.Lehnert/Desktop/EncodedText.txt", encrypter));      

        }
    }
}

