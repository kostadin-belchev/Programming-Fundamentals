using System;

namespace _02_ReverseArrayOfInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Reverse(n);
        }

        static void Reverse(int n)
        {
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }


        }
    }
}
