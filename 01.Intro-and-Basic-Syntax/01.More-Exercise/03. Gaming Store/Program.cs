using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double currentBalance = balance;

            string nameOfGame = Console.ReadLine();
            double gamePrice = 0.0;

            while (nameOfGame != "Game Time")
            {
                switch (nameOfGame)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        nameOfGame = Console.ReadLine();
                        continue;
                }

                if (currentBalance >= gamePrice)
                {
                    Console.WriteLine($"Bought {nameOfGame}");
                    currentBalance -= gamePrice;
                }
                
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                nameOfGame = Console.ReadLine();
            }
            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${(balance - currentBalance):f2}. Remaining: ${currentBalance:f2}");
            }
                

        }
    }
}
