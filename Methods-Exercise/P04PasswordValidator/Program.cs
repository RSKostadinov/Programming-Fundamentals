using System;

public class PasswordValidator
{
    public static bool IsLengthValid(string password)
    {
        return password.Length >= 6 && password.Length <= 10;
    }

    public static bool ContainsOnlyLettersAndDigits(string password)
    {
        foreach (char c in password)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    public static bool ContainsAtLeastTwoDigits(string password)
    {
        int digitCount = 0;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }
        return digitCount >= 2;
    }

    public static void Main()
    {
        string password = Console.ReadLine();

        bool isLengthValid = IsLengthValid(password);
        bool containsOnlyLettersAndDigits = ContainsOnlyLettersAndDigits(password);
        bool containsAtLeastTwoDigits = ContainsAtLeastTwoDigits(password);

        if (!isLengthValid)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }

        if (!containsOnlyLettersAndDigits)
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }

        if (!containsAtLeastTwoDigits)
        {
            Console.WriteLine("Password must have at least 2 digits");
        }

        if (isLengthValid && containsOnlyLettersAndDigits && containsAtLeastTwoDigits)
        {
            Console.WriteLine("Password is valid");
        }
    }
}
