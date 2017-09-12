using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.

            // "What I cannot create, I do not understand."

            // find "cannot" and "do"
            int cannotPosition = list.IndexOf("cannot");
            int doPosition = list.IndexOf("do");
            string temp = list.ElementAt(cannotPosition);
            list[cannotPosition] = list.ElementAt(doPosition);
            list[doPosition] = temp;

            Console.WriteLine(String.Join(" ", list));
            Console.ReadKey();
        }
    }
}
