using System;

internal class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Operations(a, operation, b);
    }

    static void Operations(int a, char operation, int b)
    {
        switch (operation)
        {
            case '+':
                Console.WriteLine(a + b);
                break;
            case '-':
                Console.WriteLine(a - b);
                break;
            case '*':
                Console.WriteLine(a * b);
                break;
            case '/':
                Console.WriteLine(a / b);
                break;
        }
    }
}

