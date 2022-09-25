using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int ageOfPerson = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            switch (typeOfDay)
            {
                case "Weekday":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18 || ageOfPerson > 64 && ageOfPerson <= 122)
                    {
                        ticketPrice = 12;
                    }
                    else if (ageOfPerson > 18 && ageOfPerson <= 64)
                    {
                        ticketPrice = 18;
                    }

                    break;

                case "Weekend":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18 || ageOfPerson > 64 && ageOfPerson <= 122)
                    {
                        ticketPrice = 15;
                    }
                    else if (ageOfPerson > 18 && ageOfPerson <= 64)
                    {
                        ticketPrice = 20;
                    }
                    break;

                case "Holiday":
                    if (ageOfPerson >= 0 && ageOfPerson <= 18)
                    {
                        ticketPrice = 5;
                    }
                    else if (ageOfPerson > 18 && ageOfPerson <= 64)
                    {
                        ticketPrice = 12;
                    }
                    else if (ageOfPerson > 64 && ageOfPerson <= 122)
                    {
                        ticketPrice = 10;
                    }
                    break;
                
            }

            if (ticketPrice == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{ticketPrice}$");
            }



        }
    }
}
