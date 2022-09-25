using System;
using System.Numerics;



namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int hightSnowballSnow = int.MinValue;
            int hightSnowballTime = int.MinValue;
            int hightSnowballQuality = int.MinValue;
            BigInteger hightSnowballValue = int.MinValue;

           
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(((snowballSnow) / (snowballTime)), snowballQuality);

                if (snowballValue > hightSnowballValue)
                {
                    hightSnowballSnow = snowballSnow;
                    hightSnowballTime = snowballTime;
                    hightSnowballQuality = snowballQuality;
                    hightSnowballValue = snowballValue;
                }
                
            }

            Console.WriteLine($"{hightSnowballSnow} : {hightSnowballTime} = {hightSnowballValue} ({hightSnowballQuality})");

        }
    }
}
