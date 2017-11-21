using System;

namespace _07_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double poweredNumber = RaisingToPower(number, power);
            Console.WriteLine(poweredNumber);
        }

        static double RaisingToPower(double number, double power)
        {
            double sum = Math.Pow(number, power);
            return sum;
        }
    }
}
