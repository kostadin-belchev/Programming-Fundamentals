using System;
using System.Linq;

namespace Exer_07_MaxSequenceOfIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > inputArray[i - 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    length = 1;
                }
            }


            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write("{0} ", inputArray[i]);
            }
        }
    }
}

