using System;

namespace P02SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int hold;
            int sum = 0;

            while (n > 0)
            {
                hold = n % 10;
                n /= 10;
                sum += hold;
            }
            Console.WriteLine(sum);
        }
    }
}
