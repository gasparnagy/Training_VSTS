using System.Linq;
using System;

namespace T100.Model
{
    /// <summary>
    /// Rotor algorithm that shits the input by 3, 5 or 7 depending on the position ('A' becomes 'D', etc.).
    /// </summary>
    public class ShiftRotorAlg : IRotorAlg
    {
        public int Encrypt(int position, int src)
        {
            int parameter = Helper.GetParameter(position);
            return (src + parameter) % Helper.AlphabetLength;
        }

        public int Decrypt(int position, int enc)
        {
            int parameter = Helper.GetParameter(position);
            return (enc - parameter + Helper.AlphabetLength) % Helper.AlphabetLength;
        }
    }
}