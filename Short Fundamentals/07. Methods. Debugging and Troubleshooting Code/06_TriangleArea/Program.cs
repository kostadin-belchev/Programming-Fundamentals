using System;

namespace _06_TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var area = Calculate(width, height);
            Console.WriteLine(area);
        }

        static double Calculate(double width, double height)
        {
            return ( width * height ) / 2;
        }
    }
}
