using System;

namespace _05_TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = conversiontoC(fahrenheit);
            Console.WriteLine("{0:f2}", celsius);
        }

        static double conversiontoC(double fahrenheit)
        {
           double converted = (fahrenheit - 32) * 5 / 9;
           return converted;
        }
    }
}
