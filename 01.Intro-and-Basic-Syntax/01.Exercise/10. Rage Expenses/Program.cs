using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = (headsetPrice * (gamesCount / 2)) + (mousePrice * (gamesCount / 3)) + (keyboardPrice * (gamesCount / 6)) + (displayPrice * (gamesCount / 12));

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");


        }
    }
}
