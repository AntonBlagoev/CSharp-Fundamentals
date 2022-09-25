using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III__Dictionary___Object_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsDict = new Dictionary<string, Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCars = Console.ReadLine().Split('|');
                carsDict.Add(inputCars[0], new Car(int.Parse(inputCars[1]), int.Parse(inputCars[2])));
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split(" : ");

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
            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            carsDict[car].Mileage += distance;
            
            if (carsDict[car].Mileage >= 100000)
            {
                Console.WriteLine($"Time to sell the {car}!");
                carsDict.Remove(car);
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
            if (carsDict[car].Mileage - kilometers <= 10000)
            {
                carsDict[car].Mileage = 10000;
                return;
            }
            carsDict[car].Mileage -= kilometers;
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