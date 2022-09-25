using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
            }
            else
            {
                for (int i = 1; times <= 10; i++)
                {
                    Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
                    times++;
                }
            }
                
        }
    }
}
