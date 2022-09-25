using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractOfThirdInteger(a, b, c));
        }

        static int SumFirstTwoIntegers(int a, int b) => a + b;

        static int SubtractOfThirdInteger(int a, int b, int c) => SumFirstTwoIntegers(a, b) - c;
    }
}


/* You will receive 3 integers. 
 * Create a method that returns the sum of the first two integers and another method that subtracts the third integer 
 * from the result of the sum method.
 * 
 * Input
 * 23
 * 6
 * 10
 * Output
 * 19
 * 
 * Input
 * 1
 * 17
 * 30
 * Output
 * -12
 * 
 * Input
 * 42 
 * 58
 * 100
 * Output
 * 0
 * 
 */