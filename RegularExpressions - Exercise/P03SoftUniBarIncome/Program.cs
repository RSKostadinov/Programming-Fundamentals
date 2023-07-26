
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        List<Order> orderList = new List<Order>();

        string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+|\d+\.\d+)\$";

        decimal income = 0m;

        string input;
        while ((input = Console.ReadLine()) != "end of shift")
        {


            foreach (Match match in Regex.Matches(input, pattern))
            {
                Order order = new Order();
                order.Customer = match.Groups["name"].Value;
                order.Product = match.Groups["product"].Value;
                order.Count = uint.Parse(match.Groups["quantity"].Value);
                order.Price = decimal.Parse(match.Groups["price"].Value);

                Console.WriteLine($"{order.Customer}: {order.Product} - {order.Total():F2}");

                income += order.Total();
            }

        }
        Console.WriteLine($"Total income: {income:F2}");
    }
}

class Order
{
    public string Customer { get; set; }

    public string Product { get; set; }

    public uint Count { get; set; }

    public decimal Price { get; set; }

    public decimal Total()
    {
        return Price * Count;
    }
}
