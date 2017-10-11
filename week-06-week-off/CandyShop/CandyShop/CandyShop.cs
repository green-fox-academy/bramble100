using System;
using System.Collections.Generic;

namespace CandyShopLogic
{
    public class CandyShop
    {
        private decimal moneyInDrawer = 0m;
        private decimal sugarInventory = 0m;
        private decimal sugarPrice = 100m;
        private Dictionary<Type, decimal> pricesOfSweets = new Dictionary<Type, decimal>();
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

        public static readonly Candy CANDY = new Candy();
        public static readonly Lollipop LOLLIPOP = new Lollipop();


        public CandyShop(decimal sugarGiven)
        {
            sugarInventory = sugarGiven;
            sweetInventory.Add(typeof(Candy), 0);
            sweetInventory.Add(typeof(Lollipop), 0);
            pricesOfSweets.Add(typeof(Candy), 20m);
            pricesOfSweets.Add(typeof(Lollipop), 10m);
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
            Console.WriteLine(ToString());
        }

        public void Sell(Sweet sweet, decimal qty)
        {
            if (sweetInventory[sweet.GetType()] > qty)
            {
                sweetInventory[sweet.GetType()] -= qty;
                moneyInDrawer += pricesOfSweets[sweet.GetType()] * qty;
            };
        }

        public void Raise(decimal raise)
        {
            pricesOfSweets[typeof(Candy)] *= (1 + raise / 100);
            pricesOfSweets[typeof(Lollipop)] *= (1 + raise / 100);
        }

        /// <summary>
        /// Buys the given amount of sugar (amount in gr).
        /// </summary>
        /// <param name="sugar">The amount of sugar in gr</param>
        public void BuySugar(decimal sugar)
        {
            if (sugar / 1000 * sugarPrice < moneyInDrawer)
            {
                sugarInventory += sugar;
                moneyInDrawer -= sugar / 1000 * sugarPrice;
            }
            else
            {
                Console.WriteLine($"Not enough money to buy {sugar} gr of sugar.");
            }
        }

        public override string ToString() => $"CandyShop: Money: ${moneyInDrawer}" +
                $" Sugar: {sugarInventory} gr" +
                $" Candy: {sweetInventory[typeof(Candy)]} pcs" +
                $" Lollipop: {sweetInventory[typeof(Lollipop)]} pcs";
    }
}