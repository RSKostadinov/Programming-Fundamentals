using System;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int quantityOfTheProduct = int.Parse(Console.ReadLine());

        ProductPrice(input, quantityOfTheProduct);
    }

    static void ProductPrice(string input, int quantityOfTheProduct)
    {
        double price = 0;
        if (input == "coffee")
        {
            price = 1.50;
        }
        else if (input == "water")
        {
            price = 1.00;
        }
        else if (input == "coke")
        {
            price = 1.40;
        }
        else if (input == "snacks")
        {
            price = 2.00;
        }

        Console.WriteLine($"{(price * quantityOfTheProduct):F2}");
    }
}
