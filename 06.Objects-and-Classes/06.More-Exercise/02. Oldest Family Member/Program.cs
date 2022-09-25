using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Person> family = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                family.Add(new Person(name, age));
            }

            List<Person> orderedList = new List<Person>(family.OrderByDescending(x => x.Age).ToList());

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(orderedList[i]);
            }
        }


        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return $"{Name} {Age}";
            }
        }
    }
}

/* Create two classes – Family and Person. The Person class should have Name and Age properties. 
 * The Family class should have a list of people, a method for adding members (void AddMember(Person member)), 
 * and a method, which returns the oldest family member (Person GetOldestMember()). 
 * Write a program that reads the names and ages of N people and adds them to the family. 
 * Then print the name and age of the oldest member.
 * 
 * INPUT
 * 3
 * Peter 3
 * George 4
 * Annie 5
 * 
 * OUTPUT
 * Annie 5
 * 
 * INPUT
 * 5
 * Steve 10
 * Christopher 15
 * Annie 4
 * John 35
 * Maria 34
 * 
 * OUTPUT
 * John 35
 * 
 * 
 */
