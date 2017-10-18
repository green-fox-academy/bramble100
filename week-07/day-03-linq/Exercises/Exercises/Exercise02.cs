using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise02
    {
        public static void Run()
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbersLinq = from number in n
                                  where number % 2 == 1 || number % 2 == -1
                                  select Convert.ToDouble(number);

            Console.WriteLine($"Linq expression: {evenNumbersLinq.ToList().Average()}");
            Console.WriteLine($"Method expression: {n.Where(number => number % 2 == 1).Average()}");

            evenNumbersLinq.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"Method expression: {n.Where(number => number % 2 == 1).Average()}");
        }
    }
}
