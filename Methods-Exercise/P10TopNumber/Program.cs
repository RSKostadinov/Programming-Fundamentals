using System;

public class Program
{
    public static bool IsTopNumber(int number)
    {
        // Check if the sum of digits is divisible by 8
        int sumOfDigits = 0;
        int tempNumber = number;
        while (tempNumber > 0)
        {
            sumOfDigits += tempNumber % 10;
            tempNumber /= 10;
        }

        if (sumOfDigits % 8 == 0)
        {
            // Check if it contains at least one odd digit
            tempNumber = number;
            while (tempNumber > 0)
            {
                int digit = tempNumber % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                tempNumber /= 10;
            }
        }

        return false;
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (IsTopNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}
