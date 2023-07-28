
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<word>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))(?<mirror>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))";

        List<string> mirrors = new List<string>();
        int pairCount = 0;

        foreach (Match m in Regex.Matches(input, pattern))
        {
            string word = m.Groups["word"].Value;
            string mirror = m.Groups["mirror"].Value;

            if (word[0] == word[word.Length - 1]&&
                word[0] == mirror[0] &&
                word[0] == mirror[mirror.Length - 1])
            {
                pairCount++;

                var mirrored = new string(mirror.Reverse().ToArray());

                if (word == mirrored)
                {
                    string cleanPattern = @"(?:\@|\#)";
                    string cleanFirstWord = Regex.Replace(word, cleanPattern, "");
                    string cleanSecondWord = Regex.Replace(mirror, cleanPattern, "");

                    mirrors.Add($"{cleanFirstWord} <=> {cleanSecondWord}");
                }
            }
        }

        if (pairCount == 0)
        {
            Console.WriteLine("No word pairs found!");
        }
        else
        {
            Console.WriteLine($"{pairCount} word pairs found!");
        }
        if (mirrors.Count > 0)
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", mirrors));
        }
        else
        {
            Console.WriteLine("No mirror words!");
        }
    }
}
