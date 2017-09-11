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


            Console.WriteLine("The first string is \"{0}\", the second string is \"{1}\", and they are {2}anagrams, and they are {3}palindroms.",
                string1,
                string2,
                TheyAreAnagrams(string1, string2) ? "" : "not ",
                TheyArePalindroms(string1, string2) ? "" : "not ");

            Console.ReadKey();
        }

        static bool TheyAreAnagrams(string string1, string string2)
        {
            if (string1.Length != string2.Length)
            {
                return false;
            }

            Hashtable lettersInString1 = new Hashtable();

            foreach (char character in string1)
            {
                lettersInString1[character] = lettersInString1.ContainsKey(character) ? Int32.Parse(lettersInString1[character].ToString()) + 1 : 1;
            }
            foreach (char character in string2)
            {
                Console.WriteLine("Nr of character \'{0}\': {1}", character, lettersInString1[character]);
                if (lettersInString1.ContainsKey(character))
                {
                    lettersInString1[character] = Int32.Parse(lettersInString1[character].ToString()) - 1;
                    if (Int32.Parse(lettersInString1[character].ToString()) == 0)
                    {
                        lettersInString1.Remove(character);
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool TheyArePalindroms(string string1, string string2)
        {
            if (string1.Length != string2.Length)
            {
                return false;
            }

            int length = string1.Length;
            for(int i = 0; i < length; i++)
            {
                if( string1[i] != string2[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
