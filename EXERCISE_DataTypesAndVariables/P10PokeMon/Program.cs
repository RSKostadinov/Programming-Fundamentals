using System;

namespace P10PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           int m = int.Parse(Console.ReadLine());
           int y = int.Parse(Console.ReadLine());

            int originalN = n;
            int targetCount = 0;

            while (n >= m)
            {
                n -= m;
                targetCount++;

                double percent = originalN * 0.5d;
                if (percent == n & y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(targetCount);
        }
    }
}
