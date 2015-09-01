using System.Linq;
using System;
using System.Text;
using T100.Model;

namespace T100.UnitTests
{
    public static class TestHelpers
    {
        public static string Encrypt(IRotorAlg rotorAlg, string input, int position)
        {
            var output = new StringBuilder();
            foreach (var letter in input)
            {
                var encLetter = Helper.CodeToLetter(rotorAlg.Encrypt(position, Helper.LetterToCode(letter)));
                output.Append(encLetter);
            }
            return output.ToString();
        }

        public static string Decrypt(IRotorAlg rotorAlg, string input, int position)
        {
            var output = new StringBuilder();
            foreach (var letter in input)
            {
                var encLetter = Helper.CodeToLetter(rotorAlg.Decrypt(position, Helper.LetterToCode(letter)));
                output.Append(encLetter);
            }
            return output.ToString();
        }
    }
}