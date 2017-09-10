using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<500; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
