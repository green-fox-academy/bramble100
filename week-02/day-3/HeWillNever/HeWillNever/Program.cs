using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeWillNever
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notSoCrypticMessage = { 1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11 };

            var map = new Dictionary<int, string>
            {
                { 7, "run around and desert you" },
                { 50, "tell a lie and hurt you" },
                { 49, "make you cry," },
                { 2, "let you down" },
                { 12, "give you up," },
                { 1, "Never gonna" },
                { 11, "\n" },
                { 3, "say goodbye" }
            };

            // Things are a little bit messed up
            // Your job is to decode the notSoCrypticMessage by using the hashmap as a look up table
            // Assemble the fragments into the out variable

            StringBuilder sb = new StringBuilder();

            foreach (int item in notSoCrypticMessage)
            {
                sb.Append(map[item]);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
