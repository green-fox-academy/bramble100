namespace AircraftCarrierApp
{
    public abstract class Aircraft
    {
        protected int ActualAmmunition = 0;
        protected int MaxAmmunition = 0;
        protected int BaseDamage = 0;

        public Aircraft()
        {
        }

        public int Fight()
        {
            ActualAmmunition = 0;
            return ActualAmmunition * BaseDamage;
        }

        public int Reload(int ammoAvailable)
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

        internal bool IsReloadable() => ActualAmmunition < MaxAmmunition;

        public override string ToString() => $"Ammo: {ActualAmmunition}, " +
            $"Base Damage: {BaseDamage}, " +
            $"All Damage: {ActualAmmunition * BaseDamage}";

        internal int TotalDamage() => BaseDamage * ActualAmmunition;
    }
}