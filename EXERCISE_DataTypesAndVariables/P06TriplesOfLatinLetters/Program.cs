using System;

namespace P06TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n-1; j++)
                {
                    for (int k = 0; k <= n-1; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
