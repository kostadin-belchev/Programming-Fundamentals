using System;
using System.Globalization;

namespace _10_HolidaysBetweenDates
{

    class HolidaysBetweenTwoDates
    {
        static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "dd.M.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "dd.M.yyyy", CultureInfo.InvariantCulture);

            int holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }

            Console.WriteLine(holidaysCount);
        }
    }
}
