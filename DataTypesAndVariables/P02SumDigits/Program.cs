using System;

namespace P02PoundsToDollars

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double currency = double.Parse(Console.ReadLine()) * 1.31;

            Console.WriteLine($"{currency:F3}");
        }
       
    }
}
