using System;

internal class Program
{
    static void Main()
    {
        char startChar = char.Parse(Console.ReadLine());
        char endChar = char.Parse(Console.ReadLine());
        CharacterPrinter printer = new CharacterPrinter();
        printer.PrintCharactersInRange(startChar, endChar);
    }

}
public class CharacterPrinter
{
    public void PrintCharactersInRange(char firstChar, char lastChar)
    {
        if (firstChar > lastChar)
        {
            char temp = firstChar;
            firstChar = lastChar;
            lastChar = temp;
        }

        int firstAscii = (int)firstChar;
        int lastAscii = (int)lastChar;

        for (int i = firstAscii + 1; i < lastAscii; i++)
        {
            char currentChar = (char)i;
            Console.Write(currentChar + " ");
        }
    }
}

