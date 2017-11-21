namespace _05_MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var matchedNums = Regex.Matches(input, pattern);

            foreach (Match num in matchedNums)
            {
                Console.Write($"{num.Value} ");
            }
            Console.WriteLine();
        }
    }
}
