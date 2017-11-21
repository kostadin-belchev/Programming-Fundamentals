using System;

namespace Exer_08_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Checker(x1, y1, x2, y2);
        }

        static void Checker(double x1, double y1, double x2, double y2)
        {
            double c1 = Math.Abs(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double c2 = Math.Abs(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (c2 < c1)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }

        }
    }
}
