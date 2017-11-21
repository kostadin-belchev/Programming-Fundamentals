using System;

namespace _05_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int digits = i;
                int SumOfDigits = 0;

                while (digits > 0)
                {
                    SumOfDigits = SumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool special = SumOfDigits == 5 || SumOfDigits == 7 || SumOfDigits == 11;
                Console.WriteLine("{0} -> {1}", i, special);

            }
        }
    }
}
