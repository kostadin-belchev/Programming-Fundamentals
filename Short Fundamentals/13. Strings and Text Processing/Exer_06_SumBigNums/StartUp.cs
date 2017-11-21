namespace Exer_06_SumBigNums
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine()
                .TrimStart('0');
            string secondNum = Console.ReadLine()
                .TrimStart('0');

            Console.WriteLine(SumNums(firstNum, secondNum));
        }

        public static string SumNums(string firstNum, string secondNum)
        {
            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            var c = 0;

            var resultStrB = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                var sum = int.Parse(firstNum[i].ToString())
                          + int.Parse(secondNum[i].ToString()) + c;

                c = sum / 10;
                var remain = sum % 10;
                resultStrB.Append(remain);

                if (i == 0 && c != 0)
                {
                    resultStrB.Append(c);
                }
            }

            char[] output = resultStrB
                .ToString()
                .ToCharArray();

            Array.Reverse(output);

            return new string(output);
        }
    }
}
