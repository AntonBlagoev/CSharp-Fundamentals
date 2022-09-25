using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double numberOfLectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());
            
            double maxBonus = 0;
            double studentAttendance = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                int attendanceOfEachStudent = int.Parse(Console.ReadLine());

                double totalBonus = attendanceOfEachStudent / numberOfLectures * (5 + bonus);
               
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    studentAttendance = attendanceOfEachStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendance} lectures.");




        }
    }
}
