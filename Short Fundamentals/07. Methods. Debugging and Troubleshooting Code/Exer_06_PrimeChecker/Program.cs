using System;

namespace Exer_06_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            if(isPrime(num) == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static bool isPrime(long num)
        {
            if (num == 0) return false;
            if (num == 1) return false;
            if (num == 2) return true;

            int newnum = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 2; i <= newnum; i++)
                if (num % i == 0) return false;

            return true;
        }
    }
}
