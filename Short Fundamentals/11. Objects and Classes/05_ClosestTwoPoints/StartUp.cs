namespace _05_ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfPoints = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();


            for (int i = 0; i < numberOfPoints; i++)
            {
                var currentPointParts =
                    Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]

                });
            }

            var minDistanceSoFar = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance =
                        CalculateDist(
                            firstPoint,
                            secondPoint);

                    if (minDistanceSoFar > currentDistance)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistanceSoFar:f3}");
            Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
            Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");

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
