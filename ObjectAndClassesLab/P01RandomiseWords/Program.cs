using System;

namespace P01RandomiseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int n = random.Next(input.Length);
                string temp = input[i];
                input[i] = input[n];
                input[n] = temp;

            }
                Console.WriteLine(string.Join(Environment.NewLine, input));
            /*
             Welcome to SoftUni and have fun learning programming
             */
        }
    }
}
