using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShopLogic
{
    public class CandyShop
    {
        private decimal moneyInDrawer = 0;
        private decimal sugarInventory = 0;  
        private Dictionary<Type, decimal> sweetInventory = new Dictionary<Type, decimal>();

        // We run a Candy shop where we sell candies and lollipops
        // One lollipop's price is 10$
        // And it made from 5gr of sugar
        // One candie's price is 20$
        // And it made from 10gr of sugar
        // we can raise their prices with a given percentage

        // Create a CandyShop class
        // It can store sugar and money as income. The constructor should take the amount of sugar in gramms.
        // we can create lollipops and candies store them in the CandyShop's storage
        // If we create a candie or lollipop the CandyShop's sugar amount gets reduced by the amount needed to create the sweets
        // We can raise the prices of all candies and lollipops with a given percentage
        // We can sell candie or lollipop with a given number as amount
        // If we sell sweets the income will be increased by the price of the sweets and we delete it from the inventory
        // We can buy sugar with a given number as amount. The price of 1000gr sugar is 100$
        // If we buy sugar we can raise the CandyShop's amount of sugar and reduce the income by the price of it.
        // The CandyShop should print properties represented as string in this format:
        // "Inventory: 3 candies, 2 lollipops, Income: 100, Sugar: 400gr"

        public static readonly Candy CANDY;
        public static readonly Lollipop LOLLIPOP;


        public CandyShop(decimal sugarGiven)
        {
            sugarInventory = sugarGiven;
            sweetInventory.Add(typeof(Candy), 0);
            sweetInventory.Add(typeof(Lollipop), 0);
        }

        public void CreateSweets(Sweet sweet)
        {
            if (sweet.sugarNeeded < sugarInventory)
            {
                sweetInventory[sweet.GetType()] += 1;
                sugarInventory -= sweet.sugarNeeded;
            }
            else
            {
                Console.WriteLine($"Not enough sugar to create the {sweet.GetType().Name}.");
            };
        }

        public void PrintInfo()
        {
            ToString();
        }

        public void Sell(object cANDY, int v)
        {
            throw new NotImplementedException();
        }

        public void Raise(int v)
        {
            throw new NotImplementedException();
        }

        public void BuySugar(int v)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"CandyShop: Money: ${moneyInDrawer}" +
                $" Sugar: {sugarInventory} gr" +
                $" Candy: {sweetInventory[typeof(Candy)]} pcs" +
                $" Lollipop: {sweetInventory[typeof(Lollipop)]} pcs";
    }
}