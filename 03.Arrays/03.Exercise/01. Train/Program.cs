using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberOfWagons];

            int sumOfPeople = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sumOfPeople += wagons[i];
            }

            Console.WriteLine(string.Join(' ', wagons));

            /*
            foreach (var wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }
            Console.WriteLine();
            */

            Console.WriteLine(sumOfPeople);



        }
    }
}
