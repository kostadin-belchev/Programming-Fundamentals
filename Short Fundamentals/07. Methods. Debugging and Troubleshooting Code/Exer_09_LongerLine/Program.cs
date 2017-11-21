using System;

namespace Exer_09_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0.0;
            double y1 = 0.0;
            double x2 = 0.0;
            double y2 = 0.0;

            double maxLineLenght = double.MinValue;
            double maxx1 = 0.0;
            double maxy1 = 0.0;
            double maxx2 = 0.0;
            double maxy2 = 0.0;

            for (int i = 0; i < 2; i++)
            {
                x1 = double.Parse(Console.ReadLine());
                y1 = double.Parse(Console.ReadLine());

                x2 = double.Parse(Console.ReadLine());
                y2 = double.Parse(Console.ReadLine());

                double line = FindLine(x1, x2, y1, y2);

                if (line > maxLineLenght)
                {
                    maxLineLenght = line;
                    maxx1 = x1;
                    maxy1 = y1;
                    maxx2 = x2;
                    maxy2 = y2;
                }
            }
            PrintResult(maxx1, maxx2, maxy1, maxy2);
        }

        static void PrintResult(double x1, double x2, double y1, double y2)
        {
            double distanceOne = Math.Sqrt(x1 * x1 + y1 * y1);
            double distanceTwo = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distanceTwo < distanceOne)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
        }

        static double FindLine(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
