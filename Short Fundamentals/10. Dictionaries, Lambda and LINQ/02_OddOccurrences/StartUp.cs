namespace _02_OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(x => x.ToLower()).ToList();
            var wordCounter = new Dictionary<string, int>();

            foreach (var word in inputList)
            {
                if (!wordCounter.ContainsKey(word))
                {
                    wordCounter[word] = 0;
                }
                wordCounter[word]++;
            }

            var output = new List<string>();

            foreach (var word in wordCounter)
            {
                if (word.Value % 2 != 0)
                {
                    output.Add(word.Key);
                }
            }

            Console.WriteLine(String.Join(", ", output));
        }
    }
}
