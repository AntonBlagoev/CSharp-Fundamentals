using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            double biggestKegVolume = 0.0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * (kegRadius * kegRadius) * kegHeight;

                if (kegVolume > biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKeg = kegModel;
                }

            }

            Console.WriteLine(biggestKeg);

        }
    }
}
