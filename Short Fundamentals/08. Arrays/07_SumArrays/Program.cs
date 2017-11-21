using System;
using System.Linq;
namespace _07_SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var longerArr = Math.Max(arr1.Length, arr2.Length);
            var sumArr = new int[longerArr];

            for (int i = 0; i < longerArr; i++)
            {
                sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(String.Join(" ", sumArr));
        }
    }
}
