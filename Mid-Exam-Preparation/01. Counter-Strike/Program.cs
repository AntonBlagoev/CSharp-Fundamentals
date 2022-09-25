using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int countOfWonBatles = 0;


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End of battle")
                {
                    break;
                }

                int distance = int.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countOfWonBatles} won battles and {energy} energy");
                    energy -= distance;
                    break;
                }

                energy -= distance;
                countOfWonBatles++;

                if (countOfWonBatles % 3 == 0)
                {
                    energy += countOfWonBatles;
                }


            }

            if (energy >= 0)
            {
                Console.WriteLine($"Won battles: {countOfWonBatles}. Energy left: {energy}");
            }
            

        }
    }
}
