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
        internal AircraftType Type;

        public Aircraft(AircraftType type)
        {
            this.Type = type;
            if (this.Type == AircraftType.F16)
            {
                MaxAmmunition = 8;
                BaseDamage = 30;
            }
            else if (this.Type == AircraftType.F35)
            {
                MaxAmmunition = 12;
                BaseDamage = 50;
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

        internal bool IsFillable() => ActualAmmunition < MaxAmmunition;

        public override string ToString() => $"Aircraft type: {Type}, Ammo: {ActualAmmunition}, Base Damage: {BaseDamage}, All Damage: {ActualAmmunition * BaseDamage}";

        internal int TotalDamage()
        {
            return BaseDamage * ActualAmmunition;
        }
    }
}