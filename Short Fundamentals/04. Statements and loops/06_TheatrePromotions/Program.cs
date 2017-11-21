namespace _06_TheatrePromotions
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var price = 0;
            if (age >= 0 && age <= 18)
            {
                if (day == "weekday")
                {
                    price = 12;
                }
                else if (day == "weekend")
                {
                    price = 15;
                }
                else if (day == "holiday")
                {
                    price = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (day == "weekday")
                {
                    price = 18;
                }
                else if (day == "weekend")
                {
                    price = 20;
                }
                else if (day == "holiday")
                {
                    price = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (day == "weekday")
                {
                    price = 12;
                }
                else if (day == "weekend")
                {
                    price = 15;
                }
                else if (day == "holiday")
                {
                    price = 10;
                }
            }

            if (price != 0)
            {
                Console.WriteLine("{0}$", price);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
