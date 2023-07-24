using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> secondList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int iterations = Math.Max(firstList.Count, secondList.Count);

        for (int i = 0; i < iterations; i++)
        {
            if (i < firstList.Count)
            {
                Console.Write(firstList[i] + " ");
            }
            if (i < secondList.Count)
            {
                Console.Write(secondList[i] + " ");
            }
        }
    }
}

