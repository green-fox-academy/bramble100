using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings = 6)
        {
            NumberOfStrings = numberOfStrings;
        }

        public override void Sound()
        {
            Console.WriteLine("Twang"); ;
        }
    }
}
