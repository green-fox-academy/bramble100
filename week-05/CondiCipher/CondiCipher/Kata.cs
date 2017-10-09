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
            Console.WriteLine(Encode("cryptogam", "cryptogram", 0));
            Console.ReadKey();
        }

        public static string Encode(string key, string m, int initShift)
        {
            var keyAlphabet = new List<char>(key.Distinct());
            keyAlphabet.AddRange("abcdefghijklmnopqrstuvwxyz".Except(key.Distinct()));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var character in m)
            {
                if (Char.IsLetter(character))                    
                {
                    int keyIndex = keyAlphabet.FindIndex(c => c == character);
                    char appendableCharacter = Convert.ToChar(keyAlphabet[(keyIndex + initShift) % 26]);
                    stringBuilder.Append(appendableCharacter);
                    initShift = keyIndex+1;
                }
                else
                {
                    stringBuilder.Append(character);
                }
            }
            return stringBuilder.ToString();
        }

        public static string Decode(string key, string m, int initShift)
        {
            return m;
        }
    }
}
