namespace Exer_01_ConvertFromBase10
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();

            var baseNum = inputNums[0];
            var baseTenNum = inputNums[1];

            Console.WriteLine(BaseNConvert(baseNum, baseTenNum));
        }

        public static string BaseNConvert(BigInteger baseNum, BigInteger baseTenNum)
        {
            var strBuilder = new StringBuilder();

            while (baseTenNum > 0)
            {
                var result = baseTenNum % baseNum;
                strBuilder.Insert(0, result);
                baseTenNum /= baseNum;
            }

            string output = strBuilder.ToString();
            return output;
        }
    }
}
