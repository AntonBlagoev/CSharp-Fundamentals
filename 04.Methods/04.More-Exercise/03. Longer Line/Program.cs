using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            //Уравнение на Декарт - AB`2 = (x2-x1)`2 + (y2-y1)`2

            double line1 = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            double line2 = Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2);

            if (line1 >= line2)
            {
                PrintClosestPointToCenter(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestPointToCenter(x3, y3, x4, y4);
            }
        }

        static void PrintClosestPointToCenter(double a1, double b1, double a2, double b2)
        {
            if ((Math.Abs(a1) + Math.Abs(b1)) <= (Math.Abs(a2) + Math.Abs(b2)))
            {
                Console.WriteLine($"({a1}, {b1})({a2}, {b2})");
            }
            else
            {
                Console.WriteLine($"({a2}, {b2})({a1}, {b1})");
            }
        }
    }
}

/* You are given the coordinates of four points in the 2D plane. 
 * The first and the second pair of points form two different lines. 
 * Print the longer line in the format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the coordinate system (0, 0). 
 * (You can reuse the method that you wrote for the previous problem.) If the lines are of equal length, print only the first one.
 * 
 * Input
 * 2
 * 4
 * -1
 * 2
 * -5
 * -5
 * 4
 * -3
 * 
 * Output
 * (4, -3)(-5, -5)
 * 
 * Input
 * 34
 * -3
 * 5
 * 9
 * -8
 * 10
 * 8
 * 11
 * 
 * Output
 * (5, 9)(34, -3)
 * 
 */