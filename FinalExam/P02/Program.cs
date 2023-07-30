using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> inputs = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            inputs.Add(input);
        }

        foreach (string input in inputs)
        {
            if (IsValidPassword(input, out string encryptedPassword))
            {
                Console.WriteLine("Password: " + encryptedPassword);
            }
            else
            {
                Console.WriteLine("Try another password!");
            }
        }
    }

    public static bool IsValidPassword(string input, out string encryptedPassword)
    {
        encryptedPassword = string.Empty;

        string pattern = @"^([^<>]+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1$";
        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            string numbersGroup = match.Groups[2].Value;
            string lowerCaseLettersGroup = match.Groups[3].Value;
            string upperCaseLettersGroup = match.Groups[4].Value;
            string symbolsGroup = match.Groups[5].Value;

            encryptedPassword = numbersGroup + lowerCaseLettersGroup + upperCaseLettersGroup + symbolsGroup;
            return true;
        }

        return false;
    }
}