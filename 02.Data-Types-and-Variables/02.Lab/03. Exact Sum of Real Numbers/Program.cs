using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            decimal exactSum = 0;

            for (int i = 0; i < nNumbers; i++)
            {
                exactSum += decimal.Parse(Console.ReadLine());
                
            }

            Console.WriteLine(exactSum);

        }
    }
}
