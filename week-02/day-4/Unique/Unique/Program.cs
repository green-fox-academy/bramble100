using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 11, 34, 11, 52, 61, 1, 34 };
            foreach (int item in new HashSet<int>(list))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
