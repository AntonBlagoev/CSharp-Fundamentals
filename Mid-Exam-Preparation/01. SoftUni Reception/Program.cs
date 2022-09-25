using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int sumEmployee = firstEmployee + secondEmployee + +thirdEmployee;
            int count = studentsCount;
            int time = 0;

            for (int i = 1; i <= count; i++)
            {

                if (i % 4 != 0)
                {
                    studentsCount -= sumEmployee;
                }
                time++;
                if (studentsCount <= 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Time needed: {time}h.");

        }
    }
}
