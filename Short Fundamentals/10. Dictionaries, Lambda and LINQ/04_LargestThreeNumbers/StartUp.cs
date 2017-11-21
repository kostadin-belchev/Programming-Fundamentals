namespace _04_LargestThreeNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (inputList.Count > 3)
            {
                var output = inputList.OrderByDescending(x => x).Take(3);
                Console.WriteLine(String.Join(" ", output));
            }
            else
            {
                var output = inputList.OrderByDescending(x => x);
                Console.WriteLine(String.Join(" ", output));
            }
        }
    }
}
