using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> string1 = new List<string>() { "this", "is", "what", "I'm", "searching", "in" };
            string string2 = "searching";

            Console.WriteLine(MyStringFinder(string1, string2));
            Console.ReadKey();
        }

        private static int MyStringFinder(List<string> mylist, string string2)
        {
            for (int i = 0; i < mylist.Count; i++)
            {
                if (mylist[i].Contains(string2)) return i;
            }
            return -1;
        }
    }
}