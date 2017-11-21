namespace Exer_06_UserLogs
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string currentInput = Console.ReadLine();

            var usersLog = new SortedDictionary<string, Dictionary<string, int>>();

            while (currentInput != "end")
            {
                string[] splitArgs = currentInput.Split('=', ' ');

                string currentIp = splitArgs[1];
                string currentUser = splitArgs[5];

                if (!usersLog.ContainsKey(currentUser))
                {
                    usersLog[currentUser] = new Dictionary<string, int>();
                }

                if (!usersLog[currentUser].ContainsKey(currentIp))
                {
                    usersLog[currentUser].Add(currentIp, 0);
                }

                usersLog[currentUser][currentIp]++;

                currentInput = Console.ReadLine();
            }

            foreach (var user in usersLog)
            {
                var result = new List<string>();

                Console.WriteLine("{0}: ", user.Key);

                foreach (var ip in usersLog[user.Key])
                {
                    result.Add($"{ip.Key} => {ip.Value}");
                }

                Console.WriteLine("{0}.",String.Join(", ", result));
            }
        }
    }
}
