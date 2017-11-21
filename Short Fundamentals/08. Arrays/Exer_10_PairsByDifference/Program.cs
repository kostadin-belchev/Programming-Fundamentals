using System;
using System.Linq;

namespace Exer_10_PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if(Math.Abs(inputArray[i] - inputArray[j]) == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
