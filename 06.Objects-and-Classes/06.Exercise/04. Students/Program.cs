using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            int countOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] inputArr = Console.ReadLine().Split();
                var student = new Student(inputArr[0], inputArr[1], decimal.Parse(inputArr[2]));
                studentsList.Add(student);
            }

            studentsList = studentsList.OrderByDescending(currStudent => currStudent.Grade).ToList();

            studentsList.ForEach(student => Console.WriteLine(student));

            //foreach (Student student in studentsList)
            //{
            //    Console.WriteLine(student);
            //}
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + ": " + Grade;
        }
        //public override string ToString() => $"{FirstName} {LastName}: {Grade}"
    }
}
/* Create a program that sorts some students by their grade in descending order. Each student should have:
 * •	First name (String)
 * •	Last name (String)
 * •	Grade (a floating-point number)
 * 
 * Input
 * •	On the first line, you will receive a number n - the count of all students.
 * •	On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}".
 * 
 * Output
 * •	Print out the information about each student in the following format: "{first name} {second name}: {grade}".
 * 
 * 
 * INPUT
 * 4
 * Lakia Eason 3.90
 * Prince Messing 5.49
 * Akiko Segers 4.85
 * Rocco Erben 6.00
 * 
 * OUTPUT
 * Rocco Erben: 6.00
 * Prince Messing: 5.49
 * Akiko Segers: 4.85
 * Lakia Eason: 3.90
 * 
 * INPUT
 * 3
 * Mary Elizabeth 4.22
 * Li Xiao 5.74
 * Liz Smith 4.87
 * 
 * OUTPUT
 * Li Xiao: 5.74
 * Liz Smith: 4.87
 * Mary Elizabeth: 4.22
 * 
 */