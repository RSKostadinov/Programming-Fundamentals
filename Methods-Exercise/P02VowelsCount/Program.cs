using System;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int vowelsCount = 0;

        VowelsCounter(input, vowelsCount);
    }

    static void VowelsCounter(string input, int vowelsCount)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
            {
                vowelsCount++;
            }
            else if (input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
            {
                vowelsCount++;
            }
        }

        Console.WriteLine(vowelsCount);
    }
}

