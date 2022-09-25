using System;
using System.Linq;


namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split().ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                string tmpElement = inputArray[0];
                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }
                inputArray[inputArray.Length - 1] = tmpElement;

                /*
                string[] tmpArray = new string[inputArray.Length];
                for (int j = inputArray.Length - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        tmpArray[tmpArray.Length - 1] = inputArray[j];
                    }
                    else
                    {
                        tmpArray[j - 1] = inputArray[j];
                    }
                }
                inputArray = tmpArray;
                */
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
