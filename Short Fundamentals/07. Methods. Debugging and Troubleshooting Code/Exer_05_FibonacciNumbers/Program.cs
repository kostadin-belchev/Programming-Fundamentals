using System;

namespace Exer_05_FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumber = int.Parse(Console.ReadLine());

           
            if (theNumber == 0)
            {
                Console.WriteLine(1);
                return;
            }
            if (theNumber == 1)
            {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine(Fibonacci(theNumber));
        }

        static int Fibonacci(int theNumber)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 0;

            for (int i = 0; i < theNumber; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }

            return num3;
        }

    }
}