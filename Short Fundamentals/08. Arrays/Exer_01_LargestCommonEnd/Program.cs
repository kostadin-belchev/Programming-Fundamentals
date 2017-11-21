using System;
using System.Linq;

namespace Exer_01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ').ToArray();
            var secondArr = Console.ReadLine().Split(' ').ToArray();
            int leftCounter = 0;
            int rightCounter = 0;

            int shorterLength = Math.Min(firstArr.Length, secondArr.Length);

            for (int i = 0; i < shorterLength; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    leftCounter++;
                }
                //hi php java csharp sql html css js
                //hi php java js softuni nakov java learn

                if (firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                {
                    rightCounter++;
                }
            }
            Console.WriteLine(Math.Max(leftCounter, rightCounter));

        }
    }
}
