using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise08
    {
        // Write a LINQ Expression to find the uppercase characters in a string!
        public static void Run()
        {
            string stringToProcess = "Write a LINQ Expression to find the uppercase characters in a string!";
            WithLinqExpression(stringToProcess);

            WithMethodExpression(stringToProcess);
        }

        private static void WithLinqExpression(string stringToProcess)
        {
            Console.WriteLine("Linq expression:");
            var query = from character in stringToProcess
                        where Char.IsUpper(character)
                        select character;

            query.ToList().ForEach(x => Console.WriteLine(x));
        }

        private static void WithMethodExpression(string stringToProcess)
        {
            Console.WriteLine("Method expression:");
            stringToProcess
                .Where(x => Char.IsUpper(x))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
