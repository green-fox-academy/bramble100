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
            Console.WriteLine("Enter a number, please:");
            int number = Int32.Parse(Console.ReadLine());
            for (int i = number % 2 == 0 ? 2 : 1; i < number + 1; i += 2)
            {
                Console.WriteLine(
                    String.Concat(Enumerable.Repeat(" ", (number - i) / 2)) +
                    String.Concat(Enumerable.Repeat("*", i))
                    );
            }
            for (int i = number - 2; i > 0; i -= 2)
            {
                Console.WriteLine(
                    String.Concat(Enumerable.Repeat(" ", (number - i) / 2)) +
                    String.Concat(Enumerable.Repeat("*", i))
                    );
            }
            Console.ReadKey();

        }
    }
}
