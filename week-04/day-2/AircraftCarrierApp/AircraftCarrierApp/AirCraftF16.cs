namespace AircraftCarrierApp
{
    public class AirCraftF16 : Aircraft
    {
        public AirCraftF16()
        {
            MaxAmmunition = 8;
            BaseDamage = 30;
        }

        public override string ToString() => $"Aircraft type: F16, {base.ToString()}";
    }
}