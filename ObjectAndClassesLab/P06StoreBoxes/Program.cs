using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] arguments = input.Split(" ");

            string serialNumber = arguments[0];
            string itemName = arguments[1];
            int quantity = int.Parse(arguments[2]);
            decimal price = decimal.Parse(arguments[3]);

            Item item = new Item(itemName, price);
            Box box = new Box(serialNumber, item, quantity);
            boxes.Add(box);
        }

        foreach (Box box in boxes.OrderByDescending(x => x.PricePerBox))
        {
            Console.WriteLine($"{box.SerialNumber}");
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.PricePerBox:F2}");
        }
    }
}
class Item
{
    public Item(string itemName, decimal price)
    {
        Name = itemName;
        Price = price;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }

}
class Box
{
    public Box(string serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
    }

    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal PricePerBox
    {
        get
        {
            return Item.Price * ItemQuantity;
        }
    }
}

