namespace Exer_05_MagicExchangeable
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] wordsInput = Console.ReadLine()
               .Split(' ');

            string firstWord = wordsInput[0];
            string secondWord = wordsInput[1];

            Console.WriteLine(ExchangeableCheck(firstWord, secondWord) ? "true" : "false");
        }

        public static bool ExchangeableCheck(string firstWord, string secondWord)
        {
            firstWord = new String(firstWord.Distinct().ToArray());
            secondWord = new String(secondWord.Distinct().ToArray());

            return firstWord.Length == secondWord.Length;
        }
    }
}
