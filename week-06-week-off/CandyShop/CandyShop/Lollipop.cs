namespace CandyShopLogic
{
    public class Lollipop : Sweet
    {
        public new decimal SugarNeeded
        {
            get
            {
                return sugarNeeded;
            }
        }

        public Lollipop()
        {
            sugarNeeded = 10m;
        }
    }
}