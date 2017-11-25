namespace _01.Integer_Types
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var numsList = new List<BigInteger>();

            for (int i = 0; i < 4; i++)
            {
                numsList.Add(BigInteger.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ", numsList));
        }
    }
}
