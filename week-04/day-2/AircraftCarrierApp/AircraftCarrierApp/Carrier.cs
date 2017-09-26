using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierApp
{
    class Carrier : List<Aircraft>
    {
        private int AmmoStorage = 0;
        private int HealthPoint = 0;

        public Carrier(int ammoStorage, int healthPoint, List<Aircraft> aircrafts)
        {
            aircrafts.ForEach(item => Add(item));
            AmmoStorage = ammoStorage;
            HealthPoint = healthPoint;
        }

        public void AddAircraft(string aircraftType)
        {
            if(aircraftType == "F16")
            {
                Add(new Aircraft(AircraftType.F16));
            }
            else if (aircraftType == "F35")
            {
                Add(new Aircraft(AircraftType.F35));
            }
        }

        public void Fill()
        {
            if(AmmoStorage == 0)
            {
                throw new Exception("Not ammo on carrier to fill the aircrafts.");
            }
            while(AmmoStorage != 0 && ThereIsAircraftToFill())
            {
                FillNextAirCraft("F35");
            }
            while (AmmoStorage != 0 && ThereIsAircraftToFill())
            {
                FillNextAirCraft("F16");
            }
        }

        private void FillNextAirCraft(string type)
        {
            foreach (Aircraft ac in this)
            {
                if (ac.Type() == type && ac.IsFillable())
                {
                    AmmoStorage = ac.Refill(AmmoStorage);
                }
            }
        }

        private bool ThereIsAircraftToFill()
        {
            foreach (Aircraft ac in this)
            {
                if (ac.IsFillable())
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"HP: {HealthPoint}, Aircraft count: {Count}, Ammo storage: {AmmoStorage}, Total damage: {TotalDamage()}");
            return base.ToString();
        }

        private object TotalDamage()
        {
            int totalDamage = 0;
            ForEach(aircraft => totalDamage += aircraft.TotalDamage());
            return totalDamage;
        }
    }
}