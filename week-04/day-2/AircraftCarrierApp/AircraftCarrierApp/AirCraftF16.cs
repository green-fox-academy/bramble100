using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierApp
{
    class AirCraftF16 : Aircraft
    {
        public AirCraftF16()
        {
            MaxAmmunition = 8;
            BaseDamage = 30;
        }

        public override string ToString() => $"Aircraft type: F16, {base.ToString()}";
    }
}