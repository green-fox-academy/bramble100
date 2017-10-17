using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public abstract class StringedInstrument : Instrument
    {
        private int numberOfStrings;

        public StringedInstrument()
        {
        }

        public StringedInstrument(int numberOfStrings)
        {
            NumberOfStrings = numberOfStrings;
        }

        public int NumberOfStrings { get => numberOfStrings; set => numberOfStrings = value; }

        public abstract void Sound();

        public override void Play()
        {
            Sound();
        }
    }
}
