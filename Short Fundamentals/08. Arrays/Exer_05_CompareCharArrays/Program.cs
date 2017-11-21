using System;
using System.Linq;

namespace Exer_05_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            
            if(firstArray.Length == secondArray.Length)
            {
                if (firstArray[0] < secondArray[0])
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(secondArray);
                Console.WriteLine(firstArray);
            }
            else
            {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }
        }
    }
}
