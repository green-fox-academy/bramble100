using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the wariables
            int a = 123;
            int b = 526;
            Console.WriteLine("a: " + a + " b: " + b);
            int swap = b;
            b = a;
            a = swap;
            Console.WriteLine("Swapping ... done.");
            Console.WriteLine("a: " + a + " b: " + b);

            Console.ReadKey();

        }
    }
}
