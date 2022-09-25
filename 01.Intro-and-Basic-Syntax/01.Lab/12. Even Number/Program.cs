using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool evenNumber = false;
            
            for (int i = 0; evenNumber == false; i++)
            {
                
                if (number % 2 == 0)
                {
                    evenNumber = true;
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    number = int.Parse(Console.ReadLine());
                }
            }
            
            



        }
    }
}
