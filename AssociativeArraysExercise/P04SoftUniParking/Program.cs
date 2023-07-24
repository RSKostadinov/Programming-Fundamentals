using System;
using System.Collections.Generic;

/*
5
register John CS1234JS
register George JAVA123S
register Andy AB4142CD
register Jesica VR1223EE
unregister Andy

4
register Jony AA4132BB
register Jony AA4132BB
register Linda AA9999BB
unregister Jony

6
register Jacob MM1111XX
register Anthony AB1111XX
unregister Jacob
register Joshua DD1111XX
unregister Lily
register Samantha AA9999BB
*/
class User
{

    public User(string userName, string licensePlateNumber)
    {
        UserName = userName;
        LicensePlateNumber = licensePlateNumber;
    }

    public string UserName { get; set; }

    public string LicensePlateNumber { get; set; }

    public override string ToString()
    {
        return $"{UserName} => {LicensePlateNumber}";
    }

}
internal class Program
{
    static void Main()
    {
        Dictionary<string, User> database = new Dictionary<string, User>();

        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            string[] arguments = Console.ReadLine().Split();
            string command = arguments[0];
            string userName = arguments[1];

            switch (command)
            {
                case "register":
                    string licensePlateNumber = arguments[2];
                    User newUser = new User(userName, licensePlateNumber);

                    if (!database.ContainsKey(newUser.UserName))
                    {
                        database.Add(newUser.UserName, newUser);
                        Console.WriteLine($"{newUser.UserName} registered {newUser.LicensePlateNumber} successfully");
                    }
                    else
                    {
                        User foundUser = database[newUser.UserName];
                        Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlateNumber}");
                    }
                    break;
                case "unregister":

                    if (database.ContainsKey(userName))
                    {
                        database.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }

                    break;

            }
        }

        foreach (var kvp in database)
        {
            Console.WriteLine(kvp.Value);
        }
    }
}

