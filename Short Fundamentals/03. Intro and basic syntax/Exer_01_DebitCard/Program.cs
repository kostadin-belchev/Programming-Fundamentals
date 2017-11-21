using System;

namespace Exer_01_DebitCard
{
    class Program
    {
        static void Main(string[] args)
        {
            var part1 = Console.ReadLine();
            var part2 = Console.ReadLine();
            var part3 = Console.ReadLine();
            var part4 = Console.ReadLine();

            Console.WriteLine("{0} {1} {2} {3}", part1.PadLeft(4, '0'), 
                part2.PadLeft(4, '0'), 
                part3.PadLeft(4, '0'),
                part4.PadLeft(4, '0'));
        }
    }
}
