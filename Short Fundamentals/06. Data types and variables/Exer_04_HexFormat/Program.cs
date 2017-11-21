using System;

namespace _Exer_04_HexFormat
{
    class Program
    {
        static void Main()
        {
            string hexademical = Console.ReadLine();

            Console.WriteLine("{0}", Convert.ToInt32(hexademical, 16));
        }
    }
}