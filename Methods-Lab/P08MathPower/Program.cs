using System;

internal class Program
{
    static void Main()
    {
        double baseNumber = double.Parse(Console.ReadLine());
        int powerNumber = int.Parse(Console.ReadLine());

        Power(baseNumber, powerNumber);
    }

    static double Power(double baseNumber, int powerNumber)
    {

        double result = Math.Pow(baseNumber, powerNumber);
        Console.WriteLine(result);
        return result;
    }
}


