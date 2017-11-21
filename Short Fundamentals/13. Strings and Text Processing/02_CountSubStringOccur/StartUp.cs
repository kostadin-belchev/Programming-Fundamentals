namespace _02_CountSubStringOccur
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int indexer = 0;
            int counter = 0;

            while (true)
            {
                int found = input.IndexOf(pattern, indexer);

                if (found >= 0)
                {
                    counter++;
                    indexer = found + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
