using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 1.0;
            double discount = 1.0;

            if (typeOfGroup == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }
                if (countOfPeople >= 30)
                {
                    discount = 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16.00;
                        break;
                }
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 15.00;
                        break;
                    case "Saturday":
                        price = 20.00;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                }
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    discount = 0.95;
                }
            }
            double totalPrice = countOfPeople * price * discount;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
