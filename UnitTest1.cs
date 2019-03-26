using System;
using Xunit;

namespace Verschlüsselung
{
    public class UnitTest1
    {
        [Fact]
        public void TestEncodeForN()
        {
            var verschlüsseler = new Rot13();
            Assert.Equal("aaaa AAAA", verschlüsseler.Encode("nnnn NNNN"));
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
            Assert.Equal("Arva, vfg rva Grfg, hz mh grfgra, bo qnf shagvbavreg", verschlüsseler.Encode("Nein, ist ein Test, um zu testen, ob das funtioniert"));
        }
    }
}

