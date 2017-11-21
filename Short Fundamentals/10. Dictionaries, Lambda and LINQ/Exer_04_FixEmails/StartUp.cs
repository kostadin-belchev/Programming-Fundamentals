namespace Exer_04_FixEmails
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var emails = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = Console.ReadLine();

                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    emails[name] = email;
                }
                name = Console.ReadLine();
            }

            foreach (var person in emails)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}
