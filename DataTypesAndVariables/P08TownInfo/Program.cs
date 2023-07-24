using System;

namespace P08TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            int populationCount = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {cityName} has population of {populationCount} and area {area} square km.");
        }
    }
}
