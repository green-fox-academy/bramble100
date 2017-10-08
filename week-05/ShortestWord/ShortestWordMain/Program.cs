using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShortestWord;

namespace ShortestWordMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "bitcoin take over the world maybe who knows perhaps";
            Console.WriteLine(ShortestWord.ShortestWord.FindShort(s                ));
            foreach (var s1 in s.Split(' '))
            {
                Console.WriteLine(s1);
            }
            Console.ReadKey();
        }
    }
}
