using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise03
    {
        public static void Run()
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squaredNumbersLinq = from number in n
                                  where number > 0
                                  select number * number;

            squaredNumbersLinq.ToList().ForEach(number => Console.WriteLine(number));
            n.ToList().Where(number => number > 0).Select(number => number * number).ToList().ForEach(number => Console.WriteLine(number));
        }
    }
}
