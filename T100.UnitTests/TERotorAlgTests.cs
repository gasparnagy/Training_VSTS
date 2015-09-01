using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T100.Model;

namespace T100.UnitTests
{
    [TestClass]
    public class TERotorAlgTests
    {
        [TestMethod]
        public void Encodes_TURING_to_ENIGMA()
        {
            var sut = new TERotorAlg();

            const string input = "TURING";
            var output = TestHelpers.Encrypt(sut, input, 0);
            Assert.AreEqual("ENIGMA", output);
        }

        [TestMethod]
        public void Can_decode_encoded_alphabet()
        {
            var sut = new TERotorAlg();

            const string input = Helper.Alphabet;
            var encAlphabet = TestHelpers.Encrypt(sut, input, 0);
            var decAlphabet = TestHelpers.Decrypt(sut, encAlphabet, 0);
            
            Assert.AreEqual(input, decAlphabet);
        }

        [TestMethod]
        public void Independent_of_parameter()
        {
            var sut = new TERotorAlg();

            const string input = Helper.Alphabet;
            var encAlphabet0 = TestHelpers.Encrypt(sut, input, 0);
            var encAlphabet1 = TestHelpers.Encrypt(sut, input, 1);

            Assert.AreEqual(encAlphabet0, encAlphabet1);
        }
    }
}
