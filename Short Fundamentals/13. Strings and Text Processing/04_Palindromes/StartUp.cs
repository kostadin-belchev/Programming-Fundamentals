namespace _04_Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var wordsList = new HashSet<string>();

            foreach (var word in input)
            {
                if (PalindromeCheck(word))
                {
                    wordsList.Add(word);
                }
            }
            Console.WriteLine(String.Join(", ", wordsList.OrderBy(n => n)));
        }

        public static bool PalindromeCheck(string word)
        {
            if (word.Length == 1) return true;

            var strBuilder = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                strBuilder.Append(word[i]);
            }

            string reversedWord = strBuilder.ToString();

            int paliCheck = String.Compare(reversedWord, word, false);

            return paliCheck == 0;
        }
    }
}
