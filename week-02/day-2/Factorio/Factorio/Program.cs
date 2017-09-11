using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.WriteLine("Enter an integer:");

            Console.WriteLine("Factorio is: " + factorio(Int32.Parse(Console.ReadLine())));

            Console.ReadKey();
        }

        static long factorio(int number) => (number == 1 ? 1 : number * factorio(number - 1));
    }
}
