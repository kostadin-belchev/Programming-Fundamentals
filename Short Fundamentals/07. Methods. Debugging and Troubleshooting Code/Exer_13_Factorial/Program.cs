using System;
using System.Numerics;

namespace Exer_13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Factorial(number);
        }

        static void Factorial(int number)
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
            Console.WriteLine(result);
        }
    }
}
