class Program
{
    static void Main()
    {
        Dictionary<string, Heroes> heroesDict = new Dictionary<string, Heroes>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] arguments = Console.ReadLine().Split();
            string name = arguments[0];
            int healthPoints = int.Parse(arguments[1]);
            int manaPoints = int.Parse(arguments[2]);

            if (healthPoints > 100)
                healthPoints = 100;
            if (manaPoints > 200)
                manaPoints = 200;

            heroesDict.Add(name, new Heroes(name, healthPoints, manaPoints));
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split(" - ");
            string command = arguments[0];
            string name = arguments[1];

            switch (command)
            {
                case "CastSpell":
                    int manaNeeded = int.Parse(arguments[2]);
                    string spellName = arguments[3];
                    if (heroesDict.TryGetValue(name, out Heroes hero) && hero.ManaPoints >= manaNeeded)
                    {
                        hero.ManaPoints -= manaNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                    break;
                case "TakeDamage":
                    int damageTaken = int.Parse(arguments[2]);
                    string attacker = arguments[3];
                    if (heroesDict.TryGetValue(name, out Heroes damagedHero))
                    {
                        if ((damagedHero.HealthPoints - damageTaken) > 0)
                        {
                            damagedHero.HealthPoints -= damageTaken;
                            Console.WriteLine($"{name} was hit for {damageTaken} HP by {attacker} and now has {damagedHero.HealthPoints} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                            heroesDict.Remove(name);
                        }
                    }
                    break;
                case "Recharge":
                    int amountOfManaRecieved = int.Parse(arguments[2]);
                    if (heroesDict.TryGetValue(name, out Heroes rechargedHero))
                    {
                        int currentMana = rechargedHero.ManaPoints;
                        int totalMana = currentMana + amountOfManaRecieved;
                        if (totalMana > 200)
                        {
                            rechargedHero.ManaPoints = 200;
                            Console.WriteLine($"{name} recharged for {200 - currentMana} MP!");
                        }
                        else
                        {
                            rechargedHero.ManaPoints += amountOfManaRecieved;
                            Console.WriteLine($"{name} recharged for {amountOfManaRecieved} MP!");
                        }
                    }
                    break;
                case "Heal":
                    int amountOfHealthRecieved = int.Parse(arguments[2]);
                    if (heroesDict.TryGetValue(name, out Heroes healedHero))
                    {
                        int currentHealth = healedHero.HealthPoints;
                        int totalHealth = currentHealth + amountOfHealthRecieved;
                        if (totalHealth > 100)
                        {
                            healedHero.HealthPoints = 100;
                            Console.WriteLine($"{name} healed for {100 - currentHealth} HP!");
                        }
                        else
                        {
                            healedHero.HealthPoints += amountOfHealthRecieved;
                            Console.WriteLine($"{name} healed for {amountOfHealthRecieved} HP!");
                        }
                    }
                    break;
            }
        }

        foreach (Heroes hero in heroesDict.Values)
        {
            Console.WriteLine(hero.HeroName);
            Console.WriteLine($"  HP: {hero.HealthPoints}");
            Console.WriteLine($"  MP: {hero.ManaPoints}");
        }
    }
}

class Heroes
{
    public Heroes(string heroName, int healthPoints, int manaPoints)
    {
        HeroName = heroName;
        HealthPoints = healthPoints;
        ManaPoints = manaPoints;
    }

    public string HeroName { get; private set; }
    public int HealthPoints { get; set; }
    public int ManaPoints { get; set; }
}