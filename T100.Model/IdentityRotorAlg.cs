using System.Linq;
using System;

namespace T100.Model
{
    public class IdentityRotorAlg : IRotorAlg
    {
        public int Encrypt(int position, int src)
        {
            return src;
        }

        public int Decrypt(int position, int enc)
        {
            return enc;
        }
    }
}