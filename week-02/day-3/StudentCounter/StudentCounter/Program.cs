using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new List<Dictionary<string, object>>() {
            new Dictionary<string, object>
            {
                { "name", "Rezso" },
                { "age", 9.5 },
                { "candies", 2 }
            },
            new Dictionary<string, object>
            {
                { "name", "Gerzson" },
                { "age", 10 },
                { "candies", 1 }
            },
            new Dictionary<string, object>
            {
                { "name", "Aurel" },
                { "age", 7 },
                { "candies", 3 }
            },
            new Dictionary<string, object>
            {
                { "name", "Zsombor" },
                { "age", 12 },
                { "candies", 5 }
            },
            new Dictionary<string, object>
            {
                { "name", "Olaf" },
                { "age", 12 },
                { "candies", 7 }
            },
            new Dictionary<string, object>
            {
                { "name", "Teodor" },
                { "age", 3 },
                { "candies", 2 }
            }};

            // Display the following things:
            //  - Who has got more candies than 4 candies
            //  - Sum the age of people who have lass than 5 candies

            foreach (Dictionary<string, object> person in map)
            {
                if(Int32.Parse(person["candies"].ToString()) > 4)
                {
                    Console.WriteLine("{0} has more than 4 candies ({1}).", person["name"].ToString(), person["candies"].ToString());
                }
            }
            double sumOfAge = 0;
            foreach (Dictionary<string, object> person in map)
            {
                if (Int32.Parse(person["candies"].ToString()) < 5)
                {
                    sumOfAge += Double.Parse(person["age"].ToString());
                }
            }

            Console.WriteLine("The sum of the age of people who have lass than 5 candies is {0}.", sumOfAge);
        
            Console.ReadKey();
        }
    }
}
