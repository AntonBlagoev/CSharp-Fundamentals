using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double quantityOfFood = double.Parse(Console.ReadLine()) * 1000;
            double quantityOfHay = double.Parse(Console.ReadLine()) * 1000;
            double quantityCover = double.Parse(Console.ReadLine()) * 1000;
            double guineaPigWeight  = double.Parse(Console.ReadLine()) * 1000;

            for (int day = 1; day <= 30; day++)
            {
                quantityOfFood -= 300.0;

                if (day % 2 == 0)
                {
                    quantityOfHay -= quantityOfFood * 0.05;
                }

                if (day % 3 == 0)
                {
                    quantityCover -= guineaPigWeight / 3;
                }
            }
            if (quantityOfFood > 0 && quantityOfHay >  0 && quantityCover > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityOfFood / 1000:f2}, Hay: {quantityOfHay / 1000:f2}, Cover: {quantityCover / 1000:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }

        }
    }
}
