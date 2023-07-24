using System;

namespace P04SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                sum += symbol;

            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
