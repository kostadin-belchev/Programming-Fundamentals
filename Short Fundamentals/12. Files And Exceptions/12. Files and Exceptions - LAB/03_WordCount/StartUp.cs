namespace _03_WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] textToWords = File.ReadAllText(@"Text files\Text.txt")
                    .ToLower()
                    .Split(new[] { ' ', '-', ',', '.', '?', '!', '\r', '\n', '…' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string[] words = File.ReadAllText(@"Text files\Words.txt")
                    .ToLower()
                    .Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var wordsCounter = new Dictionary<string, int>();

                foreach (var word in textToWords)
                {
                    foreach (var wordToCheck in words)
                    {
                        if (word == wordToCheck)
                        {
                            if (!wordsCounter.ContainsKey(wordToCheck))
                            {
                                wordsCounter[wordToCheck] = 0;
                            }
                            wordsCounter[wordToCheck]++;
                        }
                    }
                }

                var output = new List<string>();

                var wordsCounterSorted = wordsCounter
                    .OrderByDescending(x => x.Value);

                foreach (var word in wordsCounterSorted)
                {
                    output.Add($"{word.Key} - {word.Value}");
                }
                File.WriteAllLines(@"Text files\Output.txt", output);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot read input / write output.");
            }
        }
    }
}
