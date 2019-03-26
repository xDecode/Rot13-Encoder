using System;
using Xunit;

namespace Verschlüsselung
{
    public class UnitTest1
    {
        [Fact]
        public void TestEncodeOneLetter()
        {
            var verschlüsseler = new Rot13();
            Assert.Equal("m", verschlüsseler.Encode("z"));
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
            Assert.Equal("Qnf vfg rva Grfg, hz mh grfgra, bo qnf shagvbavreg", verschlüsseler.Encode("Das ist ein Test, um zu testen, ob das funtioniert"));
        }
    }
}

