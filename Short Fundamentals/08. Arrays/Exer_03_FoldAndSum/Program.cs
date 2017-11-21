using System;
using System.Linq;

namespace Exer_03_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int fold = inputArray.Length / 4;
            var upperRow = new int[fold * 2];
            var lowerRow = new int[fold * 2];
            var resultArray = new int[fold * 2];

            for (int i = 0; i < fold; i++)
            {
                upperRow[i] = inputArray[fold - i - 1];
                upperRow[upperRow.Length - i - 1] = inputArray[inputArray.Length - fold + i];

                lowerRow[i * 2] = inputArray[i * 2 + fold];
                lowerRow[i * 2 + 1] = inputArray[i * 2 + fold + 1];
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(String.Join(" ", resultArray));
        }
    }
}
