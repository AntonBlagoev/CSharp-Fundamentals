using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdersCalc(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        static void OrdersCalc(string product, int quantityoFpoduct)
        {
            double price = 0.0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.0;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            double result = quantityoFpoduct * price;
            Console.WriteLine($"{result:f2}");
        }
    }
}

/* Create a program that calculates and prints the total price of an order. The method should receive two parameters:
 * •	A string, representing a product - "coffee",  "water", "coke", "snacks"
 * •	An integer, representing the quantity of the product
 * The prices for a single item of each product are:
 * •	coffee – 1.50
 * •	water – 1.00
 * •	coke – 1.40
 * •	snacks – 2.00
 * Print the result, rounded to the second decimal place.
 * 
 * Input
 * water
 * 5
 * Output
 * 5.00
 * 
 * Input
 * coffee
 * 2
 * Output
 * 3.00
 * 
 * 
 * 
 */