using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            
            while (true)
            {
                string[] inputArr = Console.ReadLine().Split(' ');

                if (inputArr[0] == "end")
                {
                    break;
                }

                string firstName = inputArr[0];
                string lasttName = inputArr[1];
                int age = int.Parse(inputArr[2]);
                string homeTown = inputArr[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LasttName = lasttName,
                    Age = age,
                    HomeTown = homeTown
                };

                studentList.Add(student);
            }

            string cityName = Console.ReadLine();

            foreach (var student in studentList)
            {
                if (cityName == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LasttName} is {student.Age} years old.");
                }
            }

            //List<Student> filteredStudents = studentList
            //    .Where(s => s.HomeTown == cityName)
            //    .ToList();
            //foreach (Student student in filteredStudents)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LasttName} is {student.Age} years old.");
            //}



        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }


    }
}
/* Define a class called Student, which will hold the following information about some students: 
 * •	first name
 * •	last name
 * •	age
 * •	home town
 * 
 * Input / Constraints
 * Read information about some students, until you receive the "end" command. After that, you will receive a city name.
 * 
 * Output
 * Print the students who are from the given city in the following format: "{firstName} {lastName} is {age} years old."
 * 
 * INPUT
 * John Smith 15 Sofia
 * Peter Ivanov 14 Plovdiv
 * Linda Bridge 16 Sofia
 * Simon Stone 12 Varna
 * end
 * Sofia
 * 
 * OUTPUT
 * John Smith is 15 years old.
 * Linda Bridge is 16 years old.
 * 
 * INPUT
 * Anthony Taylor 15 Chicago
 * David Anderson 16 Washington
 * Jack Lewis 14 Chicago
 * David Lee 14 Chicago
 * end
 * Chicago
 * 
 * OUTPUT
 * Anthony Taylor is 15 years old.
 * Jack Lewis is 14 years old.
 * David Lee is 14 years old.
 * 
 */
