namespace Exer_04_CharacterMultiplier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
               .Split(' ');

            string firstString = input[0];
            string secondString = input[1];
            Console.WriteLine(Multiplier(firstString, secondString));
        }

        public static int Multiplier(string firstString, string secondString)
        {
            string longerString = string.Empty;
            string shorterString = string.Empty;

            if (Math.Max(firstString.Length, secondString.Length) == firstString.Length)
            {
                longerString = firstString;
                shorterString = secondString;
            }
            else
            {
                longerString = secondString;
                shorterString = firstString;
            }

            int sum = 0;

            for (int i = 0; i < shorterString.Length; i++)
            {
                sum += shorterString[i] * longerString[i];
            }

            for (int i = shorterString.Length; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }

            return sum;
        }
    }
}

