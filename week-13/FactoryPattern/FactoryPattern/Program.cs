using System.Collections.Generic;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = (IEnumerable<int>)Factory.Creator();
            var list2 = (List<int>)Factory.Creator();
            IEnumerable<int> list4 = (List<int>)Factory.Creator();
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