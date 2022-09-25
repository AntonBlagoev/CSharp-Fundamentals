using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "buy")
                {
                    break;
                }

                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                List<double> listOfValues = new List<double> { price, quantity };

                if (!orders.ContainsKey(name))
                {
                    orders.Add(name, listOfValues);
                }
                else
                {
                    foreach (var item in orders)
                    {
                        if (item.Key == name)
                        {
                            listOfValues[1] = item.Value[1] + quantity;
                        }
                    }
                    orders[name] = listOfValues;
                }
            }

            foreach (var item in orders)
            {

                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key:f2} -> {totalPrice:f2}");
            }

        }
    }

}
/* 3.	Orders
 * 
 * Create a program that keeps the information about products and their prices.
 * Each product has a name, a price and a quantity.
 * If the product doesn't exist yet, add it with its starting quantity.
 * If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different,
 * replace the price as well.
 * You will receive products' names, prices and quantities on new lines.
 * Until you receive the command "buy", keep adding items.
 * When you do receive the command "buy", print the items with their names and the total price of all the products with that name.
 * 
 * Input
 * •	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
 * •	The product data is always delimited by a single space.
 * 
 * Output
 * •	Print information about each product in the following format: 
 * "{productName} -> {totalPrice}"
 * 
 * •	Format the average grade to the 2nd digit after the decimal separator
 * 
 * Examples
 * ---------------------
 * Input
 * Beer 2.20 100
 * IceTea 1.50 50
 * NukaCola 3.30 80
 * Water 1.00 500
 * buy
 * 
 * Output
 * Beer -> 220.00
 * IceTea -> 75.00
 * NukaCola -> 264.00
 * Water -> 500.00
 * ----------------------
 * Input
 * Beer 2.40 350
 * Water 1.25 200
 * IceTea 5.20 100
 * Beer 1.20 200
 * IceTea 0.50 120
 * buy
 * 
 * Output
 * Beer -> 660.00
 * Water -> 250.00
 * IceTea -> 110.00
 * ----------------------
 * Input
 * CesarSalad 10.20 25
 * SuperEnergy 0.80 400
 * Beer 1.35 350
 * IceCream 1.50 25
 * buy
 * 
 * Output
 * CesarSalad -> 255.00
 * SuperEnergy -> 320.00
 * Beer -> 472.50
 * IceCream -> 37.50
 * 
 * 
 */