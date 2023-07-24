using System;

namespace P01ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine()) * 0.001;
            Console.WriteLine($"{meters:F2}");
        }
    }
}
