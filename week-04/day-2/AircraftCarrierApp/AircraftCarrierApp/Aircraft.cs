using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierApp
{
    class Aircraft
    {
        private int ActualAmmunition = 0;
        private int MaxAmmunition = 0;
        private int BaseDamage = 0;
        private AircraftType type;

        public Aircraft(AircraftType type)
        {
            this.type = type;
            if (this.type == AircraftType.F16)
            {
                MaxAmmunition = 8;
                BaseDamage = 30;
            }
            else if (this.type == AircraftType.F35)
            {
                MaxAmmunition = 12;
                BaseDamage = 50;
            }
        }

        public string  Type()
        {
            if(type == AircraftType.F16)
            {
                return "F16";
            }
            else if (type == AircraftType.F16)
            {
                return "F35";
            }
            else
            {
                return "Invalid type set";
            }
        }

        public int Fight()
        {
            ActualAmmunition = 0;
            return ActualAmmunition * BaseDamage;
        }

        public int Refill(int ammoAvailable)
        {
            int ammoNeeded = MaxAmmunition - ActualAmmunition;
            int ammoLoadable = ammoAvailable >= ammoNeeded ? ammoNeeded : ammoAvailable;
            int ammoReturnable = 0;
            if (ammoLoadable >= ammoNeeded)
            {
                ActualAmmunition += ammoNeeded;
                ammoReturnable = ammoAvailable - ammoNeeded;
            }
            else
            {
                ActualAmmunition += ammoLoadable;
            }
            return ammoReturnable;
        }
    }
}