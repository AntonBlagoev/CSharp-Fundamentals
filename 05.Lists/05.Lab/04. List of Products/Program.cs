using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            int count = 1;
            foreach (var item in products)
            {
                Console.WriteLine($"{count}.{products}");
                count++;
            }

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"{i + 1}.{products[i]}");
            //}
        }
    }
}

/* Read a number n and n lines of products. Print a numbered list of all the products ordered by name
 * 
 * Input
 * 4
 * Potatoes
 * Tomatoes
 * Onions
 * Apples
 * 
 * Output
 * 1.Apples
 * 2.Onions
 * 3.Potatoes
 * 4.Tomatoes
 * 
 * Input
 * 5
 * Carrots
 * Artichokes
 * Beans
 * Eggplants
 * Peppers
 * 
 * Output
 * 1.Artichokes
 * 2.Beans
 * 3.Carrots
 * 4.Eggplants
 * 5.Peppers
 * 
 * 
 * 
 * 
 */