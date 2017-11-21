using System;

namespace Exer_10_CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();

            switch (type)
            {
                case "face": Face(side); break;
                case "space": Space(side); break;
                case "volume": Volume(side); break;
                case "area": Area(side); break;
            }
        }

        static void Face(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(2 * Math.Pow(side, 2)));
        }

        static void Space(double side)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(3 * Math.Pow(side, 2)));
        }

        static void Volume(double side)
        {
            Console.WriteLine("{0:f2}", Math.Pow(side, 3));
        }

        static void Area(double side)
        {
            Console.WriteLine("{0:f2}", 6 * Math.Pow(side, 2));
        }
    }
}
