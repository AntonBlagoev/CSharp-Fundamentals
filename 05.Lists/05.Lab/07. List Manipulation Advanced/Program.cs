using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            bool inputListIsChanged = false;

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "end")
                {
                    break;
                }
                
                switch (commands[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        inputList.Add(numberToAdd);
                        inputListIsChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commands[1]);
                        inputList.Remove(numberToRemove);
                        inputListIsChanged = true;
                        break;
                    case "RemoveAt":
                        int numberToRemoveAt = int.Parse(commands[1]);
                        inputList.RemoveAt(numberToRemoveAt);
                        inputListIsChanged = true;
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(commands[2]);
                        int numberToInsert = int.Parse(commands[1]);
                        inputList.Insert(indexToInsert, numberToInsert);
                        inputListIsChanged = true;
                        break;
                    case "Contains":
                        int numberIsContains = int.Parse(commands[1]);
                        Contains(inputList, numberIsContains);
                        break;
                    case "PrintEven":
                        PrintEven(inputList);
                        break;
                    case "PrintOdd":
                        PrintOdd(inputList);
                        break;
                    case "GetSum":
                        int sum = GetSum(inputList);
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string conditionFilter = commands[1];
                        int numberFilter = int.Parse(commands[2]);
                        Filter(inputList, conditionFilter, numberFilter);
                        break;
                }
            }
            if (inputListIsChanged)
            {
                Console.WriteLine(string.Join(" ", inputList));
            }
        }

        static void Filter(List<int> inputList, string condition, int number)
        {
            List<int> result = new List<int>();

            if (condition == "<")
            {
                result = new List<int>(inputList.FindAll(n => n < number));
            }
            else if (condition == ">")
            {
                result = new List<int>(inputList.FindAll(n => n > number));
            }
            else if (condition == ">=")
            {
                result = new List<int>(inputList.FindAll(n => n >= number));
            }
            else if (condition == "<=")
            {
                result = new List<int>(inputList.FindAll(n => n <= number));
            }
            Console.Write(string.Join(" ", result));
            Console.WriteLine();
        }
        static int GetSum(List<int> inputList)
        {
            return inputList.Sum();
        }

        static void PrintOdd(List<int> inputList)
        {
            List<int> oddList = new List<int>(inputList.FindAll(n => n % 2 != 0));
            Console.Write(string.Join(" ", oddList));
            Console.WriteLine();
        }
        static void PrintEven(List<int> inputList)
        {
            List<int> evenList = new List<int>(inputList.FindAll(n => n % 2 == 0));
            Console.Write(string.Join(" ", evenList));
            Console.WriteLine();
        }

        static void Contains(List<int> containstList, int containstNumber)
        {
            if (containstList.Contains(containstNumber))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}

/* Next, we are going to implement more complicated list commands, extending the previous task. 
 * Again, read a list and keep reading commands until you receive "end":
 * •	Contains {number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
 * •	PrintEven – print all the even numbers, separated by a space.
 * •	PrintOdd – print all the odd numbers, separated by a space.
 * •	GetSum – print the sum of all the numbers.
 * •	Filter {condition} {number} – print all the numbers that fulfill the given condition. 
 * The condition will be either '<', '>', ">=", "<=".
 * After the end command, print the list only if you have made some changes to the original list. 
 * Changes are made only from the commands from the previous task.
 * 
 * 
 * Input
 * 5 34 678 67 5 563 98
 * Contains 23
 * PrintOdd
 * GetSum
 * Filter >= 21
 * end
 * 
 * Output
 * No such number
 * 5 67 5 563
 * 1450
 * 34 678 67 563 98
 * 
 * 
 * 
 * Input
 * 2 13 43 876 342 23 543
 * Contains 100
 * Contains 543
 * PrintEven
 * PrintOdd
 * GetSum
 * Filter >= 43
 * Filter < 100
 * end
 * 
 * Output
 * No such number
 * Yes
 * 2 876 342
 * 13 43 23 543
 * 1842
 * 43 876 342 543
 * 2 13 43 23
 * 
 * 
 */