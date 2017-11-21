namespace _05_SortNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            inputList.Sort();

            Console.WriteLine(String.Join(" <= ", inputList));
        }
    }
}
