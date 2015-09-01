using System.Linq;
using System;

namespace T100.Model
{
    public static class Helper
    {
        public const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "@" + " " + ".";
        public const string SupportedLetters = "abcdefghijklmnopqrstuvwxyz" + Alphabet;

        public const int AlphabetLength = 29;
        public const int RotorPositions = 10;

        private static readonly int[] rotorSettings = new[] { 3, 5, 7 };
        
        public static int GetParameter(int position)
        {
            return rotorSettings[position % rotorSettings.Length];    
        }

        public static int LetterToCode(char c)
        {
            c = char.ToUpperInvariant(c);
            if (c == '@')
                return 26;
            if (c == ' ')
                return 27;
            if (c == '.')
                return 28;

            return ((int)c) - ((int)'A'); // A -> 0
        }

        public static char CodeToLetter(int i)
        {
            if (i == 26)
                return '@';
            if (i == 27)
                return ' ';
            if (i == 28)
                return '.';

            return (char)(i + ((int)'A')); // 0 -> A
        }
    }
}