using Anagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerForAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Analyzer anagram = new Analyzer();
            anagram.IsAnagram("hello", "loleh");
            Console.ReadKey();
        }
    }
}
