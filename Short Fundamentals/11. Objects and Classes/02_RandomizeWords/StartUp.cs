namespace _02_RandomizeWords
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').ToArray();
            var rnd = new Random();

            for (int i = 0; i < inputList.Length; i++)
            {
                string currentWord = inputList[i];
                int randomizedIndex = rnd.Next(0, inputList.Length);
                string tempWord = inputList[randomizedIndex];

                inputList[i] = tempWord;
                inputList[randomizedIndex] = currentWord;
            }

            foreach (var word in inputList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
