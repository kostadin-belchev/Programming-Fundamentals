using System;
using System.Linq;

namespace _04_TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool tripleCheck = false;

            for (int indexer = 0; indexer < input.Length; indexer++)
            {
                int a = input[indexer];

                for (int checkDigit = indexer + 1; checkDigit < input.Length; checkDigit++)
                {
                    int b = input[checkDigit];

                    int sumOfDigits = a + b;

                    if(input.Contains(sumOfDigits))
                    {
                        Console.WriteLine($"{a} + {b} == {sumOfDigits}");
                        tripleCheck = true;
                    }
                }
            }
            if(tripleCheck == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
