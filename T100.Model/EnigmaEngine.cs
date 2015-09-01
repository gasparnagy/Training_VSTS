using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T100.Model
{
    public class EnigmaEngine
    {
        private IEnumerable<IRotor> GetRotors(IRotor firstRotor)
        {
            var rotor = firstRotor;
            while (rotor != null)
            {
                yield return rotor;
                rotor = rotor.ParentRotor;
            }
        }

        public string Encrypt(string input, IRotor firstRotor)
        {
            var result = new StringBuilder();
            foreach (var letter in input)
            {
                var enc = Helper.LetterToCode(letter);

                foreach (var rotor in GetRotors(firstRotor))
                {
                    enc = rotor.Encrypt(enc);
                }

                var encLetter = Helper.CodeToLetter(enc);
                result.Append(encLetter);

                firstRotor.Step();
            }
            return result.ToString();
        }

        public string Decrypt(string input, IRotor firstRotor)
        {
            var result = new StringBuilder();
            foreach (var letter in input)
            {
                var enc = Helper.LetterToCode(letter);

                foreach (var rotor in GetRotors(firstRotor).Reverse())
                {
                    enc = rotor.Decrypt(enc);
                }

                var encLetter = Helper.CodeToLetter(enc);
                result.Append(encLetter);

                firstRotor.Step();
            }
            return result.ToString();
        }
    }
}
