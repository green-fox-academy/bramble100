using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        protected ElectricGuitar()
        {
            NumberOfStrings = 6;
        }

        public override void Sound()
        {
            Console.WriteLine("Twang"); ;
        }
    }
}
