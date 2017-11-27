namespace _03.Big_Power
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int numberToPower = int.Parse(Console.ReadLine());
            Console.WriteLine($"{BigInteger.Pow(numberToPower, numberToPower)}");
        }
    }
}
