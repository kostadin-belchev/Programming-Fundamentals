using System;
using System.Linq;

namespace Exer_08_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] count = new int[100000];

            foreach (var element in inputArray)
            {
                count[element]++;
            }

            int maxCount = count.Max();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if(count[inputArray[i]] == maxCount)
                {
                    Console.WriteLine(inputArray[i]);
                    return;
                }
            }
        }
    }
}
