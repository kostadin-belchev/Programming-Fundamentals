namespace _03_SumMinMaxAverage
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var range = int.Parse(Console.ReadLine());

            var numbers = new int[range];
            for (int i = 0; i < range; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average());
        }
    }
}
