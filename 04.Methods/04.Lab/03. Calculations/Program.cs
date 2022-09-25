using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (input)
            {
               case "add":
                    Add(num1, num2);
                    break;
                case "multiply":
                    Multiply(num1, num2);
                    break;
                case "subtract":
                    Subtract(num1, num2);
                    break;
                case "divide":
                    Divide(num1, num2);
                    break;
                default:
                    break;
            }

        }

        static void Add(int num1, int num2)
        {
           Console.WriteLine(num1 + num2);
        }
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}

/* Create a program that receives three lines of input:
 * •	On the first line – a string – "add", "multiply", "subtract", "divide".
 * •	On the second line – a number.
 * •	On the third line – another number.
 * You should create four methods (for each calculation) and invoke the corresponding method depending on the command. 
 * The method should also print the result (needs to be void).
 * 
 * Input
 * subtract
 * 5
 * 4
 * Output
 * 1
 * 
 * Input
 * divide
 * 8
 * 4
 * Output
 * 2
 * 
 * 
 */