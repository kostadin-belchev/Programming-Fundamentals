namespace _03_SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var i = 0;

            while (i < inputList.Count - 1)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    inputList[i] += inputList[i + 1];
                    inputList.RemoveAt(i + 1);
                    i--;
                    if (i < 0) i = 0;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(String.Join(" ", inputList));
        }
    }
}
