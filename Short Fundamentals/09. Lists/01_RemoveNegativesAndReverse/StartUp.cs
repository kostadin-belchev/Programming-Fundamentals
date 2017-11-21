namespace _01_RemoveNegativesAndReverse
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            inputList.RemoveAll(i => i < 0);
            if (inputList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                inputList.Reverse();
                Console.WriteLine(String.Join(" ", inputList));
            }
        }
    }
}
