using System;

public class Program
{
    public static void Main()
    {
        string concealedMessage = Console.ReadLine();
        string input;
        bool errorOccurred = false; // Initialize the error flag

        while ((input = Console.ReadLine()) != "Reveal")
        {
            string[] commandParts = input.Split(":|:");
            string command = commandParts[0];

            switch (command)
            {
                case "InsertSpace":
                    int index = int.Parse(commandParts[1]);
                    if (index >= 0 && index <= concealedMessage.Length)
                    {
                        concealedMessage = InsertSpace(concealedMessage, index);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        errorOccurred = true; // Set the error flag to true
                    }
                    break;
                case "Reverse":
                    string substring = commandParts[1];
                    if (!ReverseSubstring(ref concealedMessage, substring))
                    {
                        errorOccurred = true; // Set the error flag to true if ReverseSubstring returns false
                    }
                    break;
                case "ChangeAll":
                    string substringToChange = commandParts[1];
                    string replacement = commandParts[2];
                    concealedMessage = ChangeAllOccurrences(concealedMessage, substringToChange, replacement);
                    break;
            }

            // Print the concealed message after each command, unless an error occurred
            if (!errorOccurred)
            {
                Console.WriteLine(concealedMessage);
            }
        }

        Console.WriteLine($"You have a new text message: {concealedMessage}");
    }

    public static string InsertSpace(string message, int index)
    {
        message = message.Insert(index, " ");
        return message;
    }

    public static bool ReverseSubstring(ref string message, string substring)
    {
        int index = message.IndexOf(substring);
        if (index != -1)
        {
            int substringLength = substring.Length;
            string substringToRemove = message.Substring(index, substringLength);
            string reversedSubstring = ReverseString(substringToRemove);
            message = message.Remove(index, substringLength);
            message += reversedSubstring;
            return true;
        }
        else
        {
            Console.WriteLine("error");
            return false;
        }
    }

    public static string ChangeAllOccurrences(string message, string substring, string replacement)
    {
        message = message.Replace(substring, replacement);
        return message;
    }

    private static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
