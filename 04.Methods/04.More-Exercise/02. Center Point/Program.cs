using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPointToCenter(x1, y1, x2, y2);
        }

        static void PrintClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            if ((Math.Abs(x1) + Math.Abs(y1)) <= (Math.Abs(x2) + Math.Abs(y2)))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
/* You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2, and Y2. 
 * Create a method that prints the point that is closest to the center of the coordinate system (0, 0) in the format (X, Y). 
 * If the points are at the same distance from the center, print only the first one.
 * 
 * Input
 * 2
 * 4
 * -1
 * 2
 * 
 * Output
 * (-1, 2)
 * 
 * Input
 * 3
 * -6
 * 2
 * 10
 * 
 * Output
 * (3, -6)
 * 
 */