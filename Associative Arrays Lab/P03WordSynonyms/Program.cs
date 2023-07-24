using System;
using System.Collections.Generic;


internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var words = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            if (!words.ContainsKey(key))
            {
                words.Add(key, new List<string>());
            }

            words[key].Add(value);

        }

        foreach (var kvp in words)
        {
            string word = kvp.Key;
            List<string> values = kvp.Value;

            string valuesString = String.Join(", ", values);

            Console.WriteLine($"{word} - {valuesString}");
        }
    }
}


