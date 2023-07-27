
internal class Program
{
    static void Main()
    {
        string encryptedMessage = Console.ReadLine();

        string line;
        while ((line = Console.ReadLine()) != "Decode")
        {
            string[] lineTokens = line.Split("|");
            string command = lineTokens[0];

            if (command == "Insert")
            {
                int indexToInsert = int.Parse(lineTokens[1]);
                string valueToInsert = lineTokens[2];
                encryptedMessage = encryptedMessage.Insert(indexToInsert, valueToInsert);
            }
            else if (command == "ChangeAll")
            {
                string stringToBeReplaced = lineTokens[1];
                string replacement = lineTokens[2];
                encryptedMessage = encryptedMessage.Replace(stringToBeReplaced, replacement);
            }
            else if (command == "Move")
            {
                int countOfLetters = int.Parse(lineTokens[1]);
                string temp = encryptedMessage.Substring(0, countOfLetters);
                encryptedMessage = encryptedMessage.Remove(0, countOfLetters);
                encryptedMessage = encryptedMessage + temp;
            }
        }

        Console.WriteLine($"The decrypted message is: {encryptedMessage}");
    }
}
