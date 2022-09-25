using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            List<char> inputCharList = new List<char>();
            inputCharList.AddRange(inputString);

            List<int> numberList = new List<int>();
            List<string> nonNumberList = new List<string>();

            foreach (var item in inputCharList)
            {
                if (item >= 48 && item <= 57)
                {
                    numberList.Add(int.Parse(item.ToString()));
                }
                else
                {
                    nonNumberList.Add(item.ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numberList[i]);
                }
                else
                {
                    skipList.Add(numberList[i]);
                }
            }

            int countNumberToPrint = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    if (countNumberToPrint == nonNumberList.Count)
                    {
                        break;
                    }
                    Console.Write(nonNumberList[countNumberToPrint]);
                    countNumberToPrint++;
                }

                countNumberToPrint += skipList[i];
            }
            Console.WriteLine();
        }
    }
}

/* Write a program, which reads a string and skips through it, extracting a hidden message. The algorithm you have to implement is as follows:
 * Let's take the string "skipTest_String044170" as an example.
 * Take every digit from the string and store it somewhere. 
 * After that, remove all the digits from the string. 
 * After this operation, you should have two lists of items: the numbers list and the non-numbers list:
 * •	Numbers list: [0, 4, 4, 1, 7, 0]
 * •	Non-numbers: [s, k, i, p, T, e, s, t, _, S, t, r, i, n, g]
 * 
 * After that, take every digit in the numbers list and split it up into a take list and a skip list, 
 * depending on whether the digit is in an even or an odd index:
 * •	Numbers list: [0, 4, 4, 1, 7, 0]
 * •	Take list: [0, 4, 7]
 * •	Skip list: [4, 1, 0]
 * 
 * Afterward, iterate over both lists and skip {skipCount} characters from the non-numbers list, 
 * then take {takeCount} characters and store it in a result string. Note that the skipped characters are summed up as they go. 
 * The process would look like this on the aforementioned non-numbers list:
 * 1.	Take 0 characters  Taken: "", skip 4 characters (total 0)  Skipped: "skipTest_String" Result: ""
 * 2.	Take 4 characters Taken: "Test", skip 1 character (total 4)  Skipped: "skip"  Result: "Test"
 * 3.	Take 7 characters Taken: "String", skip 0 characters (total 9) Skipped: ""  Result: "TestString"
 * 
 * After that, just print the result string on the console.
 * 
 * Input
 * •	First line: The encrypted message as a string
 * 
 * Output
 * •	First line: The decrypted message as a string
 * 
 * Constraints
 * •	The count of digits in the input string will always be even.
 * •	The encrypted message will contain any printable ASCII character.
 * 
 * Examples
 * 
 * Input
 * T2exs15ti23ng1_3cT1h3e0_Roppe
 * 
 * Output
 * TestingTheRope
 * 
 * Input
 * O{1ne1T2021wf312o13Th111xreve!!@!
 * 
 * Output
 * OneTwoThree!!!
 * 
 * Input
 * this forbidden mess of an age rating 0127504740
 * 
 * Output
 * hidden message
 * 
 */