namespace _06_SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNumbers = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if(Math.Sqrt(inputList[i]) == (int)Math.Sqrt(inputList[i]))
                {
                    squareNumbers.Add(inputList[i]);
                }
            }
            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ", squareNumbers));
          
        }
    }
}
