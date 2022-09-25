using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseInput = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(baseInput, power));
        }

        static double MathPower(double baseInput, int power)
        {
            double result = 1.0;
            for (int i = 0; i < power; i++)
            {
                result *= baseInput;
            }

            return result;
        }
    }
}

/* Create a method, which receives two numbers as parameters:
 * •	The first number – the base
 * •	The second number – the power
 * The method should return the base raised to the given power.
 * 
 * Input
 * 2
 * 8
 * Output
 * 256
 * 
 * Input
 * 3
 * 4
 * Output
 * 81
 * 
 * 
 */