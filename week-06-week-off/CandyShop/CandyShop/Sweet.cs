namespace CandyShopLogic
{
    public abstract class Sweet
    {
        protected decimal sugarNeeded;
        protected decimal price;

        public decimal Price { get; set; }
        public decimal SugarNeeded { get; }
    }
}