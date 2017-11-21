namespace Exer_02_ExtractByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            var text = Console.ReadLine();
            string pattern = $@"[^.?!]*(?<=[.?\W0-9]){keyword}(?=[0-9\W.?!])[^.?!]*[.?!]";

            var matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string output = match.Value.TrimStart(' ', '\t');
                output = output.Remove(output.Length - 1);
                Console.WriteLine(output);
            }
        }
    }
}
