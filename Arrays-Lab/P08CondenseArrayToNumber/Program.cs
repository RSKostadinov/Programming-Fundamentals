using System;
using System.Globalization;
using System.Linq;

namespace P08CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int n = 0; n < numbers.Length - 1; n++)
                {
                    numbers[n] += numbers[n + 1];
                } 
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
