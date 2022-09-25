using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            for (int i = 0; i < n; i++)
            {
                float pricePerCapsule = float.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double price = ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
