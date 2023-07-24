using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "int":
                int int1 = int.Parse(Console.ReadLine());
                int int2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(int1, int2));
                break;
            case "char":
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(char1, char2));
                break;
            case "string":
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                Console.WriteLine(GetMax(str1, str2));
                break;

        }
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }

    static char GetMax(char a, char b)
    {
        return (a > b) ? a : b;
    }

    static string GetMax(string a, string b)
    {
        return (string.Compare(a, b) > 0) ? a : b;
    }
}