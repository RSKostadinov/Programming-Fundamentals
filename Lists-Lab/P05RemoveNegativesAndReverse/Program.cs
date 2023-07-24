using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> result = new List<int>();

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                result.Add(number);
            }
        }

        if (result.Count != 0)
        { 
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}

