using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int> { 34, 12, 24, 9, 5 };
            foreach (var item in MySorter(mylist)) Console.WriteLine(item);
            foreach (var item in MySorter(mylist, true)) Console.WriteLine(item);

            Console.ReadKey();
        }

        public static List<int> MySorter(List<int> input, bool reverse= false)
        {
            input.Sort();
            if (reverse) input.Reverse();
            return input;
        }

    }
}
