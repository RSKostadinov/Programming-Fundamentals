
using System.Text;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string output = ProcessExprolions(input);
        Console.WriteLine(output);
    }

    private static string ProcessExprolions(string input)
    {
        StringBuilder sb = new StringBuilder();
        int strength = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '>')
            {
                sb.Append(input[i]);
                strength += int.Parse(input[i + 1].ToString());
            }
            else if (strength == 0)
            {
                sb.Append(input[i]);
            }
            else
            {
                strength--;
            }
        }
        return sb.ToString();
    }
}