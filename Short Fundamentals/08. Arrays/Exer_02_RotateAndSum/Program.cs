using System;
using System.Linq;

namespace Exer_02_RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[inputArray.Count];

            for (int i = 0; i < k; i++)
            {
                inputArray.Insert(0, inputArray[inputArray.Count - 1]);
                inputArray.RemoveAt(inputArray.Count - 1);

                for (int j = 0; j < inputArray.Count; j++)
                {
                    sum[j] += inputArray[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}