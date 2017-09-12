using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.

            for (int i = 0; i < far.Count; i++)
            {
                far[i] = far.ElementAt(i) + "a";
            }
            foreach (string s in far)
            {
                Console.WriteLine(s);
            }
            
            Console.ReadKey();
        }
    }
}
