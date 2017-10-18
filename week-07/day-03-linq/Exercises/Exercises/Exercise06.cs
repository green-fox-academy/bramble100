using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise06
    {
        public static void Run()
        {
            string stringToProcess = "Write a LINQ Expression to find the frequency of characters in a given string!";

            WithLinqExpression(stringToProcess);

            WithMethodExpression(stringToProcess);
        }

        private static void WithLinqExpression(string stringToProcess)
        {
            Console.WriteLine("Linq expression:");
            var query = from character in stringToProcess.ToLower().ToList().OrderBy(x => x)
                        group character by character
                        into uniqueCharacters
                        select uniqueCharacters;

            query.ToList().ForEach(x => Console.WriteLine($"{x.Key}: {x.Count()}"));
        }

        private static void WithMethodExpression(string stringToProcess)
        {
            Console.WriteLine("Method expression:");
            stringToProcess
                .ToLower()
                .Distinct()
                .ToList()
                .OrderBy(c => c)
                .ToList()
                .ForEach(character
                    => Console.WriteLine($"{character}: {stringToProcess.ToLower().Count(character2 => character == character2)}"));
        }
    }
}
