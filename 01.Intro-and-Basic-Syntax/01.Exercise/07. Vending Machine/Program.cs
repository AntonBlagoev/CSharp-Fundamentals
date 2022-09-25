using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = 0.0;
            double moneyLeft = 0.0;

            while (input != "Start")
            {
                money = double.Parse(input);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    moneyLeft += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                input = Console.ReadLine();
            }

            string productName = Console.ReadLine();
            double productPrice = 0.0;
            while (productName != "End")
            {
                switch (productName)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        productName = Console.ReadLine();
                        continue;
                }

                if (moneyLeft >= productPrice)
                {
                    Console.WriteLine($"Purchased {productName.ToLower()}");
                    moneyLeft = moneyLeft - productPrice;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                productName = Console.ReadLine();
            }
            Console.WriteLine($"Change: {moneyLeft:f2}");

        }
    }
}
