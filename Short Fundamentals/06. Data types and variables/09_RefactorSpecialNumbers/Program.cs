using System;

namespace _09_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int total = 0;
            int cycle = 0;
            bool divided = false;
            for (int i = 1; i <= digits; i++)
            {
                cycle = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                divided = total == 5 || total == 7 || total == 11;
                Console.WriteLine($"{cycle} -> {divided}");

                total = 0;
                i = cycle;
            }

        }
    }
}
