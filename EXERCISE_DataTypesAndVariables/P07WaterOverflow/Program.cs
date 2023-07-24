using System;

namespace P07WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                num += liters;
                if ( num > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    num -= liters;

                }           
            }
            Console.WriteLine(num);
        }
    }
}
