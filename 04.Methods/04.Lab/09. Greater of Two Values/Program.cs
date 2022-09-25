using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfValues = Console.ReadLine();

            switch (typeOfValues)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondInt));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
                default:
                    break;
            }
        }

        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            return second;

        }
    }
}

/* You are given an input of two values of the same type. The values can be of type int, char or string. 
 * Create methods called GetMax(), which can compare int, char or string and returns the biggest of the two values.
 * 
 * Input
 * int
 * 2
 * 16
 * Output
 * 16
 * 
 * Input
 * char
 * a
 * z
 * Output
 * z
 * 
 * Input
 * string
 * aaa
 * bbb
 * Output
 * bbb
 * 
 */