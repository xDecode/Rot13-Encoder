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
    }
}

