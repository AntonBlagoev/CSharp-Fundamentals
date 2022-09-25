using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articleList = new List<Article>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] inputArr = Console.ReadLine().Split(", ");
                var article = new Article(inputArr[0], inputArr[1], inputArr[2]);
                articleList.Add(article);
            }
            string command = Console.ReadLine();

            foreach (var article in articleList)
            {
                Console.WriteLine(article);
            }
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
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
/* Change the program from the previous problem in such a way, that you will be able to store a list of articles. 
 * You will not need to use the previous methods anymore (except the "ToString()"). 
 * On the first line, you will receive the number of articles. 
 * On the next lines, you will receive the articles in the same format as in the previous problem: "{title}, {content}, {author}". 
 * Print the articles. 
 * 
 * INPUT
 * 2
 * Science, planets, Bill
 * Article, content, Johnny
 * title
 * 
 * OUTPUT
 * Science - planets: Bill 
 * Article - content: Johnny
 * 
 * INPUT
 * 3
 * title1, C, author1
 * title2, B, author2
 * title3, A, author3
 * content
 * 
 * OUTPUT
 * title1 - C: author1
 * title2 - B: author2
 * title3 - A: author3
 * 
 * 
 */