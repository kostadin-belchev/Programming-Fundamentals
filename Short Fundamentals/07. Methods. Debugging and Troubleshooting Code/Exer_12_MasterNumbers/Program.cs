using System;

namespace Exer_12_MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {


                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
            static bool IsPalindrome(int num)
            {
                string number = num.ToString();

                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] == number[number.Length - 1 - i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }

            static bool SumOfDigits(int num)
            {
                string number = num.ToString();
                int sum = 0;

                for (int i = 0; i < number.Length; i++)
                {
                    sum += int.Parse(number[i].ToString());
                }

                if (sum % 7 == 0)
                {
                    return true;
                }

                return false;
            }

            static bool ContainsEvenDigit(int num)
            {
                string number = num.ToString();

                for (int i = 0; i < number.Length; i++)
                {
                    int rem = int.Parse(number[i].ToString());

                    if (rem % 2 == 0)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
