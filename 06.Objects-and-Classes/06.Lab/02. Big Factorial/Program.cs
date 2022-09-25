using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;

            for (int i = 2; i <= input; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
/* You will receive a number N in the range [0…1000]. Calculate the Factorial of N and print out the result.
 * 
 * Input    
 * 50
 * 
 * Output
 * 30414093201713378043612608166064768844377641568960512000000000000
 * 
 * Input
 * 125
 * 
 * Output
 * 188267717688892609974376770249160085759540364871492425887598231508353156331613598866882932889495923133646405445930057740630161919341380597818883457558547055524326375565007131770880000000000000000000000000000000
 */