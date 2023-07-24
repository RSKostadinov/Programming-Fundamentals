using System;
using System.Linq;

namespace P07EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                int currentNumberFor1Array = array1[i];
                sum1 += currentNumberFor1Array;
                int currentNumberFor2Array = array2[i];
                sum2 += currentNumberFor2Array;

                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }

            }
                if (sum1 == sum2)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum1}");
                }
        }
    }
}
