namespace Exer_08_LogsAggregator
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int logsCounter = int.Parse(Console.ReadLine());
            var usersLog = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 1; i <= logsCounter; i++)
            {
                string currentLog = Console.ReadLine();
                string[] inputArgs = currentLog.Split(' ');

                string currentIP = inputArgs[0];
                string username = inputArgs[1];
                int durationTime = int.Parse(inputArgs[2]);

                if (!usersLog.ContainsKey(username))
                {
                    usersLog[username] = new SortedDictionary<string, int>();
                }

                if (!usersLog[username].ContainsKey(currentIP))
                {
                    usersLog[username].Add(currentIP, 0);
                }

                usersLog[username][currentIP] += durationTime;
            }

            foreach (var user in usersLog)
            {
                List<string> outputIPs = new List<string>();

                int sumDurations = 0;

                Console.Write("{0}: ", user.Key);

                foreach (var ip in usersLog[user.Key])
                {
                    sumDurations += ip.Value;
                    outputIPs.Add($"{ip.Key}");
                }

                Console.WriteLine("{0} [{1}]", sumDurations, String.Join(", ", outputIPs));
            }
        }
    }
}
