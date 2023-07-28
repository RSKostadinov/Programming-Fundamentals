using System;
using System.Collections.Generic;
using System.Linq;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<string> chat = new List<string>();

            while (command != "end")
            {
                List<string> input = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string action = input[0];

                string message = input[1];


                if (action == "Chat")
                {
                    chat.Add(message);
                }
                else if (action == "Delete")
                {
                    if (chat.Contains(message))
                    {
                        chat.Remove(message);
                    }
                }
                else if (action == "Edit")
                {
                    if (chat.Contains(message))
                    {
                        string editedMessage = input[2];

                        int indexOfMessage = chat.IndexOf(message);

                        chat.RemoveAt(indexOfMessage);

                        chat.Insert(indexOfMessage, editedMessage);
                    }
                }
                else if (action == "Pin")
                {
                    if (chat.Contains(message))
                    {
                        int indexOfTheMessage = chat.IndexOf(message);

                        chat.RemoveAt(indexOfTheMessage);

                        chat.Add(message);
                    }
                }
                else if (action == "Spam")
                {
                    input.Remove("Spam");

                    foreach (var item in input)
                    {
                        chat.Add(item);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var message in chat)
            {
                Console.WriteLine(message);
            }
        }
    }
}
