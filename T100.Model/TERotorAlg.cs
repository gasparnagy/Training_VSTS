using System.Linq;
using System;

namespace T100.Model
{
    /// <summary>
    /// Rotor algorithm that encripts TURING to ENIGMA and the other letters beased on a code table. This rotor does not use the position.
    /// </summary>
    public class TERotorAlg : IRotorAlg
    {
        private const string codeTable = "OPQRSTAUGWXYZM .BICENFHJKLV@D";
        
        public int Encrypt(int position, int src)
        {
            return Helper.LetterToCode(codeTable[src]);
        }

        public int Decrypt(int position, int enc)
        {
            return codeTable.IndexOf(Helper.CodeToLetter(enc));
        }
    }
}