using System;
using System.Linq;

namespace P02CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                    {
                        Console.Write($"{arrayOne[i]} ");
                    }
                } 
            }
        }
    }
}
