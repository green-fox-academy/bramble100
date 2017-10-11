using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondiCipher
{
    /// <summary>
    /// https://www.codewars.com/kata/condi-cipher/train/csharp
    /// </summary>
    public class Kata
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decode("qvf cmnxmdkjfca.p,ab mf,byokf vjhwpcyb", "nqhbfgmi", 28));
            Console.WriteLine(Encode("on", "cryptogam", 10));
            Console.WriteLine(Decode("jx", "cryptogam", 10));
            Console.ReadKey();
        }

        public static string Encode(string m, string key, int initShift)
        {
            var keyAlphabet = new List<char>(key.Distinct());
            keyAlphabet.AddRange("abcdefghijklmnopqrstuvwxyz".Except(key.Distinct()));
            StringBuilder stringBuilder = new StringBuilder();
            initShift %= 26;
            m.ToList().ForEach(character => stringBuilder.Append(EncodeOneCharacter(character, keyAlphabet, ref initShift)));
            return stringBuilder.ToString();
        }

        private static char EncodeOneCharacter(char character, List<char> keyAlphabet, ref int initShift)
        {
            if (!Char.IsLetter(character))
            {
                return character;
            }
            int keyIndex = keyAlphabet.FindIndex(c => c == character);
            char appendableCharacter = keyAlphabet[(keyIndex + initShift) % 26];
            initShift = keyIndex + 1;
            return appendableCharacter;
        }

        public static string Decode(string m, string key, int initShift)
        {
            var keyAlphabet = new List<char>(key.Distinct());
            keyAlphabet.AddRange("abcdefghijklmnopqrstuvwxyz".Except(key.Distinct()));
            StringBuilder stringBuilder = new StringBuilder();
            initShift %= 26;
            m.ToList().ForEach(character => stringBuilder.Append(DecodeOneCharacter(character, keyAlphabet, ref initShift)));
            return stringBuilder.ToString();
        }

        private static char DecodeOneCharacter(char character, List<char> keyAlphabet, ref int initShift)
        {
            if (!Char.IsLetter(character))
            {
                return character;
            }
            int keyIndex = keyAlphabet.FindIndex(c => c == character);
            char appendableCharacter = keyAlphabet[(keyIndex - initShift + 26) % 26];
            initShift = (26 + keyIndex - initShift + 1) % 26;
            return appendableCharacter;
        }
    }
}