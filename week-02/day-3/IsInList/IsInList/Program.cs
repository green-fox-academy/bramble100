using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?

            List<int> searchTargets = new List<int>() { 4, 8, 12, 16 };

            Console.WriteLine(IsInList(list, searchTargets));
            Console.ReadKey();

        }

        private static bool IsInList(List<int> list, List<int> searchTargets)
        {
            foreach (int item in searchTargets)
            {
                if (!list.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
