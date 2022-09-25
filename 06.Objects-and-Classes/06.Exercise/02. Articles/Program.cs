using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(", ");
            Article article = new Article(inputArr[0], inputArr[1], inputArr[2]);

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");

                switch (commands[0])
                {
                    case "Edit":
                        article.Edit(commands[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commands[1]);
                        break;
                    case "Rename":
                        article.Rename(commands[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }   
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string newContent) => Content = newContent;
        public void ChangeAuthor(string newAuthor) => Author = newAuthor;
        public void Rename(string newTitle) => Title = newTitle;
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}

/* Create a class Article with the following properties:
 * •	Title – a string
 * •	Content – a string
 * •	Author – a string
 * 
 * The class should have a constructor and the following methods:
 * •	Edit (new content) – change the old content with the new one
 * •	ChangeAuthor (new author) – change the author
 * •	Rename (new title) – change the title of the article
 * •	Override the ToString method – print the article in the following format:
 * "{title} - {content}: {author}"
 * 
 * Create a program that reads an article in the following format "{title}, {content}, {author}". 
 * On the next line, you will receive a number n, representing the number of commands, which will follow after it. 
 * On the next n lines, you will be receiving the following commands: 
 * •	"Edit: {new content}"
 * •	"ChangeAuthor: {new author}"
 * •	"Rename: {new title}"
 * 
 * In the end, print the final state of the article.
 * 
 * INPUT
 * some title, some content, some author
 * 3
 * Edit: better content
 * ChangeAuthor:  better author
 * Rename: better title
 * 
 * OUTPUT
 * better title - better content: better author
 * 
 * INPUT
 * Fight club, love story, Martin Scorsese
 * 2
 * Edit: underground fight club that evolves into much more
 * ChangeAuthor: Chuck Palahniuk
 * 
 * OUTPUT
 * Fight club - underground fight club that evolves into much more: Chuck Palahniuk
 * 
 */