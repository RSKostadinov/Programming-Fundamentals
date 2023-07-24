using System;

namespace P07MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int bestCount = 0;
            string bestCountSymbol = "";
            for (int i = 0; i < input.Length; i++)
            {
                int count = 0;
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                        if (bestCount < count)
                        {
                            bestCount = count;
                            bestCountSymbol = input[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{bestCountSymbol} ");
            }
        }
    }
}
 