namespace Exer_02_ConvertFromBaseN
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();

            var baseN = inputNums[0];
            var numberToConvert = inputNums[1];

            Console.WriteLine(ConvertFromBaseN(baseN, numberToConvert));
        }

        public static string ConvertFromBaseN(BigInteger baseN, BigInteger numberToConvert)
        {
            BigInteger resultNum = 0;
            int index = 0;

            while (numberToConvert > 0)
            {
                var digit = numberToConvert % 10;
                resultNum += digit * BigInteger.Pow(baseN, index++);
                numberToConvert /= 10;
            }

            string resultOutput = resultNum.ToString();

            return resultOutput;
        }
    }
}
