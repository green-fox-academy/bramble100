using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = (List<int>)Factory.Creator();
            var list2 = (IEnumerable<int>)Factory.Creator();
        }

        public static class Factory
        {
            public static object Creator()
            {
                return new List<int>();
            }
        }
    }
}