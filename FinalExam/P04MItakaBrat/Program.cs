using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        string pattern = @"|(?<power>[A-Z]{4,})|:#(?<durability>[A-Za-z]+ [A-Za-z]+)#";
        Regex regex = new Regex(pattern);

        for (int i = 0; i < num; i++)
        {
            string command = Console.ReadLine();
            Match matches = regex.Match(command);

            if (matches.Success)
            {
                string name = matches.Groups["power"].Value;
                string title = matches.Groups["durability"].Value;
                int power = name.Length;
                int durability = title.Length;

                Console.WriteLine($"{name}, The {title}\n>> Strength: {power}\n>> Armor: {durability}");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}