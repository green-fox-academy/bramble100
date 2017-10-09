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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encode("crypto", "hello", 10));
            Console.ReadKey();
        }

        public static string Encode(string key, string inputMessage, int initShift)
        {
            string outputMessage = String.Empty;
            var keyAlphabet = new List<char>(key.Distinct());
            keyAlphabet.AddRange("abcdefghijklmnopqrstuvwxyz".Except(key.Distinct()));
            foreach (var character in inputMessage)
            {
                outputMessage += Convert.ToChar('a'+ keyAlphabet.FindIndex(c => c == character));
            }
            return outputMessage;
        }

        public static string Decode(string key, string m, int initShift)
        {
            return m;
        }
    }
}
