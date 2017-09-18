using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>() {
                { "alma", "apple" },
                { "fa", "tree" },
                { "tengeralattjáró", "submarine" },
                { "tizenegy", "eleven" },
                { "eleven", "alive" }
            };
            //add more words to your dictionary
            AddWord("játék", "game", dic);
            RemoveWord("fa", dic);
            foreach (var word in dic.Keys)
            {
                Console.WriteLine($"{word}: {dic[word]}");
            }

            Console.WriteLine($"Hungarian word \"eleven\" in English is: {TranslateToEnglish("eleven", dic)}");
            Console.WriteLine($"English word \"alive\" in English is: {TranslateToHungarian("alive", dic)}");
            Console.ReadKey();
        }

        // Implement this method. It should add the given key-value pair to the the dictionary
        public static void AddWord(string hungarianWord, string englishWord, Dictionary<string, string> dictionary)
        {
            try
            {
                dictionary.Add(hungarianWord, englishWord);
                Console.WriteLine($"Word: \"{hungarianWord}\" is added to dictionary.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("This Hungarian word still exists in dictionary.");
            }
        }

        // Implement this method. It should remove the key-value pair by the given key from the dictionary
        public static void RemoveWord(string hungarianWord, Dictionary<string, string> dictionary)
        {
            dictionary.Remove(hungarianWord);
            Console.WriteLine($"Word: \"{hungarianWord}\" is removed from dictionary.");
        }

        // Implement a method which works as a translator from Hungarian to English
        // Example: you give it a parameter "alma" and it's output is "tree"
        public static string TranslateToEnglish(string hungarian, Dictionary<string, string> dictionary)
        {
            return (dictionary[hungarian]);
        }

        // Implement a method which works as a translator from English to Hungarian
        // Example: you give it a parameter "apple" and it's output is "alma"
        public static string TranslateToHungarian(string english, Dictionary<string, string> dictionary)
        {
            foreach (string word in dictionary.Keys)
            {
                if(dictionary[word] == english)
                {
                    return word;
                }
            }
            return "";
        }
    }
}
