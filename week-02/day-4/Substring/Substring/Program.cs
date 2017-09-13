using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "this is what I'm searching in";
            string string2 = "searching";

            Console.WriteLine(MyStringFinder(string1, string2));
            Console.ReadKey();
        }

        private static int MyStringFinder(string string1, string string2)
        {
            for (int i = 0; i < string1.Length-string2.Length; i++)
            {
                if (string1.Substring(i).StartsWith(string2))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
