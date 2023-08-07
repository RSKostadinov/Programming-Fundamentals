using System;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int resultOfTheFirstTwoIntegers = Add(n, m);
        int finalResult = Substract(p, resultOfTheFirstTwoIntegers);
        Console.WriteLine(finalResult);
    }
    public static int Add(int n, int m)
    {
        int resultOfTheFirstTwoIntegers = n + m;
        return resultOfTheFirstTwoIntegers;
    }
    public static int Substract(int p, int result)
    {
        int finalResult = result - p;
        return finalResult;
    }
}
