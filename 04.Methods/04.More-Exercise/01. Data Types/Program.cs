using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();

            FindDataTypes(firstInput);

        }

        static void FindDataTypes(string inputString)
        {
            if (inputString == "int")
            {
                int isInt = int.Parse(Console.ReadLine());
                Console.WriteLine(isInt * 2);
            }
            else if (inputString == "real")
            {
                double isDouble = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(isDouble * 1.5):f2}");
            }
            else if (inputString == "string")
            {
                string isString = Console.ReadLine();
                Console.WriteLine($"${isString}$");
            }
        }
    }
}

/* Write a program that, depending on the first line of the input, reads an int, a double or a string.
 * •	If the data type is int, multiply the number by 2.
 * •	If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
 * •	If the data type is a string, surround the input with '$'.
 * 
 * Print the result on the console.
 * 
 * Input
 * int
 * 5
 * Output
 * 10
 * 
 * Input
 * real
 * 2
 * 
 * Output
 * 3.00
 * 
 * Input
 * string
 * hello
 * 
 * Output
 * $hello$
 * 
 */