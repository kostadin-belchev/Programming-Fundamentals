using System;

namespace Exer_11_GeometryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "triangle": Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())); break;
                case "square": Square(double.Parse(Console.ReadLine())); break;
                case "rectangle": Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())); break;
                case "circle": Circle(double.Parse(Console.ReadLine())); break;
            }
        }

        static void Triangle(double side, double height)
        {
            double area = (side * height) / 2;

            Console.WriteLine("{0:f2}", area);
        }

        static void Square(double side)
        {
            Console.WriteLine("{0:f2}", side * side);
        }

        static void Rectangle(double width, double height)
        {
            Console.WriteLine("{0:f2}", width * height);
        }

        static void Circle(double radius)
        {
            Console.WriteLine("{0:f2}", Math.PI * radius * radius);
        }
    }
}
