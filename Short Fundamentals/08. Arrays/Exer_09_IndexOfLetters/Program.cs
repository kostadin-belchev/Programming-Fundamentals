using System;

namespace Exer_09_IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new char[26];
            string input = Console.ReadLine();

            foreach (var character in input)
            {
                Console.WriteLine($"{character} -> {character - 'a'}");
            }
        }
    }
}
