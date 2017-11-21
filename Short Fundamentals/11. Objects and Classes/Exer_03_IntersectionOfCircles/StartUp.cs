namespace Exer_03_IntersectionOfCircles
{
    using System;
    using System.Linq;
    using Exer_03_IntersectionOfCircles.Classes;

    public class StartUp
    {
        public static void Main()
        {
            var firstCircle = GetSircleInfo();
            var secondCircle = GetSircleInfo();

            bool result = IntersectCheck(firstCircle, secondCircle);

            if (result)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        public static Circle GetSircleInfo()
        {
            var circleProperties = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Point circleCenter = new Point
            {
                X = circleProperties[0],
                Y = circleProperties[1]
            };

            Circle circle = new Circle
            {
                Radius = circleProperties[2],
                Center = circleCenter
            };

            return circle;
        }

        public static bool IntersectCheck(Circle firstCircle, Circle secondCircle)
        {
            var firstCircleCenter = firstCircle.Center;
            var secondCircleCenter = secondCircle.Center;

            double calculatedDistance = CalculateDistance(
                firstCircleCenter, secondCircleCenter);

            return !(calculatedDistance > firstCircle.Radius + secondCircle.Radius);
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
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
