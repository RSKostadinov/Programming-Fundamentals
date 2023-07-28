
class Town
{
    public Town(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public uint Population { get; set; }
    public uint Gold { get; set; }

    public override string ToString()
    {
        return $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
    }
}


internal class Program
{
    static Dictionary<string, Town> towns = new Dictionary<string, Town>();

    static void Main()
    {
        // Target Cities
        string input;
        while ((input = Console.ReadLine()) != "Sail")
        {
            string[] arguments = input.Split("||");
            string name = arguments[0];
            uint population = uint.Parse(arguments[1]);
            uint gold = uint.Parse(arguments[2]);

            if (!towns.ContainsKey(name))
            {
                towns.Add(name, new Town(name));
            }

            towns[name].Population += population;
            towns[name].Gold += gold;
        }

        // Process Events
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split("=>");
            string command = arguments[0];
            string town = arguments[1];
            uint gold;

            switch (command)
            {
                case "Plunder":
                    uint killed = uint.Parse(arguments[2]);
                    gold = uint.Parse(arguments[3]);
                    Plunder(town, killed, gold);
                    break;
                case "Prosper":
                    int possibleNegative = int.Parse(arguments[2]);
                    if (possibleNegative >= 0)
                    {
                        gold = (uint)possibleNegative;
                        Prosper(town, gold);
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }

                    break;
            }
        }

        if (towns.Any())
        {
            Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
            foreach (Town town in towns.Values)
            {
                Console.WriteLine(town);
            }
        }
        else
        {
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }
    }

    private static void Prosper(string townName, uint gold)
    {
        if (towns.ContainsKey(townName))
        {
            towns[townName].Gold += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {towns[townName].Gold} gold.");
        }
    }

    private static void Plunder(string townName, uint killed, uint gold)
    {
        if (towns.ContainsKey(townName))
        {
            Console.WriteLine($"{townName} plundered! {gold} gold stolen, {killed} citizens killed.");
            towns[townName].Population -= killed;
            towns[townName].Gold -= gold;

            if (towns[townName].Population <= 0 ||
                towns[townName].Gold <= 0)
            {
                towns.Remove(townName);
                Console.WriteLine($"{townName} has been wiped off the map!");
            }
        }
    }
}