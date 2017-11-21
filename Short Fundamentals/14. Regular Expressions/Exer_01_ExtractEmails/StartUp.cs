namespace Exer_01_ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
             .Split(' ')
             .ToArray();

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";

            var emailsList = new List<string>();

            foreach (var word in input)
            {
                bool isDigit = word[0] >= 48 && word[0] <= 57;
                bool isUpperCase = word[0] >= 65 && word[0] <= 90;
                bool isLowerCase = word[0] >= 97 && word[0] <= 122;

                if (isDigit || isUpperCase || isLowerCase)
                {
                    string result = word.TrimEnd('.', ',', '!', '?', ':', '…');
                    var matchedEmail = Regex.Match(result, pattern);

                    if (matchedEmail.ToString() != string.Empty)
                    {
                        emailsList.Add(matchedEmail.ToString());
                    }
                }
            }

            foreach (var email in emailsList)
            {
                Console.WriteLine(email);
            }
        }
    }
}
