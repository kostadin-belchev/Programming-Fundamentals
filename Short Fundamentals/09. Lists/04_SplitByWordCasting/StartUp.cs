namespace _04_SplitByWordCasting
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var separators = ",;:.!()\"'/\\[] ".ToCharArray();
            var inputList = Console.ReadLine().
                Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            foreach (var word in inputList)
            {
                var containsLower = false;
                var containsUpper = false;
                var containsSymbol = false;

                foreach (var letter in word)
                {
                    if (char.IsLower(letter)) containsLower = true;
                    if (char.IsUpper(letter)) containsUpper = true;
                    if (!char.IsLetter(letter)) containsSymbol = true;
                }

                if (containsSymbol) mixedCase.Add(word);
                else if (!containsUpper) lowerCase.Add(word);
                else if (!containsLower) upperCase.Add(word);
                else mixedCase.Add(word);

            }
            Console.WriteLine("Lower-case: {0} ", String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0} ", String.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0} ", String.Join(", ", upperCase));
        }
    }
}
