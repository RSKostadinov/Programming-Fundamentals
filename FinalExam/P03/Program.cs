using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();

        string inputWords = Console.ReadLine();
        string[] wordPairs = inputWords.Split(" | ");
        foreach (var wordPair in wordPairs)
        {
            string[] parts = wordPair.Split(": ");
            string word = parts[0];
            string definition = parts[1];

            if (!notebook.ContainsKey(word))
            {
                notebook[word] = new List<string>();
            }

            notebook[word].Add(definition);
        }

        string testWords = Console.ReadLine();
        string[] wordsToTest = testWords.Split(" | ");

        string command = Console.ReadLine();

        if (command == "Test")
        {
            foreach (var wordToTest in wordsToTest)
            {
                if (notebook.ContainsKey(wordToTest))
                {
                    Console.WriteLine($"{wordToTest}:");
                    foreach (var definition in notebook[wordToTest])
                    {
                        Console.WriteLine($"-{definition}");
                    }
                }
            }
        }
        else if (command == "Hand Over")
        {
            List<string> wordsInNotebook = new List<string>(notebook.Keys);
            Console.WriteLine(string.Join(" ", wordsInNotebook));
        }
    }
}
