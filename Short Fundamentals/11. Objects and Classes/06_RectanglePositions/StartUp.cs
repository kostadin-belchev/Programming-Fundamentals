namespace _06_RectanglePositions
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var first = ReadRect();
            var second = ReadRect();

            bool result = FirstInsideSecondCheck(first, second);

            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }

        public static Rectangle ReadRect()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var rectangle = new Rectangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };

            return rectangle;
        }

        public static bool FirstInsideSecondCheck(
            Rectangle first, Rectangle second)
        {
            bool testOne = first.Left >= second.Left;
            bool testTwo = first.Right <= second.Right;
            bool testThree = first.Top <= second.Top;
            bool testFour = first.Bottom <= second.Bottom;

            return testOne && testTwo && testThree && testFour;
        }
    }
}
