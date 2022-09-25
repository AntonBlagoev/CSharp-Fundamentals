using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "End")
                {
                    break;
                }

                int index1 = int.Parse(commands[1]);
                int index2 = int.Parse(commands[2]);

                if (commands[0] == "Shoot")
                {
                    if (index1 >= 0 && index1 < inputList.Count)
                    {
                        inputList[index1] -= index2;
                        if (inputList[index1] <= 0)
                        {
                            inputList.RemoveAt(index1);
                        }
                    }
                }

                else if (commands[0] == "Add")
                {
                    if (index1 >= 0 && index1 < inputList.Count)
                    {
                        inputList.Insert(index1, index2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                else if (commands[0] == "Strike")
                {
                    if (index1 - index2 < 0 || index1 + index2 > inputList.Count - 1)
                    {
                        Console.WriteLine("Strike missed!");
                        
                    }
                    else
                    {
                        inputList.RemoveRange(index1 - index2, (index2 * 2) + 1);
                    }
                    

                }


            }

            Console.WriteLine(string.Join("|", inputList));

        }
    }
}
