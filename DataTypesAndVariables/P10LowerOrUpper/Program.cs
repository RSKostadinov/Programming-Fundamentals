using System;

namespace P10LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());

            bool isUpper =Char.IsUpper(n);

            if (isUpper)
            {
                Console.WriteLine("upper-case");
            }
            else 
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
