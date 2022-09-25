using System;
using System.Collections.Generic;
using System.Text;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            StringBuilder comments = new StringBuilder();
            comments.AppendLine("<h1>");
            comments.AppendLine(title);
            comments.AppendLine("</h1>");
            comments.AppendLine("<article>");
            comments.AppendLine(content);
            comments.AppendLine("</article>");

            while (true)
            {
                string comment = Console.ReadLine();
                if (comment == "end of comments")
                {
                    break;
                }
                comments.AppendLine("<div>");
                comments.AppendLine(comment);
                comments.AppendLine("</div>");
            }
            Console.WriteLine(string.Join(Environment.NewLine, comments));

        }
    }
}

/* You will receive 3 lines of input. On the first line you will receive a title of an article. 
 * On the next line you will receive the content of that article. 
 * On the next n lines, until you receive "end of comments", you will get the comments about the article. 
 * Print the whole information in HTML format. 
 * The title should be in h1 tag (<h1></h1>); the content in article tag (<article></article>); each comment should be in div tag (<div></div>). 
 * For more clarification see the example below.
 * 
 * Input
 * SoftUni Article
 * Some content of the SoftUni article
 * some comment
 * more comment
 * last comment
 * end of comments
 * 
 * Output
 * <h1>
 * SoftUni Article
 * </h1>
 * <article>
 * Some content of the SoftUni article
 * </article>
 * <div>
 * some comment
 * </div>
 * <div>
 * more comment
 * </div>
 * <div>
 * last comment
 * </div>
 * 
 * 
 * 
 */
