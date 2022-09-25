using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Length: ");
            double lengthOfPyramid = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double widthOfPyramid = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double heitthOfPyramid = double.Parse(Console.ReadLine());

            double volumeOfPyramid = (lengthOfPyramid * widthOfPyramid * heitthOfPyramid) / 3;
            Console.Write($"Pyramid Volume: {volumeOfPyramid:f2}");

        }
    }
}
