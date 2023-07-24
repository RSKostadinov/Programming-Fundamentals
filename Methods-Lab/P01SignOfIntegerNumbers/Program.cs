using System;
using System.Net.Http.Headers;

namespace P01SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            isPositiveNumber(n);
            isNegativeNumber(n);
            isNumberZero(n);

        }

        static void isPositiveNumber(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
        }

        static void isNegativeNumber(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
        }

        static void isNumberZero(int n)
        {
            if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
