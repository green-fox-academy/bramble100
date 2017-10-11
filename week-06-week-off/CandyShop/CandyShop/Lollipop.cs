namespace CandyShopLogic
{
    public class Lollipop : Sweet
    {
        public new decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    System.Console.WriteLine("Please no negative price.");
                }
            }
        }

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
            price = 20m;
        }
    }
}