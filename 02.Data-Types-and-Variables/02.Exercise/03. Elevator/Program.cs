using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int elevatorCoursesCount = (int)Math.Ceiling((double)peopleNumber / elevatorCapacity);

            /* another way
             
                if (peopleNumber % elevatorCapacity == 0)
                {
                    Console.WriteLine($"{peopleNumber / elevatorCapacity}");
                }
                else
                {
                    Console.WriteLine($"{peopleNumber / elevatorCapacity + 1}");
                }
            */
            Console.WriteLine($"{elevatorCoursesCount}");


        }
    }
}
