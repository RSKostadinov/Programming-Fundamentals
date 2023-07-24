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

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end")
            {
                break;
            }

            string[] tokens = line.Split();

            switch (tokens[0])
            {
                case "Contains":
                  int numberToContains = int.Parse(tokens[1]);
                  numbers.Contains(numberToContains);
                  if (numbers.Contains )
                  {
                      
                  }
                    break;
                case "PrintEven":
                    break;
                case "PrintOdd":
                    break;
                case "GetSum":
                    break;
                case "Filter":
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

