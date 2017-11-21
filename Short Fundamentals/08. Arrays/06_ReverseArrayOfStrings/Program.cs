using System;
using System.Linq;

namespace _06_ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');

            var reversed = items.Reverse();
            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}
