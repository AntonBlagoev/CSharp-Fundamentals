using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int int32Val;
                double doubleVal;
                char charVal;
                bool booleanVal;

                bool result;
                if (result = Int32.TryParse(input, out int32Val))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (result = double.TryParse(input, out doubleVal))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (result = char.TryParse(input, out charVal))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (result = bool.TryParse(input, out booleanVal))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }

        }
    }
}
