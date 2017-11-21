using System;

namespace Exer_02_MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(GetMax(a, b), c));

        }
        static int GetMax(int a, int b)
        {
           return Math.Max(a, b);
        }
    }
}
