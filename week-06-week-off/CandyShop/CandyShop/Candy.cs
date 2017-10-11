namespace CandyShopLogic
{
    public class Candy : Sweet
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

        public Candy()
        {
            sugarNeeded = 5;
            price = 10;
        }
    }
}