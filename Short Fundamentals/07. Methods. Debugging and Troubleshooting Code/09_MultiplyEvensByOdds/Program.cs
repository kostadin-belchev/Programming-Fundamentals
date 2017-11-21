using System;

namespace _09_MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int convertedNumber = Math.Abs(inputNumber);
            Console.WriteLine(CalculateOddEven(convertedNumber));
        }

        static int CalculateOddEven(int convertedNumber)
        {
            int odds = GetOddNumbers(convertedNumber);
            int evens = GetEvenNumbers(convertedNumber);

            return odds * evens;
        }

        static int GetOddNumbers(int convertedNumber)
        {
            int sum = 0;
            while (convertedNumber > 0)
            {
                int lastDigit = convertedNumber % 10;
                if(lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                convertedNumber /= 10;
            }
            return sum;
        }

        static int GetEvenNumbers(int convertedNumber)
        {
            int sum = 0;
            while (convertedNumber > 0)
            {
                int lastDigit = convertedNumber % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                convertedNumber /= 10;
            }
            return sum;
        }

    }
}
