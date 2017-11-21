namespace _01_CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if(!result.ContainsKey(number))
                {
                    result[number] = 0;
                }

                result[number]++;
            }

            foreach (var number in result)
            {
                Console.WriteLine("{0} -> {1}",number.Key, number.Value);
            }
        }
    }
}
