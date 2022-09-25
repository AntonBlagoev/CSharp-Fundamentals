using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargotype = input[4];

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargotype);
                var car = new Car(model, engine, cargo);

                carList.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in carList.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in carList.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public Car(string model, Engine engine, Cargo cargo)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
    }
}
class Engine
{
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }
    public Engine(int engineSpeed, int enginePower)
    {
        EngineSpeed = engineSpeed;
        EnginePower = enginePower;
    }
}
class Cargo
{
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }
    public Cargo(int cargoWeight, string cargoType)
    {
        CargoWeight = cargoWeight;
        CargoType = cargoType;
    }
}


/* You are the owner of a courier company and you want to make a system for tracking your cars and their cargo. 
 * Define a class Car that holds a piece of information about the model, engine and cargo. 
 * The Engine and Cargo should be separate classes. 
 * Create a constructor that receives all of the information about the Car and creates and initializes its inner components (engine and cargo).
 * On the first line, of input you will receive a number N – the number of cars you have. 
 * On each of the next N lines, you will receive the following 
 * information about a car: "<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>", where the speed, power and weight are all integers. 
 * After the N lines, you will receive a single line with one of 2 commands: "fragile" or "flamable". 
 * If the command is "fragile", print all cars, whose Cargo Type is "fragile" with cargo with weight  < 1000. 
 * If the command is "flamable", print all of the cars whose Cargo Type is "flamable" and have Engine Power > 250. 
 * The cars should be printed in order of appearing in the input.
 * 
 * INPUT
 * 2
 * ChevroletAstro 200 180 1000 fragile
 * Citroen2CV 190 165 900 fragile
 * fragile
 * 
 * OUTPUT
 * Citroen2CV
 * 
 * INPUT
 * 4
 * ChevroletExpress 215 255 1200 flamable
 * ChevroletAstro 210 230 1000 flamable
 * DaciaDokker 230 275 1400 flamable
 * Citroen2CV 190 165 1200 fragile
 * flamable 
 * 
 * OUTPUT
 * ChevroletExpress
 * DaciaDokker
 * 
 */