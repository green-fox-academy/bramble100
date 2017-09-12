using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            // Try to solve this using ElementAt() first, and optionally anything else after.

            reversed = MyReverse(reversed);

            Console.WriteLine(reversed);
            Console.ReadKey();
        }

        static string MyReverse(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length-1; i >= 0; i--)
            {
                sb.Append(s.ElementAt(i));
            }
            return sb.ToString();
        }
    }
}
