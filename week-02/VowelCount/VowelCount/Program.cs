using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vowel Count");
            Console.WriteLine("Enter a string:");
            string string1 = Console.ReadLine();

            Dictionary<char, int> foundVowels = new Dictionary<char, int>();
            HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c in string1)
            {
                if (!vowels.Contains(c))
                {
                    continue;
                }
                if (!foundVowels.ContainsKey(c))
                {
                    foundVowels.Add(c,0);
                }
                foundVowels[c] = foundVowels[c] + 1;
            }

            foreach(char c in foundVowels.Keys)
            {
                Console.WriteLine("Number of '{0}' found in string: {1}", c, foundVowels[c]);
            }

            Console.ReadKey();
        }
    }
}
