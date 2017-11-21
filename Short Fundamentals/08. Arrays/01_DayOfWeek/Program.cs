using System;

namespace _01_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DayOfWeek(n);
        }

        static void DayOfWeek(int n)
        {
            string[] days =
               {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            try
            {
                Console.WriteLine(days[n - 1]);
            }
            catch
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
