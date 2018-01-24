using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDI
{
    public class Fibonacci
    {
        // Write a method that displays the first 100 Fibonacci numbers
        // separated with commas.

        public static IEnumerable<long> Numbers(int numberOfNumbers = 100)
        {
            var results = new List<long>() { 0, 1 };
            for (int i = 2; i < numberOfNumbers + 1; i++)
            {
                results.Add(results[i - 1] + results[i - 2]);
            }
            return results;
        }
    }
}
