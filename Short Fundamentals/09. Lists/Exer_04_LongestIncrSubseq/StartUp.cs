namespace Exer_04_LongestIncrSubseq
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            /* Problem solved after watching:
             * Dynamic programming / Algorithms 2016 
             */
            var inputSequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            GetLIS(inputSequence);
        }

        public static void GetLIS(int[] inputSequence)
        {
            if (inputSequence.Length == 1)
            {
                Console.WriteLine(inputSequence[0]);
                return;
            }

            var paths = new string[inputSequence.Length];
            var sizes = new int[inputSequence.Length];

            for (int i = 0; i < inputSequence.Length; i++)
            {
                sizes[i] = 1;
                paths[i] = inputSequence[i] + " ";
            }

            int maxLength = 1;

            for (int i = 1; i < inputSequence.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (inputSequence[i] > inputSequence[j] && sizes[i] < sizes[j] + 1)
                    {
                        sizes[i] = sizes[j] + 1;
                        paths[i] = paths[j] + inputSequence[i] + " ";

                        if (maxLength < sizes[i])
                        {
                            maxLength = sizes[i];
                        }
                    }
                }
            }

            for (int i = 1; i < inputSequence.Length; i++)
            {
                if(sizes[i] == maxLength)
                {
                    Console.WriteLine(paths[i]);
                    return;
                }
            }
        }
    }
}
