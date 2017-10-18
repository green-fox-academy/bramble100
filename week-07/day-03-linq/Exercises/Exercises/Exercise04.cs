using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise04
    {
        public static void Run()
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var squaredNumbersLinq = from number in n
                                     where number * number > 20
                                     select number;

            squaredNumbersLinq.ToList().ForEach(number => Console.WriteLine(number));
            n
                .ToList()
                .Where(number => number*number > 20)
                .ToList()
                .ForEach(number => Console.WriteLine(number));
        }
    }



}
