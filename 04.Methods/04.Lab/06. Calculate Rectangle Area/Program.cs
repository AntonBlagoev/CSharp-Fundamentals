using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }

        static double RectangleArea(double width, double height)
        {
            return  width * height;
        }
    }
}

/* Create a method that calculates and returns the area of a rectangle. 
 * 
 * Input
 * 3
 * 4
 * Output
 * 12
 * 
 * Input
 * 6
 * 2
 * Output
 * 12
 * 
 * 
 * 
 */