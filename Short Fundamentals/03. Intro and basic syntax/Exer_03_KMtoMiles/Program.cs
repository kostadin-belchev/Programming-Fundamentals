using System;

namespace Exer_03_KMtoMiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());

            var km = miles * 1.60934;
            Console.WriteLine("{0:f2}", km);
        }
    }
}
