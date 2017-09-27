using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    public class Engine
    {
        public static Dictionary<char, int> Counter(string inputString)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char character in inputString.ToArray<char>())
            {
                if (result.ContainsKey(character))
                {
                    result[character]++;
                }
                else
                {
                    result.Add(character, 1);
                }
            }
            return result;
        }
    }
}
