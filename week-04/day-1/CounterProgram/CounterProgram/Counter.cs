using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProgram
{
    class Counter
    {
        private int Value = 0;

        public Counter(int value = 0)
        {
            Value = value;
        }

        public void Add(int number = 1) => Value += number;

        public string Get => Convert.ToString(Value);

        public void Reset() => Value = 0;

    }
}
