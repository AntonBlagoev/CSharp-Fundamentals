using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            float output = (input / 1000f);

            Console.WriteLine($"{output:f2}");


        }
    }
}
