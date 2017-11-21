namespace _04_DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point firstPoint = new Point
            {
                X = firstInput[0],
                Y = firstInput[1]
            };

            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point secondPoint = new Point
            {
                X = secondInput[0],
                Y = secondInput[1]
            };

            double result = CalculateDist(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
        }

        public static double CalculateDist(Point firstPoint, Point secondPoint)
        {
            double differenceX = firstPoint.X - secondPoint.X;
            double differenceY = firstPoint.Y - secondPoint.Y;

            double powX = Math.Pow(differenceX, 2);
            double powY = Math.Pow(differenceY, 2);

            double distance = Math.Sqrt(powX + powY);

            return distance;
        }
    }
}
