using System;
using System.Linq;

namespace _09_ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine("{{ {0} }}", array[0]);
            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine("{{ {0}, {1} }}", array[array.Length / 2 - 1], array[array.Length / 2]);
            }
            else if (array.Length % 2 != 0)
            {
                Console.WriteLine("{{ {0}, {1}, {2} }}", array[array.Length / 2 - 1], array[array.Length / 2], array[array.Length / 2 + 1]);
            }
        }
    }
}
