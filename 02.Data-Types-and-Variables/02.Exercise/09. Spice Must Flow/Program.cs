using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYieldOfSpice = int.Parse(Console.ReadLine());
            int daysMineOfSpice = 0;
            int totalAmountOfSpiceExtracted = 0;
            int crewConsumes = 26;

            while (startingYieldOfSpice >= 100)
            {
                
                daysMineOfSpice++;
                totalAmountOfSpiceExtracted += startingYieldOfSpice - crewConsumes;
                startingYieldOfSpice -= 10;
                

            }

            if (totalAmountOfSpiceExtracted >= 26)
            {
                totalAmountOfSpiceExtracted -= crewConsumes;
            }
            

            Console.WriteLine(daysMineOfSpice);
            Console.WriteLine(totalAmountOfSpiceExtracted);

        }
    }
}
