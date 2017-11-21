namespace Exer_10_SrubskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            const string pattern = @"(.*) @(.*?) (\d+) (\d+)";

            var output = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var matched = Regex.Match(input, pattern);
                string singer = matched.Groups[1].Value;
                string venue = matched.Groups[2].Value;
                int ticketPrice = int.Parse(matched.Groups[3].Value);
                int ticketCounter = int.Parse(matched.Groups[4].Value);
                long totalAmount = (long)ticketCounter * ticketPrice;

                if (!output.ContainsKey(venue))
                {
                    output.Add(venue, new Dictionary<string, long>());
                }
                if (!output[venue].ContainsKey(singer))
                {
                    output[venue].Add(singer, 0);
                }
                output[venue][singer] += totalAmount;
                input = Console.ReadLine();
            }

            foreach (var venue in output)
            {
                Console.WriteLine("{0}", venue.Key);

                var earnings = output[venue.Key].OrderByDescending(x => x.Value);

                foreach (var singer in earnings)
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }
    }
}
