using System;

namespace _01_CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            long years = centuries * 100;
            long days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", 
                centuries, years, days, hours, minutes);
        }
    }
}
