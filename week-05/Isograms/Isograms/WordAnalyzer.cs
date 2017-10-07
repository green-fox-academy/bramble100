using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograms
{
    public static class WordAnalyzer
    {
        /// <summary>
        /// Returns true if the given word is isogram.
        /// </summary>
        /// <remarks>https://www.codewars.com/kata/54ba84be607a92aa900000f1/</remarks>  
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsIsogram(string str) => (new HashSet<char>(str.ToLower().ToCharArray())).Count == str.ToCharArray().Length;
    }
}
