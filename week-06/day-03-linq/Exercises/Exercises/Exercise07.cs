using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise07
    {
        // Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
        public static void Run()
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            WithLinqExpression(cities);

            WithMethodExpression(cities);
        }

        private static void WithLinqExpression(string[] cities)
        {
            Console.WriteLine("Linq expression:");
            var query = from city in cities
                        where city.StartsWith("A") && city.EndsWith("I")
                        select city;

            query
                .ToList()
                .ForEach(x => Console.WriteLine(x));

        }

        private static void WithMethodExpression(string[] cities)
        {
            Console.WriteLine("Method expression:");

            cities
                .Where(x => x.StartsWith("A") && x.EndsWith("I"))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
