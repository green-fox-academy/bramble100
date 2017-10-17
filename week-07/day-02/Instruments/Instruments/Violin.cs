using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public class Violin : StringedInstrument
    {
        protected Violin()
        {
            NumberOfStrings = 4;
        }

        public override void Sound()
        {
            Console.WriteLine("Screech");
        }
    }
}
