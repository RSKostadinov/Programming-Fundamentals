using System;

namespace P11ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Numbers(a, b, c);
        }

        static void Numbers(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}

