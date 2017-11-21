namespace _07_CountNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            inputList.Sort();
            var counter = 1;
            var currentNumber = inputList[0];
            

            for (int i = 1; i < inputList.Count; i++)
            {
                var nextNumber  = inputList[i];

                if (nextNumber == currentNumber)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", currentNumber, counter);
                    counter = 1;
                }
                currentNumber = nextNumber;
            }
            Console.WriteLine("{0} -> {1}", currentNumber, counter);
        }
    }
}
