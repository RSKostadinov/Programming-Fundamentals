using System;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        PrintMiddleCharacter(input);
    }
    public static void PrintMiddleCharacter(string input)
    {
        int length = input.Length;
        int middleIndex = length / 2;

        if (length % 2 == 0)
        {
            char middleChar1 = input[middleIndex - 1];
            char middleChar2 = input[middleIndex];
            Console.WriteLine($"{middleChar1}{middleChar2}");
        }
        else
        {
            char middleChar = input[middleIndex];
            Console.WriteLine(middleChar);
        }
    }
}




