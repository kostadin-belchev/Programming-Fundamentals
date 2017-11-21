using System;

namespace _04_FilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawHeader(n);
            for (int i = 1; i <= n - 2; i++)
            {
                DrawMiddle(n);
            }
            DrawHeader(n);
        }

        static void DrawHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void DrawMiddle(int n)
        {
            Console.Write("-");

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
