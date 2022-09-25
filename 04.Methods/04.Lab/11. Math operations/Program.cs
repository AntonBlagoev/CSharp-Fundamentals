using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            int result = Calculations(a, @operator, b);
            Console.WriteLine(result);
        }

        static int Calculations(int a, string @operator ,int b )
        {
            int result = 0;
            switch (@operator)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}

/* Write a method that receives two numbers and an operator, calculates the result and returns it. 
 * You will be given three lines of input. 
 * The first will be the first number, the second one will be the operator and the last one will be the second number.
 * The possible operators are: /, *, + and -.
 * 
 * Input
 * 5
 * *
 * 5
 * Output
 * 25
 * 
 * Input
 * 4
 * +
 * 8
 * Output
 * 12
 * 
 * 
 */