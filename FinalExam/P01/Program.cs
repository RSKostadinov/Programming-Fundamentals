namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Abracadabra")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Abjuration":
                        spell = spell.ToUpper();
                        Console.WriteLine(spell);
                        break;
                    case "Necromancy":
                        spell = spell.ToLower();
                        Console.WriteLine(spell);
                        break;
                    case "Illusion":
                        int index = int.Parse(command[1]);
                        char letter = command[2][0];

                        if (index >= 0 && index < spell.Length)
                        {
                            char[] spellArray = spell.ToCharArray();
                            spellArray[index] = letter;
                            spell = new string(spellArray);
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;
                    case "Divination":
                        string firstSubstring = command[1];
                        string secondSubstring = command[2];

                        if (spell.Contains(firstSubstring))
                        {
                            spell = spell.Replace(firstSubstring, secondSubstring);
                            Console.WriteLine(spell);
                        }
                        else
                        {
                            Console.WriteLine("The spell did not work!");
                        }
                        break;
                    case "Alteration":
                        string substringToRemove = command[1];

                        if (spell.Contains(substringToRemove))
                        {
                            spell = spell.Replace(substringToRemove, "");
                            Console.WriteLine(spell);
                        }
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
            }
        }
    }
}