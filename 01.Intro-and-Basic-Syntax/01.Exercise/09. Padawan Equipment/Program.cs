using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double sabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            int beltsFree = studentsCount / 6;

            double equipmentCosts = (sabersPrice * Math.Ceiling(studentsCount * 1.1)) + (robesPrice * studentsCount) + (beltsPrice * (studentsCount - beltsFree));

            if (moneyAmount >= equipmentCosts)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentCosts:f2}lv.");
            }

            else
            {
                Console.WriteLine($"John will need {equipmentCosts - moneyAmount:f2}lv more.");
            }
            


        }
    }
}
