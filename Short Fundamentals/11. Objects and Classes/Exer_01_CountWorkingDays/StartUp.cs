namespace Exer_01_CountWorkingDays
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var format = "dd-MM-yyyy";

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                format, CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                format, CultureInfo.InvariantCulture);

            int workDaysCounter = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday
                && currentDate.DayOfWeek != DayOfWeek.Sunday
                && !HolidayCheck(currentDate))
                {

                    workDaysCounter++;
                }
            }
            Console.WriteLine(workDaysCounter);
        }

        public static bool HolidayCheck(DateTime date)
        {
            var holidays = new string[]
                {
                   "1-1", "3-3", "1-5",
                   "6-5",  "24-5", "6-9",
                   "22-9", "1-11", "24-12",
                    "25-12", "26-12"
                };

            string dateFormatted = $"{date.Day}-{date.Month}";

            return holidays.Contains(dateFormatted);
        }
    }
}
