using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrierApp
{
    public class Carrier : List<Aircraft>
    {
        private int AmmoStorage = 0;
        private int HealthPoint = 0;

        public Carrier(int ammoStorage, int healthPoint)
        {
            AmmoStorage = ammoStorage;
            HealthPoint = healthPoint;
        }

        public Carrier(int ammoStorage, int healthPoint, List<Aircraft> aircrafts)
        {
            aircrafts.ForEach(item => Add(item));
            AmmoStorage = ammoStorage;
            HealthPoint = healthPoint;
        }

        public void AddAircraft(string aircraftType)
        {
            if (aircraftType == "F16")
            {
                Add(new AirCraftF16());
            }
            else if (aircraftType == "F35")
            {
                Add(new AirCraftF35());
            }
            else
            {
                throw new ArgumentException("Invalid aircraft type specified");
            }
        }

        public void AddAircraft(AircraftType type)
        {
            if (type == AircraftType.F16)
            {
                Add(new AirCraftF16());
            }
            else if (type == AircraftType.F35)
            {
                Add(new AirCraftF35());
            }
            else
            {
                throw new ArgumentException("Invalid aircraft type specified");
            }
        }

        public void Reload()
        {
            if (AmmoStorage == 0)
            {
                throw new Exception("No ammo on carrier to reload the aircrafts.");
            }
            while (AmmoStorage != 0 && ThereIsAircraftToReload(typeof(AirCraftF35)))
            {
                ReloadNextAirCraft(typeof(AirCraftF35));
            }
            while (AmmoStorage != 0 && ThereIsAircraftToReload(typeof(AirCraftF16)))
            {
                ReloadNextAirCraft(typeof(AirCraftF16));
            }
        }

        private void ReloadNextAirCraft(Type type) => FindAll(aircraft => aircraft.GetType() == type && aircraft.IsReloadable()).
                ForEach(aircraft => AmmoStorage = aircraft.Reload(AmmoStorage));

        private void ReloadNextAirCraftOld(Type type)
        {
            foreach (Aircraft aircraft in this)
            {
                if (aircraft.GetType() == type && aircraft.IsReloadable())
                {
                    AmmoStorage = aircraft.Reload(AmmoStorage);
                }
            }
        }

        public bool ThereIsAircraftToReload(Type type) => Find(aircraft 
            => aircraft.GetType() == type && aircraft.IsReloadable()) != null;

        private bool ThereIsAircraftToReloadOld(Type type)
        {
            foreach (Aircraft aircraft in this)
            {
                if (aircraft.GetType() == type && aircraft.IsReloadable())
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Aircraft carrier => HP: {HealthPoint}, " +
                $"Aircraft count: {Count}, Ammo storage: {AmmoStorage}, " +
                $"Total damage: {TotalDamage()}");
            ForEach(aircraft => stringBuilder.AppendLine(aircraft.ToString()));
            return stringBuilder.ToString();
        }

        private int TotalDamage()
        {
            int totalDamage = 0;
            ForEach(aircraft => totalDamage += aircraft.TotalDamage());
            return totalDamage;
        }

        public void Fight(Carrier enemy)
        {
            if (enemy.TotalDamage() < HealthPoint)
            {
                HealthPoint -= enemy.TotalDamage();
            }
            else
            {
                HealthPoint = 0;
                Clear();
            }
        }
    }
}