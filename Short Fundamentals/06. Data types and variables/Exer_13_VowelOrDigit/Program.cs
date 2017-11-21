using System;

namespace Exer_13_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'o' || input == 'i' || input == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (Char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
