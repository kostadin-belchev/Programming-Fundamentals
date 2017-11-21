namespace Exer_06_SumReversedNumbers
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0;

            foreach (var number in inputList)
            {
                int reversed = ReverseNum(number);
                sum += reversed;
            }
            Console.WriteLine(sum);
        }

        public static int ReverseNum(int num)
        {
            int reversedNumber = 0;
            while (num > 0)
            {
                reversedNumber = (reversedNumber * 10) + (num % 10);
                num /= 10;
            }
            return reversedNumber;
        }
    }
}
