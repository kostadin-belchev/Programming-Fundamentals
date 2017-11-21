namespace _03_TextFilter
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
