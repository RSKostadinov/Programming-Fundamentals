using System;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        RepeatString(input, n);
    }

    static string RepeatString(string input, int n)
    {
        string result = "";

        for (int i = 0; i < n; i++)
        {
            result += input;
        }

        Console.WriteLine(result);
        return result;
    }
}

