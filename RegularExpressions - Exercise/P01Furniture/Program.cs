using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        List<Furniture> furnitures = new List<Furniture>();

        string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";

        string input;
        while ((input = Console.ReadLine()) != "Purchase")
        {
            Regex r = new Regex(pattern);
            MatchCollection collection = r.Matches(input);

            foreach (Match match in collection)
            {
                string name = match.Groups["name"].Value;
                decimal price = decimal.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                Furniture f = new Furniture(name, price, quantity);
                furnitures.Add(f);
            }

        }
        Console.WriteLine("Bought furniture:");
        decimal totalSpend = 0m;
        foreach (Furniture furniture in furnitures)
        {
            Console.WriteLine(furniture.Name);
            totalSpend += furniture.Total();
        }
        Console.WriteLine($"Total money spend: {totalSpend:F2}");
    }
}

class Furniture
{
    public Furniture(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal Total()
    {
        return Price * Quantity;
    }

}