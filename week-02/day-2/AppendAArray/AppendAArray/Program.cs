using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendAArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macs", "cic"]`
            // - Add all elements an `"a"` at the end

            string[] nimals = new string[] { "kuty", "macs", "cic" };

            for(int i = 0; i< nimals.Length; i++)
            {
                nimals[i] += 'a';
            }

            foreach(string s in nimals)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
