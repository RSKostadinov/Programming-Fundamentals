using System;
using System.Collections.Generic;
using System.Linq;

namespace MeP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> input = command
                    .Split()
                    .ToList();

                string action = input[0];
                string message = input[1];

                if (action == "Chat")
                {
                    list.Add(message);
                }

                else if (action == "Delete")
                {
                    if (list.Contains(message))
                    {
                        list.Remove(message);
                    }
                }

                else if (action == "Edit")
                {
                    if (list.Contains(message))
                    {
                        string editedMessage = input[2];
                        int indexOfMessage = list.IndexOf(message);

                        list.RemoveAt(indexOfMessage);
                        list.Insert(indexOfMessage, editedMessage);
                    }
                }

                else if (action == "Pin")
                {
                    if (list.Contains(message))
                    {
                        int indexOfMessage = list.IndexOf(message);

                        list.RemoveAt(indexOfMessage);
                        list.Add(message);
                    }
                }
                else if (action == "Spam")
                {
                    input.Remove("Spam");

                    foreach (var item in input)
                    {
                        list.Add(item);
                    }
                }
            }

            foreach (var message in list)
            {
                Console.WriteLine(message);
            }
        }
    }
}
