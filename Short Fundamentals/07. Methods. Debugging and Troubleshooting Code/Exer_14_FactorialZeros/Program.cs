using System;
using System.Numerics;

namespace Exer_13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FactorialZeroes(number);
        }

        static void FactorialZeroes(int number)
        {
            BigInteger result = number;

            /* Input = 5
             * 5 = 5 * 1
             * 10 = 5 * 2
             * ...
             * ...
             *
             */
            for (int i = 1; i < number; i++)
            {
                result = result * i;
            }
            //New part 
            int zeroes = 0;
            while (result % 10 == 0)
            {
                result = result / 10;
                zeroes++;
            }
            Console.WriteLine(zeroes);
        }
    }
}
