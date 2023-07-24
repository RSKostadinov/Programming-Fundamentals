using System;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        TriangleFirstLine(n);
    }
    static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void TriangleFirstLine(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            PrintLine(1, i);
        }

        for (int i = n - 1; i >= 1; i--)
        {
            PrintLine(1, i);
        }
    }

}

