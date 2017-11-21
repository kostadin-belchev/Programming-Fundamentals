namespace _03_MatchHexNums
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var hexnumMatches = Regex.Matches(input, pattern);

            var validHex = hexnumMatches
                .Cast<Match>()
                .Select(hex => hex.Value)
                .ToArray();

            Console.WriteLine(String.Join(" ", validHex));
        }
    }
}
