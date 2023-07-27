
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int defaultProductGroup = 00;

        bool isDigitInBarcode = false;

        string pattern = @"@#+[A-Za-z0-9A-Z]+@#+";

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                if (match.Groups)
                {

                }
            }

        }
    }
}
