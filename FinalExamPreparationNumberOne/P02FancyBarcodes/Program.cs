using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string productGroup = GetProductGroup(input);

            if (IsValidBarcode(input))
            {
                Console.WriteLine($"Product group: {productGroup}");
            }
            else
            {
                Console.WriteLine("Invalid barcode");
            }
        }

        static bool IsValidBarcode(string input)
        {
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";

            return Regex.IsMatch(input, pattern);

        }
        static string GetProductGroup(string input)
        {
            string onlyDigitsFromBarcode = Regex.Replace(input, @"[^0-9]", "");
            return onlyDigitsFromBarcode.Length > 0 ? onlyDigitsFromBarcode : "00";
        }
    }
}
