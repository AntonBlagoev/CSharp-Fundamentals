using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personsList = new List<Person>();

            while (true)
            {
                string[] inputArr = Console.ReadLine().Split();
                if (inputArr[0] == "End")
                {
                    break;
                }

                string nameOfPerson = inputArr[0];
                string idOfPerson = inputArr[1];
                int ageOfPerson = int.Parse(inputArr[2]);

                var isPersonIDinList = personsList.FirstOrDefault(x => x.ID == idOfPerson); // ако ID-то го има в списъка

                if (isPersonIDinList != null)
                {
                    isPersonIDinList.Name = nameOfPerson;
                    isPersonIDinList.Age = ageOfPerson;
                }
                else
                {
                    var person = new Person(nameOfPerson, idOfPerson, ageOfPerson);
                    personsList.Add(person);

                }


            }
            foreach (var person in personsList.OrderBy(x => x.Age).ToList())
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string nameOfPerson, string idOfPerson, int ageOfPerson)
        {
            Name = nameOfPerson;
            ID = idOfPerson;
            Age = ageOfPerson;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";
    }
}

/* You will receive an unknown number of lines. On each line you will receive an array with 3 elements:
 * •	The first element is a string - the name of the person
 * •	The second element a string - the ID of the person
 * •	The third element is an integer - the age of the person
 * If you get a person whose ID you have already received before, update the name and age for that ID with that of the new person. 
 * When you receive the command "End", print all of the people, ordered by age. 
 * 
 * INPUT
 * George 123456 20
 * Peter 78911 15
 * Stephen 524244 10
 * End
 * 
 * OUTPUT
 * Stephen with ID: 524244 is 10 years old.
 * Peter with ID: 78911 is 15 years old.
 * George with ID: 123456 is 20 years old.
 * 
 * INPUT
 * Lewis 123456 20
 * James 78911 15
 * Robert 523444 11
 * Jennifer 345244 13
 * Mary 52424678 22
 * Patricia 567343 54
 * End
 * 
 * OUTPUT
 * Robert with ID: 523444 is 11 years old.
 * Jennifer with ID: 345244 is 13 years old.
 * James with ID: 78911 is 15 years old.
 * Lewis with ID: 123456 is 20 years old.
 * Mary with ID: 52424678 is 22 years old.
 * Patricia with ID: 567343 is 54 years old.
 * 
 * 
 */