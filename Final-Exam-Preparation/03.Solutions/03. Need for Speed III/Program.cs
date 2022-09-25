using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsDict = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputCars = Console.ReadLine().Split('|');
                carsDict.Add(inputCars[0], new Car(int.Parse(inputCars[1]), int.Parse(inputCars[2])));
            }

            string inputCommands = string.Empty;
            while ((inputCommands = Console.ReadLine()) != "Stop")
            {
                string[] commands = inputCommands.Split(" : ");

                switch (commands[0])
                {
                    case "Drive":
                        Drive(commands[1], int.Parse(commands[2]), int.Parse(commands[3]), carsDict);
                        break;

                    case "Refuel":
                        Refuel(commands[1], int.Parse(commands[2]), carsDict);
                        break;

                    case "Revert":
                        Revert(commands[1], int.Parse(commands[2]), carsDict);
                        break;
                }
            }

            foreach (var car in carsDict)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }

        }

        static void Drive(string car, int distance, int fuel, Dictionary<string, Car> carsDict)
        {
            if (carsDict[car].Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }
            carsDict[car].Fuel -= fuel;
            carsDict[car].Mileage += distance;
            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            if (carsDict[car].Mileage >= 100000)
            {
                carsDict.Remove(car);
                Console.WriteLine($"Time to sell the {car}!");
            }
        }

        static void Refuel(string car, int fuel, Dictionary<string, Car> carsDict)
        {
            if (carsDict[car].Fuel + fuel > 75)
            {
                fuel = 75 - carsDict[car].Fuel;
            }
            carsDict[car].Fuel += fuel;
            Console.WriteLine($"{car} refueled with {fuel} liters");
        }

        static void Revert(string car, int kilometers, Dictionary<string, Car> carsDict)
        {
            carsDict[car].Mileage -= kilometers;
            if (carsDict[car].Mileage < 10000)
            {
                carsDict[car].Mileage = 10000;
                return;
            }
            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
        }
    }
}

class Car
{
    public int Mileage { get; set; }
    public int Fuel { get; set; }
    public Car(int mileage, int fuel)
    {
        Mileage = mileage;
        Fuel = fuel;
    }
}
