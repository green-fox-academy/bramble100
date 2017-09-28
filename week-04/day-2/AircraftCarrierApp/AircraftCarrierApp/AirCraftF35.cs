namespace AircraftCarrierApp
{
    public class AirCraftF35 : Aircraft
    {
        public AirCraftF35()
        {
            MaxAmmunition = 12;
            BaseDamage = 50;
        }

        public override string ToString() => $"Aircraft type: F35, {base.ToString()}";
    }
}