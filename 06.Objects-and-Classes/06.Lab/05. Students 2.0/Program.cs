using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
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

                Student student = studentList.FirstOrDefault(s => s.FirstName == firstName && s.LasttName == lasttName);
                if (student == null)
                {
                    studentList.Add(new Student() 
                    {
                        FirstName = firstName,
                        LasttName = lasttName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LasttName = lasttName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                
            }

            string cityName = Console.ReadLine();

            foreach (Student student in studentList)
            {
                if (cityName == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LasttName} is {student.Age} years old.");
                }
            }
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
/* Use the class from the previous problem. 
 * If you receive a student, which already exists (first name and last name should be unique) overwrite the information.
 * 
 * INPUT
 * John Smith 15 Sofia
 * Peter Johnson 14 Plovdiv
 * Peter Johnson 25 Plovdiv
 * Linda Bridge 16 Sofia
 * Linda Bridge 27 Sofia
 * Simon Stone 12 Varna
 * end
 * Sofia
 * 
 * OUTPUT
 * John Smith is 15 years old.
 * Linda Bridge is 27 years old.
 * 
 * 
 * INPUT
 * Anthony Taylor 15 Chicago
 * David Anderson 16 Washington
 * Jack Lewis 14 Chicago
 * David Lee 14 Chicago
 * Jack Lewis 26 Chicago
 * David Lee 18 Chicago
 * end
 * Chicago
 * 
 * OUTPUT
 * Anthony Taylor is 15 years old.
 * Jack Lewis is 26 years old.
 * David Lee is 18 years old.
 * 
 * 
 */