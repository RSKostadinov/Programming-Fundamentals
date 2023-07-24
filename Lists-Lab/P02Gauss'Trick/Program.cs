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

        int interations = numbers.Count / 2;

        for (int i = 0; i < interations; i++)
        {
            numbers[i] += numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

