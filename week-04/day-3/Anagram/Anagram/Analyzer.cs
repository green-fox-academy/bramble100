using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class Analyzer
    {
        public bool IsAnagram(string inputString1, string inputString2)
        {
            if (inputString1.Equals(inputString2))
            {
                return true;
            }

            List<char> processedListOfChars1 = inputString1.Replace(" ", String.Empty).ToLower().ToList<char>();
            List<char> processedListOfChars2 = inputString2.Replace(" ", String.Empty).ToLower().ToList<char>();

            if (processedListOfChars1.Count != processedListOfChars2.Count)
            {
                return false;
            }
            processedListOfChars1.Sort();
            processedListOfChars2.Sort();
            return String.Concat(processedListOfChars1).Equals(String.Concat(processedListOfChars2));
        }
    }
}
