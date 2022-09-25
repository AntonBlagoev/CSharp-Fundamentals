using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPriceWhithoutTaxes = 0.0;
            double totalAmountOfTaxes = 0.0;
            double discount = 1.0; // 10% discount if is "special"

            while (true)
            {
                if (input == "special" || input == "regular")
                {
                    break;
                }

                if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPriceWhithoutTaxes += double.Parse(input);
                    double taxes = double.Parse(input) * 0.2;
                    totalAmountOfTaxes += taxes;
                }

                input = Console.ReadLine();
            }

            if (input == "special")
            {
                discount = 0.9;
            }

            double totalPrice = (totalPriceWhithoutTaxes + totalAmountOfTaxes) * discount;

            if (totalPriceWhithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (true)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWhithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {totalAmountOfTaxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");


            }

        }
    }
}
