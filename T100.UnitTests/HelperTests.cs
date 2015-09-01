using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T100.Model;

namespace T100.UnitTests
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void Maps_supported_letters_to_0_28_range()
        {
            foreach (var letter in Helper.SupportedLetters)
            {
                int code = Helper.LetterToCode(letter);
                Assert.IsTrue(code >= 0 && code < Helper.AlphabetLength);
            }
        }

        [TestMethod]
        public void Maps_0_28_range_to_alphabet()
        {
            for (int i = 0; i < Helper.AlphabetLength; i++)
            {
                var letter = Helper.CodeToLetter(i);
                StringAssert.Contains(Helper.Alphabet, letter.ToString());
            }
        }

        [TestMethod]
        public void Maps_lowercase_letters_as_uppercase()
        {
            foreach (var letter in Helper.Alphabet)
            {
                int code = Helper.LetterToCode(letter);
                int lowerCaseCode = Helper.LetterToCode(char.ToLowerInvariant(letter));
                Assert.AreEqual(code, lowerCaseCode);
            }
        }

        [TestMethod]
        public void CodeToLetter_is_reverse_of_LetterToCode()
        {
            foreach (var letter in Helper.Alphabet)
            {
                int code = Helper.LetterToCode(letter);
                var decodedLetter = Helper.CodeToLetter(code);
                Assert.AreEqual(letter, decodedLetter);
            }
        }
    }
}
