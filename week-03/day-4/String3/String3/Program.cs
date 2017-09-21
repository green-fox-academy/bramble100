using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".
            string input = "Green Fox";
            Console.WriteLine(Asteriskize(input));
            Console.ReadKey();
        }

        private static string Asteriskize(string input) => 
            input.Length < 2 ? input : $"{input[0]}*{Asteriskize(input.Substring(1))}";
    }
}
