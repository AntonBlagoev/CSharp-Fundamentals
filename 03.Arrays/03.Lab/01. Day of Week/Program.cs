using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            string[] words = { "Monday","Tuesday", "Wednesday", "Thursday","Friday", "Saturday", "Sunday" };

            if (inputNumber >= 1 && inputNumber <=7)
            {
                Console.WriteLine($"{words[inputNumber-1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
