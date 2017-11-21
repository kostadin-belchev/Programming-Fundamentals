using System;
using System.Linq;

namespace Exer_11_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool foundSums = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int[] leftSide = inputArray.Take(i).ToArray();
                int[] rightSide = inputArray.Skip(i + 1).ToArray();

                if(leftSide.Sum() == rightSide.Sum())
                {
                    Console.WriteLine(i);
                    foundSums = true;
                    break;
                }
            }

            if (!foundSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
