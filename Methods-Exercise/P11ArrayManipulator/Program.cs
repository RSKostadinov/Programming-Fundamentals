using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] tokens = input.Split();
            string command = tokens[0];

            switch (command)
            {
                case "exchange":
                    int index = int.Parse(tokens[1]);
                    Exchange(numbers, index);
                    break;
                case "max":
                case "min":
                    string type = tokens[1];
                    int resultIndex = FindMaxMinIndex(numbers, type, command);
                    PrintResultIndex(resultIndex);
                    break;
                case "first":
                case "last":
                    int count = int.Parse(tokens[1]);
                    type = tokens[2];
                    PrintFirstLastNumbers(numbers, count, type);
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    public static void Exchange(List<int> numbers, int index)
    {
        if (index < 0 || index >= numbers.Count)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        List<int> firstPart = numbers.GetRange(0, index + 1);
        List<int> secondPart = numbers.GetRange(index + 1, numbers.Count - index - 1);

        numbers.Clear();
        numbers.AddRange(secondPart);
        numbers.AddRange(firstPart);
    }

    public static int FindMaxMinIndex(List<int> numbers, string type, string command)
    {
        int remainder = type == "even" ? 0 : 1;
        int resultIndex = -1;
        int initialValue = command == "max" ? int.MinValue : int.MaxValue;

        for (int i = 0; i < numbers.Count; i++)
        {
            int number = numbers[i];
            if (number % 2 == remainder && ((command == "max" && number >= initialValue) || (command == "min" && number <= initialValue)))
            {
                resultIndex = i;
                initialValue = number;
            }
        }

        return resultIndex;
    }

    public static void PrintFirstLastNumbers(List<int> numbers, int count, string type)
    {
        int remainder = type == "even" ? 0 : 1;

        if (count > numbers.Count || count <= 0)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        List<int> result = numbers
            .Where(n => n % 2 == remainder)
            .Take(count)
            .ToList();

        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    public static void PrintResultIndex(int resultIndex)
    {
        if (resultIndex != -1)
        {
            Console.WriteLine(resultIndex);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}
