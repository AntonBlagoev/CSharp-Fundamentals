using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatList = new List<string>();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "end")
                {
                    break;
                }

                if (commands[0] == "Chat")
                {
                    string message = commands[1];
                    chatList.Add(message);
                }

                else if (commands[0] == "Delete")
                {
                    string message = commands[1];
                    if (chatList.Contains(message))
                    {
                        chatList.Remove(message);
                    }
                }
                else if (commands[0] == "Edit")
                {
                    string message = commands[1];
                    string editedVersion = commands[2];

                    if (chatList.Contains(message))
                    {
                        int index = chatList.IndexOf(message);
                        chatList.Insert(index, editedVersion);
                        chatList.RemoveAt(index + 1);
                    }
                }
                else if (commands[0] == "Pin")
                {
                    string message = commands[1];
                    if (chatList.Contains(message))
                    {
                        chatList.Remove(message);
                        chatList.Add(message);
                    }
                }
                else if (commands[0] == "Spam")
                {
                    ;
                    for (int i = 1; i < commands.Count; i++)
                    {
                        string message = commands[i];
                        chatList.Add(message);
                    }
                }

            }

            for (int i = 0; i < chatList.Count; i++)
            {
                Console.WriteLine(chatList[i]);
            }
        }
    }
}
