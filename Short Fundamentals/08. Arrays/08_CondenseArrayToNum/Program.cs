using System;
using System.Linq;

namespace _08_CondenseArrayToNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (inputArr.Length > 1)
            {
                var condensed = new int[inputArr.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = inputArr[i] + inputArr[i + 1];
                }
                inputArr = condensed;
            }
            Console.WriteLine(inputArr[0]);
        }
    }
}
