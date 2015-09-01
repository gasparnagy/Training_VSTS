using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T100.Model;

namespace T100.UnitTests
{
    [TestClass]
    public class EnigmaEngineTests
    {
        [TestMethod]
        public void Encrypts_single_letter_with_single_rotor()
        {
            var sut = new EnigmaEngine();
            var rotor = new Rotor(new TERotorAlg(), 0);

            var result = sut.Encrypt("T", rotor); //TERotorAlg encrypts TURING to ENIGMA (so T -> E)
            Assert.AreEqual("E", result);
        }

        [TestMethod]
        public void Encrypts_text_with_single_rotor()
        {
            var sut = new EnigmaEngine();
            var rotor = new Rotor(new TERotorAlg(), 0);

            var result = sut.Encrypt("TURING", rotor); //TERotorAlg encrypts TURING to ENIGMA
            Assert.AreEqual("ENIGMA", result);
        }

        [TestMethod]
        public void Steps_rotors_after_letters()
        {
            var sut = new EnigmaEngine();
            var rotor = new Rotor(new ShiftRotorAlg(), 0);

            var result = sut.Encrypt("AAA", rotor); //ShiftRotorAlg depends on position, so same letters should encoded to different ones
            Assert.AreNotEqual(result[0], result[1]);
            Assert.AreNotEqual(result[0], result[2]);
        }

        [TestMethod]
        public void Encrypts_text_with_two_rotors()
        {
            var sut = new EnigmaEngine();
            var rotor = new Rotor(new TERotorAlg(), 0); //TERotorAlg encrypts TURING to ENIGMA (so T -> E)
            rotor.AttachTo(new Rotor(new ShiftRotorAlg(), 0)); //ShiftRotorAlg encrypts E to H (with position 0)

            var result = sut.Encrypt("T", rotor); 
            Assert.AreEqual("H", result);
        }

        [TestMethod]
        public void Encrypts_text_with_multiple_rotors()
        {
            var sut = new EnigmaEngine();
            var rotor = new Rotor(new TERotorAlg(), 0); //TERotorAlg encrypts TURING to ENIGMA (so T -> E)
            rotor.AttachTo(new Rotor(new ShiftRotorAlg(), 0)); //ShiftRotorAlg encrypts E to H (with position 0)
            rotor.ParentRotor.AttachTo(new Rotor(new ShiftRotorAlg(), 0)); //ShiftRotorAlg encrypts H to K (with position 0)

            var result = sut.Encrypt("T", rotor); 
            Assert.AreEqual("K", result);
        }

        [TestMethod]
        public void Decrypts_single_letter_with_single_rotor()
        {
            var sut = new EnigmaEngine();
            var rotor = new Rotor(new TERotorAlg(), 0);

            var result = sut.Decrypt("E", rotor); //TERotorAlg encrypts TURING to ENIGMA (so T -> E)
            Assert.AreEqual("T", result);
        }

        [TestMethod]
        public void Decrypts_alphabet_with_single_rotor()
        {
            var sut = new EnigmaEngine();
            var rotor = new Rotor(new ShiftRotorAlg(), 0);

            var enc = sut.Encrypt(Helper.Alphabet, rotor);

            rotor = new Rotor(new ShiftRotorAlg(), 0); // reset rotor to the same initial position
            var result = sut.Decrypt(enc, rotor); 
            Assert.AreEqual(Helper.Alphabet, result);
        }

        private Rotor CreateComplexRotors()
        {
            var rotor = new Rotor(new TERotorAlg(), 0);
            rotor.AttachTo(new Rotor(new ShiftRotorAlg(), 0));
            rotor.ParentRotor.AttachTo(new Rotor(new ShiftRotorAlg(), 0));
            return rotor;
        }

        [TestMethod]
        public void Decrypts_alphabet_with_multiple_rotors()
        {
            var sut = new EnigmaEngine();
            var rotor = CreateComplexRotors();

            var enc = sut.Encrypt(Helper.Alphabet, rotor);

            rotor = CreateComplexRotors(); // reset rotor to the same initial position
            var result = sut.Decrypt(enc, rotor); 
            Assert.AreEqual(Helper.Alphabet, result);
        }
    }
}
