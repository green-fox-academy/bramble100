namespace CandyShopLogic
{
    public class Candy : Sweet
    {
        public new decimal SugarNeeded
        {
            get
            {
                return sugarNeeded;
            }
        }

        public Candy()
        {
            sugarNeeded = 5;
        }
    }
}