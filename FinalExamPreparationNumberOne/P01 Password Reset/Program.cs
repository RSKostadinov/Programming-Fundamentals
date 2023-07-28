/*
 Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr
TakeOdd
Cut 15 3
Substitute :: -
Substitute | ^
Done

 */
using System.Text;

internal class Program
{
    static void Main()
    {
        string rawPassword = Console.ReadLine();
        StringBuilder password = new StringBuilder(rawPassword);

        string[] arguments;
        string input;
        while ((input = Console.ReadLine()) != "Done")
        {
            arguments = input.Split();
            switch (arguments[0])
            {
                case "TakeOdd":
                    password = TakeOdd(password);
                    break;
                case "Cut":
                    int startIndex = int.Parse(arguments[1]);
                    int length = int.Parse(arguments[2]);

                    password = Cut(password, startIndex, length);
                    break;
                case "Substitute":
                    string substring = arguments[1];
                    string subtitute = arguments[2];

                    password = Substitute(password, substring, subtitute);
                    break;

            }
        }
    }

    private static StringBuilder TakeOdd(StringBuilder password)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 1; i < password.Length; i += 2)
        {
            result.Append(password[i]);
        }

        Console.WriteLine(result);
        return result;
    }
    private static StringBuilder Cut(StringBuilder password, int startIndex, int length)
    {
        password = password.Remove(startIndex, length);

        Console.WriteLine(password);
        return password;
    }


    private static StringBuilder Substitute(StringBuilder password, string substring, string substitute)
    {
        string sbToStr = password.ToString();
        if (sbToStr.Contains(substring))
        {
           password = password.Replace(substring, substitute);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }


        return password;
    }
}

