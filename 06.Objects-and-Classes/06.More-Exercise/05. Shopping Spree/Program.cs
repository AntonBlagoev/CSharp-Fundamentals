using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personsList = new List<Person>();
            List<Product> productsList = new List<Product>();

            string[] inputPersons = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in inputPersons)
            {
                string[] currPerson = item.Split('=');
                personsList.Add(new Person(currPerson[0], int.Parse(currPerson[1]), new List<string>()));
            }

            string[] inputProducts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in inputProducts)
            {
                string[] currProduct = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                productsList.Add(new Product(currProduct[0], int.Parse(currProduct[1])));
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commands = input.Split();
                string currPersonName = commands[0];
                string currProductName = commands[1];

                var findedProductIndex = productsList.FindIndex(x => x.Name == currProductName);
                var findedPersonIndex = personsList.FindIndex(x => x.Name == currPersonName);

                if (personsList[findedPersonIndex].Money >= productsList[findedProductIndex].Cost)
                {
                    personsList[findedPersonIndex].BagOfProducts.Add(currProductName);
                    personsList[findedPersonIndex].Money -= productsList[findedProductIndex].Cost;
                    Console.WriteLine($"{personsList[findedPersonIndex].Name} bought {currProductName}");
                }
                else 
                {
                    Console.WriteLine($"{personsList[findedPersonIndex].Name} can't afford {currProductName}");
                }
            }

            foreach (var person in personsList)
            {
                Console.Write($"{person.Name} - ");
                if (person.BagOfProducts.Count == 0)
                {
                    Console.WriteLine("Nothing bought");
                    continue;
                }
                Console.WriteLine(string.Join(", ", person.BagOfProducts));
            }
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Money { get; set; }
    public List<string> BagOfProducts { get; set; }
    public Person(string name, int money, List<string> bagOfProducts)
    {
        Name = name;
        Money = money;
        BagOfProducts = bagOfProducts;
    }
}
class Product
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public Product(string name, int cost)
    {
        Name = name;
        Cost = cost;
    }
}





/* Create two classes: class Person and class Product. 
 * Each person should have a name, money and a bag of products. 
 * Each product should have a name and a cost. 
 * 
 * Create a program, in which each command corresponds to a person buying a product. 
 * If the person can afford a product, add it to his bag. 
 * If a person doesn't have enough money, print an appropriate message: "{Person} can't afford {Product}".
 * 
 * On the first two lines, you are given all people and all products. 
 * After all purchases, print every person in the order of appearance and all products that they have bought, 
 * also in order of appearance. If nothing was bought, print the name of the person followed by "Nothing bought". 
 * 
 * INPUT
 * Peter=11;George=4
 * Bread=10;Milk=2;
 * Peter Bread
 * George Milk
 * George Milk
 * Peter Milk
 * END
 * 
 * OUTPUT
 * Peter bought Bread
 * George bought Milk
 * George bought Milk
 * Peter can't afford Milk
 * Peter - Bread
 * George - Milk, Milk
 * 
 * INPUT
 * Maria=0
 * Coffee=2
 * Maria Coffee
 * END
 * 
 * OUTPUT
 * Maria can't afford Coffee
 * Maria - Nothing bought
 * 
 */
