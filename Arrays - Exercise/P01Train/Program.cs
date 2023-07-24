using System;
using System.Linq;

namespace P01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonsCount];


            for (int i = 0; i < wagons.Length; i++)
            {
               int passengers = int.Parse(Console.ReadLine());
                wagons[i] = passengers;

            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(wagons.Sum());

            int x = wagons.Length;
            Console.WriteLine(x);
        }
    }
}
