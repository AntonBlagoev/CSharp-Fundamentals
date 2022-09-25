using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();


            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "end")
                {
                    break;
                }

                if (commands[0] == "swap")
                {
                    int index1 = inputArray[int.Parse(commands[1])];
                    int index2 = inputArray[int.Parse(commands[2])];

                    inputArray[int.Parse(commands[1])] = index2;
                    inputArray[int.Parse(commands[2])] = index1;
                }

                else if (commands[0] == "multiply")
                {
                    inputArray[int.Parse(commands[1])] = inputArray[int.Parse(commands[1])] * inputArray[int.Parse(commands[2])];

                }
                else if (commands[0] == "decrease")
                {
                    for (int i = 0; i < inputArray.Length; i++)
                    {
                        inputArray[i] -= 1;
                    }
                }


            }

            Console.WriteLine(string.Join(", ",inputArray));
        }
    }
}
