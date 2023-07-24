using System;

namespace P12RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            bool toe = false;
            for (int ch = 1; ch <= count; ch++)
            {
            int number = 0;
            int theSum = 0;
                number = ch;
                while (ch > 0)
                {
                    theSum += ch % 10;
                    ch = ch / 10;
                }
                toe = (theSum == 5) || (theSum == 7) || (theSum == 11);
                Console.WriteLine("{0} -> {1}", number, toe);
                theSum = 0;
                ch = number;
            }

        }
    }
}

