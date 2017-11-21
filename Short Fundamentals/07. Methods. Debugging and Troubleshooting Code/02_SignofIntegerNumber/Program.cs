using System;


namespace _02_SignofIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else if (number == 0)
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }
    }
}
