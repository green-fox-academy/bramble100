using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string string2 = Console.ReadLine();

            Hashtable lettersInString1 = new Hashtable();
            bool theyAreAnagrams = true;

            foreach (char character in string1)
            {
                lettersInString1[character] = lettersInString1.ContainsKey(character) ? lettersInString1[character] : 1;
            }

            foreach(char character in string2)
            {
                if(lettersInString1.ContainsKey(character))
                {
                    lettersInString1[character] = Int32.Parse(lettersInString1[character].ToString()) - 1;
                }
                else
                {
                    theyAreAnagrams = false;
                    break;
                }
            }

            Console.WriteLine("The first string is \"{0}\", the second string is \"{1}\", and they are {2}anagrams.",
                string1,
                string2,
                theyAreAnagrams? "":"not ");

            Console.ReadKey();
        }
    }
}
