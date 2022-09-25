using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = 
            { 
                "Excellent product.", 
                "Such a great product.", 
                "I always use that product.", 
                "Best product of its category.", 
                "Exceptional product.", 
                "I can't live without this product." 
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string indexPhrases = phrases[random.Next(0, phrases.Length)];
                string indexEvents = events[random.Next(0, events.Length)];
                string indexAuthors =  authors[random.Next(0, authors.Length)];
                string indexCities =  cities[random.Next(0, cities.Length)];

                Console.WriteLine($"{indexPhrases} {indexEvents} {indexAuthors} – {indexCities}.");
            }
        }
    }
}
/* Create a program that generates random fake advertisement messages to advertise a product. 
 * The messages must consist of 4 parts: phrase + event + author + city. 
 * 
 * Use the following predefined parts:
 * •	Phrases – {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."}
 * •	Events – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
 * •	Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
 * •	Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
 * 
 * The format of the output message is the following: "{phrase} {event} {author} – {city}."
 * 
 * You will receive the number of messages to be generated. Print each random message at a separate line.
 * 
 * INPUT
 * 3
 * 
 * OUTPUT
 * Such a great product. Now I feel good. Elena – Ruse.
 * Excellent product. Makes miracles. I am happy of the results! Katya – Varna.
 * Best product of its category. That makes miracles. Eva – Sofia.
 * 
 */