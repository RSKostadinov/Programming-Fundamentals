using System;

namespace P08BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            string biggestKegModel = "";
            double biggestKegVolume = 0;

            for (int i = 0; i < kegsCount; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;

                if (biggestKegVolume < volume)
                {
                    biggestKegModel = model;
                    biggestKegVolume = volume;
                }
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
