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
            if (!inputString1.Equals(inputString2))
            {
                List<char> processedString1 = inputString1.ToLower().ToList<char>();
                List<char> processedString2 = inputString2.ToLower().ToList<char>();
                processedString1.Sort();
                processedString2.Sort();
                return processedString1.ToString().Equals(processedString2.ToString());
            }
            return true;
        }
    }
}
