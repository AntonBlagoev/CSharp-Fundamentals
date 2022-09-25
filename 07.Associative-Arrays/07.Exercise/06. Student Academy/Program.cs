using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsDict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsDict.ContainsKey(studentName))
                {
                    studentsDict[studentName] = new List<double>();
                }
                studentsDict[studentName].Add(studentGrade);
            }

            foreach (var student in studentsDict)
            {

                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");

                }
                
                //double sumGrades = 0.0;
                //for (int i = 0; i < student.Value.Count; i++)
                //{
                //    sumGrades += student.Value[i];
                //}
                //double averageGrades = sumGrades / student.Value.Count;
                //if (averageGrades >= 4.50)
                //{
                //    Console.WriteLine($"{student.Key} -> {averageGrades:f2}");

                //}
            }
        }
    }
}

/* 6.	Student Academy
 * 
 * Create a program that keeps the information about students and their grades. 
 * You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade. 
 * heck if the student already exists and if not, add him. Keep track of all grades for each student.
 * When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
 * Print the students and their average grade in the following format:
 * "{name} –> {averageGrade}"
 * Format the average grade to the 2nd decimal place.
 * 
 * Examples
 * -------------------------------------
 * Input
 * 5
 * John
 * 5.5
 * John
 * 4.5
 * Alice
 * 6
 * Alice
 * 3
 * George
 * 5
 * 
 * Output
 * John -> 5.00
 * Alice -> 4.50
 * George -> 5.00
 * -------------------------------------
 * Input
 * 5
 * Amanda
 * 3.5
 * Amanda
 * 4
 * Rob
 * 5.5
 * Christian
 * 5
 * Robert
 * 6
 * 
 * Output
 * Rob -> 5.50
 * Christian -> 5.00
 * Robert -> 6.00
 *  
 */
