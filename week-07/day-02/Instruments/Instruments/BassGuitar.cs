using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class BassGuitar : StringedInstrument
    {
        protected BassGuitar()
        {
            NumberOfStrings = 4;
        }

        public override void Sound()
        {
            Console.WriteLine("Duum-duum-duum");
        }
    }
}
