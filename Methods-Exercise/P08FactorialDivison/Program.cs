using System;
using System.Numerics;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        decimal divisionResult = Factorials(n, m);

        Console.WriteLine($"{divisionResult:F2}");
    }

    public static decimal Factorials(int n, int m)
    {
        BigInteger result1 = 1;
        BigInteger result2 = 1;

        for (int i = 2; i <= n; i++)
        {
            result1 *= i;
        }

        for (int i = 2; i <= m; i++)
        {
            result2 *= i;
        }

        return (decimal)result1 / (decimal)result2;
    }
}
