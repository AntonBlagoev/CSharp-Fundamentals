using System;
using System.Numerics;

namespace _01._Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
             
            string[] timeToStart = Console.ReadLine().Split(':');

            int hours = int.Parse(timeToStart[0]);
            int minutes = int.Parse(timeToStart[1]);
            int seconds = int.Parse(timeToStart[2]);

            int numberOfSteps = int.Parse(Console.ReadLine());
            int timeForEachStep = int.Parse(Console.ReadLine());

            BigInteger totalSecondsForWalk = numberOfSteps * timeForEachStep;

            BigInteger secondsToAdd = totalSecondsForWalk % 60;
            BigInteger minutesToAdd = (totalSecondsForWalk - secondsToAdd) / 60;
            BigInteger hoursToAdd = (totalSecondsForWalk - secondsToAdd - (minutesToAdd * 60)) / 3600;

            int tmpMinutesFromSeconds = 0;
            int tmpHoursFromMinutes = 0;
            

            if (seconds + secondsToAdd > 59)
            {
                tmpMinutesFromSeconds = (int)(seconds + secondsToAdd) / 60;
                seconds = (int)(seconds + secondsToAdd) % 60;
            }
            else
            {
                seconds = (int)(seconds + secondsToAdd);
            }

            if (minutes + minutesToAdd + tmpMinutesFromSeconds > 59)
            {
                tmpHoursFromMinutes = (int)(minutes + minutesToAdd + tmpMinutesFromSeconds) / 60;
                minutes = (int)(minutes + minutesToAdd + tmpMinutesFromSeconds) % 60;
            }
            else
            {
                minutes = (int)(minutes + minutesToAdd + tmpMinutesFromSeconds);
            }

            if (hours + hoursToAdd + tmpHoursFromMinutes > 23)
            {
                
                hours = (int)((hours + hoursToAdd + tmpHoursFromMinutes) % 24);
            }
            else
            {
                hours = (int)(hours + hoursToAdd + tmpHoursFromMinutes);
            }

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
