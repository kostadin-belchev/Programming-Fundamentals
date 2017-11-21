using System;

namespace Exer_09_ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            string print = first + second + third;

            char[] charArray = print.ToCharArray();

            Array.Reverse(charArray);

            Console.WriteLine(charArray);
        }
    }
}
