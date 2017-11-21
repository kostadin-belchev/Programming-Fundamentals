using System;

namespace Exer_04_NumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }

        static string Reverse(string number)
        {
            string result = String.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }

            return result;
        }
    }
}
