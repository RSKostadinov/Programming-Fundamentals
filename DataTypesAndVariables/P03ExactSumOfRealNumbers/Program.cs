using System;

namespace P03ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal p = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal m = decimal.Parse(Console.ReadLine());
                p += m;
            }

            Console.WriteLine(p);
        }
    }
}
