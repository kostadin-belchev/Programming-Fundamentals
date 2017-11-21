using System;

namespace Exer_07_ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.Write("Before:\na = {0}\nb = {1}\n", first, second);

            int temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After:\na = {0}\nb = {1}\n", first, second);
        }
    }
}
