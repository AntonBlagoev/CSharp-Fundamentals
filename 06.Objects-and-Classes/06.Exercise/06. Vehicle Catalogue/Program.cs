using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputArgs[0] == "End")
                {
                    break;
                }
                VehicleType vehicleType;
                bool isVehicleTypeParseSuccessful = Enum.TryParse(inputArgs[0], true, out vehicleType); //проверка на типа кола, ако не е Car или Truck връща false

                if (isVehicleTypeParseSuccessful)
                {
                    string vehicleModel = inputArgs[1];
                    string vehicleColor = inputArgs[2];
                    int vehicleHorsePower = int.Parse(inputArgs[3]);

                    var curVehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, vehicleHorsePower);
                    vehicleList.Add(curVehicle);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close the Catalogue")
                {
                    break;
                }

                var searchedVehicle = vehicleList.Find(x => x.Model == command); // става и с FirstOrDefault

                Console.WriteLine(searchedVehicle); // изплозва StringBuilder
            }

            var cars = vehicleList.Where(x => x.Type == VehicleType.Car).ToList(); // нов списък само с "Cars"
            var trucks = vehicleList.Where(x => x.Type == VehicleType.Truck).ToList(); // нов списък само с "Trucks"

            //double carsAvgHorsePower = 0.00;
            //if (cars.Count > 0)
            //{
            //    carsAvgHorsePower = cars.Average(x => x.HorsePower);
            //}

            double carsAvgHorsePower = cars.Count > 0 ? cars.Average(x => x.HorsePower) : 0.00; // Съкратен запис на горния if
            double trucksAvgHorsePower = trucks.Count > 0 ? trucks.Average(x => x.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsePower:f2}.");


        }
    }

    enum VehicleType
    {
        Car,
        Truck
    }

    class Vehicle
    {
        public Vehicle(VehicleType type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }

    }
}

/* Until you receive the "End" command, you will be receiving lines of input in the following format:
 * "{typeOfVehicle} {model} {color} {horsepower}"
 * When you receive the "End" command, you will start receiving information about some vehicles.
 * For every vehicle, print out the information about it in the following format:
 * "Type: {typeOfVehicle}
 * Model: {modelOfVehicle}
 * Color: {colorOfVehicle}
 * Horsepower: {horsepowerOfVehicle}"
 * 
 * When you receive the "Close the Catalogue" command, print out the average horsepower of the cars 
 * and the average horsepower of the trucks in the format:
 * "{typeOfVehicles} have average horsepower of {averageHorsepower}."
 * The average horsepower is calculated by dividing the sum of the horsepower of all vehicles 
 * of the given type by the total count of all vehicles from that type. Format the answer to the second digit after the decimal point.
 * 
 * Constraints
 * •	The type of vehicle will always be either a car or a truck.
 * •	You will not receive the same model twice.
 * •	The received horsepower will be an integer in the range [1…1000].
 * •	You will receive at most 50 vehicles.
 * •	The separator will always be single whitespace. * 
 * 
 * INPUT
 * truck Man red 200
 * truck Mercedes blue 300
 * car Ford green 120
 * car Ferrari red 550
 * car Lamborghini orange 570
 * End
 * Ferrari
 * Ford
 * Man
 * Close the Catalogue
 * 
 * OUTPUT
 * Type: Car
 * Model: Ferrari
 * Color: red
 * Horsepower: 550
 * Type: Car
 * Model: Ford
 * Color: green
 * Horsepower: 120
 * Type: Truck
 * Model: Man
 * Color: red
 * Horsepower: 200
 * Cars have average horsepower of: 413.33.
 * Trucks have average horsepower of: 250.00.
 * 
 * INPUT
 * truck Volvo blue 220
 * truck Man red 350
 * car Tesla silver 450
 * car Nio red 650
 * truck Mack white 430
 * car Koenigsegg orange 750
 * End
 * Tesla
 * Nio
 * Man
 * Mack
 * Close the Catalogue
 * 
 * OUTPUT
 * Type: Car
 * Model: Tesla
 * Color: silver
 * Horsepower: 450
 * Type: Car
 * Model: Nio
 * Color: red
 * Horsepower: 650
 * Type: Truck
 * Model: Man
 * Color: red
 * Horsepower: 350
 * Type: Truck
 * Model: Mack
 * Color: white
 * Horsepower: 430
 * Cars have average horsepower of: 616.67.
 * Trucks have average horsepower of: 333.33.
 * 
 */