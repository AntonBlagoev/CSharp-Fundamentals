using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string inputString = Console.ReadLine();

            List<char> inputList = new List<char>();
            inputList.AddRange(inputString);

            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> tmpList = new List<char>();
                tmpList.AddRange(numbers[i].ToString());
                int indexNumber = 0;
                foreach (var chars in tmpList)
                {
                    indexNumber += int.Parse(chars.ToString());
                }

                if (indexNumber > inputList.Count)
                {
                    indexNumber -= inputList.Count;
                }
                Console.Write(inputList[indexNumber]);
                inputList.RemoveAt(indexNumber);
            }
        }
    }
}

/* You will be given a list of numbers and a string. 
 * For each element of the list you must calculate the sum of its digits and take the element, corresponding to that index from the text. 
 * If the index is greater than the length of the text, start counting from the beginning (so that you always have a valid index). 
 * After you get that element from the text, you must remove the character you have taken from it 
 * (so for the next index the text will be with one characterless).
 * 
 * Example
 * 
 * Input
 * 9992 562 8933
 * This is some message for you
 * 
 * Output
 * hey
 * 
 * Input
 * 11 2 32 43 331 522 441 2241 711 1821
 * 69da343n44ge96rous311!
 * 
 * Output
 * dangerous!
 * 
 */