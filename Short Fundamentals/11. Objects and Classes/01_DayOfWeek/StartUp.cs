namespace _01_DayOfWeek
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputDate = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            var theDate = new DateTime(inputDate[2], inputDate[1], inputDate[0]).DayOfWeek;

            Console.WriteLine(theDate);
        }
    }
}
