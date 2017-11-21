namespace _02_MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(\b|)\+359(\s|-)2\2\d{3}\2\d{4}\b";

            var numberMatches = Regex.Matches(input, pattern);
            var validPhones = numberMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(String.Join(", ", validPhones));
        }
    }
}
