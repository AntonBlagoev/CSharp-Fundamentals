using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split('/');

                if (tokens[0] == "Car")
                {
                    Car car = new Car
                    {
                        Brand = tokens[1],
                        Model = tokens[2],
                        HorsePower = int.Parse(tokens[3])
                    };
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck
                    {
                        Brand = tokens[1],
                        Model = tokens[2],
                        Weight = int.Parse(tokens[3])
                    };
                    catalog.Trucks.Add(truck);
                }
            }

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }


    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

}
/* Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
 * Define a class Truck with the following properties: Brand, Model, and Weight.
 * Define a class Car with the following properties: Brand, Model, and Horse Power.
 * Define a class Catalog with the following properties: Collections of Trucks and Cars.
 * You must read the input, until you receive the "end" command. It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
 * In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
 * "Cars:
 * {Brand}: {Model} - {Horse Power}hp
 * Trucks:
 * {Brand}: {Model} - {Weight}kg"
 * 
 * INPUT
 * Car/Audi/A3/110
 * Car/Maserati/Levante/350
 * Truck/Mercedes/Actros/9019
 * Car/Porsche/Panamera/375
 * end
 * 
 * OUTPUT
 * Cars:
 * Audi: A3 - 110hp
 * Maserati: Levante - 350hp
 * Porsche: Panamera - 375hp
 * Trucks:
 * Mercedes: Actros - 9019kg
 * 
 * INPUT
 * Car/Subaru/Impreza/152
 * Car/Peugeot/307/109
 * end
 *  
 * OUTPUT
 * Cars:
 * Peugeot: 307 - 109hp
 * Subaru: Impreza - 152hp
 * 
 * 
 */