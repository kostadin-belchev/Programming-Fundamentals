namespace _01_MostFrequentNum
{
    using System;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var line = File.ReadAllText(@"Text files\Input.txt");
            var input = line.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int longestStreak = 0;
            int mostFrequentNum = 0;

            foreach (var num in input)
            {
                int counter = 0;

                foreach (var number in input)
                {
                    if (num == number)
                    {
                        counter++;
                    }
                }

                if (counter <= longestStreak)
                {
                    continue;
                }
                longestStreak = counter;
                mostFrequentNum = num;
            }

            string output = mostFrequentNum.ToString();

            File.WriteAllText(@"Text files\Output.txt", output);
        }
    }
}
