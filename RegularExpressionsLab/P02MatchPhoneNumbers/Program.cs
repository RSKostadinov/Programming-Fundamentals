using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02MatchPhoneNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regEx = @"";

            var phoneNumbers = Console.ReadLine();

            var phoneMatches = Regex.Matches(phoneNumbers, regEx);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
