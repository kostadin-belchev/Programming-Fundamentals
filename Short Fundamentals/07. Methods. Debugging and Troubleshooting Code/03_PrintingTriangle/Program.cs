using System;

namespace _03_PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                PrintNumbers(1, i);
            }

            for (int i = number; i >= 1; i--)
            {
                PrintNumbers(1, i);
            }

        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
