using System.Linq;
using System;

namespace T100.Model
{
    /// <summary>
    /// Rotor algorithm that encrypt the input by taking the modulo of the multiplication of the input with the parameter. The parameter is 3, 5 or 7 depending on the position.
    /// </summary>
    public class ModRotorAlg : IRotorAlg
    {
        public int Encrypt(int position, int src)
        {
            int parameter = Helper.GetParameter(position);
            return (src * parameter) % Helper.AlphabetLength;
        }

        public int Decrypt(int position, int enc)
        {
            var decryptTable = new int[Helper.AlphabetLength];
            for (int i = 0; i < Helper.AlphabetLength; i++)
                decryptTable[Encrypt(position, i)] = i;

            return decryptTable[enc];
        }
    }
}