using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double resultA = FactorialDivision(a);
            double resultB = FactorialDivision(b);
            Console.WriteLine($"{(resultA / resultB):f2}");

            //Console.WriteLine($"{(FactorialDivision(a) / (FactorialDivision(b))):f2}");
        }

        static double FactorialDivision(int num)
        {
            double factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}


/* Read two integers. Calculate the factorial of each number. 
 * Divide the first result by the second and print the result of the division formatted to the second decimal point.
 * 
 * Input
 * 5
 * 2
 * Output
 * 60.00
 * 
 * Input
 * 6
 * 2
 * Output
 * 360.00
 * 
 */