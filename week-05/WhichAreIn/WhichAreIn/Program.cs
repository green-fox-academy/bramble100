using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichAreIn
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string[] SubStringSearcher(string[] array1, string[] array2)
        {
            var result = new HashSet<string>();
            foreach (string word1 in array1)
            {
                foreach(string word2 in array2)
                {
                    if (word2.Contains(word1))
                    {
                        result.Add(word1);
                        break;
                    }
                }
            }
            string[] resultArray = result.ToArray<string>();
            Array.Sort(resultArray);
            return resultArray;
        }
    }
}
