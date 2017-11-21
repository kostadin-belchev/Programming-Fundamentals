namespace _07_AdvertMessage
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class StartUp
    {
        static void Main(string[] args)
        {
            var opinions = File.ReadAllText(@"Text files\Opinions.txt")
                .Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
            var feelings = File.ReadAllText(@"Text files\Feelings.txt")
                .Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
            var authors = File.ReadAllText(@"Text files\Authors.txt")
                .Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);
            var cities = File.ReadAllText(@"Text files\Cities.txt")
                .Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);

            Random randomizer = new Random();

            int messagesToGenerate = int.Parse(File.ReadAllText(@"Text files\Messages.txt"));
            var output = new List<string>();
            for (int i = 0; i < messagesToGenerate; i++)
            {
                int opinionsIndex = randomizer.Next(0, opinions.Length);
                int feelingsIndex = randomizer.Next(0, feelings.Length);
                int authorIndex = randomizer.Next(0, authors.Length);
                int cityIndex = randomizer.Next(0, cities.Length);

                string message = $"{opinions[opinionsIndex]} " +
                                 $"{feelings[feelingsIndex]} " +
                                 $"{authors[authorIndex]} - " +
                                 $"{cities[cityIndex]}.";

                output.Add(message);
            }

            File.WriteAllLines(@"Text files\Output.txt", output);
        }
    }
}
