using System;
using System.Linq;

namespace _05_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums =
                Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (var x in nums)
            {
               var rounded = Math.Round(x, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{x} => {rounded}");
            }
        }
    }
}
