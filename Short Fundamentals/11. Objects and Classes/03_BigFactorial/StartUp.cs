namespace _03_BigFactorial
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFac(number));
        }
        
        public static BigInteger CalculateFac(int number)
        {
            BigInteger factorial = 1;

            while (number > 1)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
    }
}
