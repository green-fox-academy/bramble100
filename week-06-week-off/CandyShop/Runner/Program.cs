using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyShopLogic;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
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
            CandyShop candyShop = new CandyShop(300);
            candyShop.CreateSweets(CandyShop.CANDY);
            candyShop.CreateSweets(CandyShop.CANDY);
            candyShop.CreateSweets(CandyShop.LOLLIPOP);
            candyShop.CreateSweets(CandyShop.LOLLIPOP);
            candyShop.PrintInfo();
            // Should print out:
            // Invetory: 2 candies, 2 lollipops, Income: 0$, Sugar: 270gr
            candyShop.Sell(CandyShop.CANDY, 1);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 2 lollipops, Income: 20$, Sugar: 285gr"
            candyShop.Raise(5);
            candyShop.Sell(CandyShop.LOLLIPOP, 1);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 1 lollipops, Income: 35$, Sugar: 285gr"
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 1 lollipops, Income: 5$, Sugar: 315gr"
        }
    }
}
