using System;

namespace P01IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int sum = a + b;
            int div = sum / c;
            int mult = div * d;

            Console.WriteLine(mult);
        }
    }
}
