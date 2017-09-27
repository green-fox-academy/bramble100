using Anagram;
using System;

namespace RunnerForAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Analyzer anagram = new Analyzer();
            anagram.IsAnagram("hell  o", "loleh");
            Console.ReadKey();
        }
    }
}
