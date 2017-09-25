using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThingsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Fleet fleet = new Fleet() {
                new Thing("Get milk", false),
                new Thing("Remove the obstacles", false),
                new Thing("Stand up", true),
                new Thing("Eat lunch", true)
            };
            Console.WriteLine(fleet.ToString());

            Console.ReadKey();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
        }
    }
}
