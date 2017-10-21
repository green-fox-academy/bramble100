using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class Violin : StringedInstrument
    {
        public Violin(int numberOfStrings = 4)
        {
            NumberOfStrings = numberOfStrings;
        }

        public override void Sound()
        {
            Console.WriteLine("Screech");
        }
    }
}
