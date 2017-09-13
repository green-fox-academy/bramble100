using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int> { 1, 11, 34, 52, 61 };
            foreach (var item in SubintFinder(mylist, 1))
            {
                Console.WriteLine(item);
            }
                
            Console.ReadKey();
        }

        private static List<int> SubintFinder(List<int> mylist, int v)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < mylist.Count; i++)
            {
                if (mylist[i].ToString().Contains(v.ToString()))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
