namespace _06_ReplaceATag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var inputHTML = Console.ReadLine();
            var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";

            var result = new List<string>();


            while (inputHTML != "end")
            {
                bool containsValidTag = Regex.IsMatch(inputHTML, pattern);

                if(!containsValidTag)
                {
                    result.Add(inputHTML);
                }
                else
                {
                    string replacePattern = @"[URL href=$1]$2[/URL]";
                    string replaced = Regex.Replace(inputHTML, 
                        pattern, replacePattern);
                    result.Add(replaced);
                }

                inputHTML = Console.ReadLine();
            }

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}
