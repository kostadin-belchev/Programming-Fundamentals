namespace _01_MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+[' '][A-Z][a-z]+\b";

            MatchCollection matchedNames = Regex.Matches(input, pattern);

            foreach (Match name in matchedNames)
            {
                Console.Write($"{name} ");
            }

            Console.WriteLine();
        }
    }
}
