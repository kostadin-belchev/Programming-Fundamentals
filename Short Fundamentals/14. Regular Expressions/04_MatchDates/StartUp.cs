namespace _04_MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b(\d{2})(.|\/|-)([A-Z][a-z]{2})\2(\d{4})\b";

            var dateMatches = Regex.Matches(input, pattern);

            foreach (Match matchedDate in dateMatches)
            {
                var day = matchedDate.Groups[1];
                var month = matchedDate.Groups[3];
                var year = matchedDate.Groups[4];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
