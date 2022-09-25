using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            string lastDigitValue = "";

            switch (lastDigit)
            {
                case 0:
                    lastDigitValue = "zero";
                    break;
                case 1:
                    lastDigitValue = "one";
                    break;
                case 2:
                    lastDigitValue = "two";
                    break;
                case 3:
                    lastDigitValue = "three";
                    break;
                case 4:
                    lastDigitValue = "four";
                    break;
                case 5:
                    lastDigitValue = "five";
                    break;
                case 6:
                    lastDigitValue = "six";
                    break;
                case 7:
                    lastDigitValue = "seven";
                    break;
                case 8:
                    lastDigitValue = "eight";
                    break;
                case 9:
                    lastDigitValue = "ten";
                    break;

                default:
                    break;
            }



            Console.WriteLine(lastDigitValue);


        }
    }
}
