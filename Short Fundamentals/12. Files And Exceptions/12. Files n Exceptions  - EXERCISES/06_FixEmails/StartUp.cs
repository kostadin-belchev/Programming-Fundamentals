namespace _06_FixEmails
{
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"Text files\Input.txt");
            var indexer = 0;
            string name = input[indexer++];

            var emails = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = input[indexer++];

                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    emails[name] = email;
                }
                name = input[indexer++];
            }

            var emailsOutput = new List<string>();

            foreach (var person in emails)
            {
                emailsOutput.Add($"{person.Key} -> {person.Value}");
            }

            File.WriteAllLines(@"Text files\Output.txt", emailsOutput);
        }
    }
}
