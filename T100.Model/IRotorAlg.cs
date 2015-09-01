using System.Linq;
using System;

namespace T100.Model
{
    public interface IRotorAlg
    {
        int Encrypt(int position, int src);
        int Decrypt(int position, int enc);
    }
}