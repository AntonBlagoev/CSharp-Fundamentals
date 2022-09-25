using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double halfN = n / 2.0;

            int count = 0;

            while (n >= m)
            {
                n -= m;
                count++;

                if (n == halfN && y != 0)
                {
                    n /= y;
                }

            }

            Console.WriteLine(n);
            Console.WriteLine(count);

        }
    }
}
