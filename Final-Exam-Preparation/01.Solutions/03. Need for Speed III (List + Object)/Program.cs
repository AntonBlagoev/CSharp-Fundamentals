using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III__List___Object_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCars = Console.ReadLine().Split('|');
                carsList.Add(new Car(inputCars[0], int.Parse(inputCars[1]), int.Parse(inputCars[2])));
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split(" : ");

                switch (commands[0])
                {
                    case "Drive":
                        Drive(commands[1], int.Parse(commands[2]), int.Parse(commands[3]), carsList);
                        break;
                    case "Refuel":
                        Refuel(commands[1], int.Parse(commands[2]), carsList);
                        break;
                    case "Revert":
                        Revert(commands[1], int.Parse(commands[2]), carsList);
                        break;
                }
            }
            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Brand} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        static void Drive(string brand, int distance, int fuel, List<Car> carsList)
        {
            Car car = carsList.First(x => x.Brand == brand);
            if (car.Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }
            car.Fuel -= fuel;
            Console.WriteLine($"{brand} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            car.Mileage += distance;

            if (car.Mileage >= 100000)
            {
                Console.WriteLine($"Time to sell the {brand}!");
                carsList.Remove(car);
            }
        }

        static void Refuel(string brand, int fuel, List<Car> carsList)
        {
            Car car = carsList.First(x => x.Brand == brand);
            if (car.Fuel + fuel > 75)
            {
                fuel = 75 - car.Fuel;
            }
            car.Fuel += fuel;
            Console.WriteLine($"{brand} refueled with {fuel} liters");
        }
        static void Revert(string brand, int kilometers, List<Car> carsList)
        {
            Car car = carsList.First(x => x.Brand == brand);
            if (car.Mileage - kilometers <= 10000)
            {
                car.Mileage = 10000;
                return;
            }
            car.Mileage -= kilometers;
            Console.WriteLine($"{brand} mileage decreased by {kilometers} kilometers");
        }
    }
}
class Car
{
    public string Brand { get; set; }
    public int Mileage { get; set; }
    public int Fuel { get; set; }
    public Car(string brand, int mileage, int fuel)
    {
        Brand = brand;
        Mileage = mileage;
        Fuel = fuel;
    }
}
