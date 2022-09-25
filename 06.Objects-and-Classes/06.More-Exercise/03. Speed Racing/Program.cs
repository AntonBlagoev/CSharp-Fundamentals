using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsDict = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputCars = Console.ReadLine().Split();
                string carModel = inputCars[0];
                double fuelAmount = double.Parse(inputCars[1]);
                double fuelConsumptionFor1km = double.Parse(inputCars[2]);
                carsDict.Add(carModel, new Car(carModel, fuelAmount, fuelConsumptionFor1km, 0));
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string carModel = commands[1];
                int amountOfKm = int.Parse(commands[2]);

                double distanceToTravel = carsDict[carModel].FuelAmount / carsDict[carModel].FuelConsumptionFor1km;

                if (distanceToTravel < amountOfKm)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                    continue;
                }
                carsDict[carModel].FuelAmount -= carsDict[carModel].FuelConsumptionFor1km * amountOfKm;
                carsDict[carModel].TraveledDistance += amountOfKm;
            }
            foreach (Car car in carsDict.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionFor1km { get; set; }
    public int TraveledDistance { get; set; }
    public Car(string carModel, double fuelAmount, double fuelConsumptionFor1km, int traveledDistance)
    {
        Model = carModel;
        FuelAmount = fuelAmount;
        FuelConsumptionFor1km = fuelConsumptionFor1km;
        TraveledDistance = traveledDistance;
    }

}

/* Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars. 
 * Define a class Car that keeps a track of a car's model, fuel amount, fuel consumption per kilometer and traveled distance. 
 * A Car's model is unique - there will never be 2 cars with the same model.
 * On the first line of the input, you will receive a number N – the number of cars you need to track. 
 * On each of the next N lines, you will receive information about cars in the following format "<Model> <FuelAmount> <FuelConsumptionFor1km>". 
 * All cars start at 0 kilometers traveled.
 * After the N lines, until the command "End" is received, you will receive commands in the following format "Drive <CarModel> <amountOfKm>". 
 * Implement a method in the Car class to calculate whether or not a car can move that distance. 
 * If it can, the car's fuel amount should be reduced by the amount of used fuel 
 * and its traveled distance should be increased by the number of the traveled kilometers. 
 * Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same) 
 * and you should print on the console "Insufficient fuel for the drive".  
 * After the "End" command is received, print each car, its current fuel amount 
 * and the traveled distance in the format "<Model> <fuelAmount> <distanceTraveled>". 
 * Print the fuel amount rounded to two digits after the decimal separator.
 * 
 * INPUT
 * 2
 * AudiA4 23 0.3
 * BMW-M2 45 0.42
 * Drive BMW-M2 56
 * Drive AudiA4 5
 * Drive AudiA4 13
 * End
 * 
 * OUTPUT
 * AudiA4 17.60 18
 * BMW-M2 21.48 56
 * 
 * INPUT
 * 3
 * AudiA4 18 0.34
 * BMW-M2 33 0.41
 * Ferrari-488Spider 50 0.47
 * Drive Ferrari-488Spider 97
 * Drive Ferrari-488Spider 35
 * Drive AudiA4 85
 * Drive AudiA4 50
 * End
 * 
 * OUTPUT
 * Insufficient fuel for the drive
 * Insufficient fuel for the drive
 * AudiA4 1.00 50
 * BMW-M2 33.00 0
 * Ferrari-488Spider 4.41 97
 * 
 */