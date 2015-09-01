using System.Linq;
using System;

namespace T100.Model
{
    public interface IRotor
    {
        IRotor ParentRotor { get; }
        void AttachTo(IRotor parentRotor);
        void Step();
        int Encrypt(int src);
        int Decrypt(int enc);
    }

    public class Rotor : IRotor
    {
        public IRotorAlg Algorithm { get; private set; }
        public int Position { get; private set; }
        public IRotor ParentRotor { get; private set; }

        public Rotor(IRotorAlg algorithm, int initialPosition)
        {
            Algorithm = algorithm;
            Position = initialPosition;
        }

        public void AttachTo(IRotor parentRotor)
        {
            ParentRotor = parentRotor;
        }

        public void Step()
        {
            Position = (Position + 1) % Helper.RotorPositions;
            if (Position == 0 && ParentRotor != null) // overturned
                ParentRotor.Step();
        }

        public int Encrypt(int src)
        {
            return Algorithm.Encrypt(Position, src);
        }

        public int Decrypt(int enc)
        {
            return Algorithm.Decrypt(Position, enc);
        }
    }
}