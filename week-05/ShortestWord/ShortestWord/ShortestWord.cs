using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestWord
{
    public static class ShortestWord
    {
        public static int FindShort(string s) => s.Split(' ').Min(t => t.Length);
    }
}
