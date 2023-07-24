using System;
using System.Linq;

namespace P03ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            bool isFirstSelected = true;

            string[] firstArray = new string[count];
            string[] secondArray = new string[count];

            for (int i = 0; i < count; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersAsArray = numbers.Split();

                if (isFirstSelected)
                {
                    firstArray[i] = numbersAsArray[0];
                    secondArray[i] = numbersAsArray[1];
                }
                else
                {
                    firstArray[i] = numbersAsArray[1];
                    secondArray[i] = numbersAsArray[0];
                }

                isFirstSelected = !isFirstSelected;
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
