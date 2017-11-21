namespace Exer_01_MaxSequenceOfEqual
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bestLenght = 1;
            var currentLength = 1;
            var bestStart = 0;
            var currentStart = 0;

            for (int i = 1; i < inputList.Count; i++)
            {
                if(inputList[i] == inputList[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }

                if(currentLength > bestLenght)
                {
                    bestLenght = currentLength;
                    bestStart = currentStart;
                }
            }
            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                Console.Write("{0} ", inputList[i]);
            }
            Console.WriteLine();
        }
    }
}
