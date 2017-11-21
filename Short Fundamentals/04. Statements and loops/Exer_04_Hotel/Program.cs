namespace Exer_04_Hotel
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            decimal discount = 0;

            if (month == "may")
            {
                if (nights > 7)
                {
                    discount = (decimal)0.05;
                }
                Console.WriteLine("Studio: {0:f2} lv.", nights * 50 * (1 - discount));
                Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
            }
            else if (month == "october")
            {
                if (nights > 7)
                {
                    discount = (decimal)0.05;
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 50 * (1 - discount));
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
                }
                // didnt add lv. here and i raged for like 10 mins straight
                Console.WriteLine("Double: {0:f2}", nights * 65);
                Console.WriteLine("Suite: {0:f2}", nights * 75);
            }
            else if (month == "june")
            {
                Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                if (nights > 14)
                {
                    discount = (decimal)0.10;
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72 * (1 - discount));
                }
                else
                {
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                }

                Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
            }
            else if (month == "september")
            {
                if (nights > 14)
                {
                    discount = (decimal)0.10;
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60 * (1 - discount));
                }
                if (nights > 7) // might be && nights <=14
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60 * (1 - discount));
                }
                else
                {
                    Console.WriteLine("Studio: {0:f2} lv.", (nights * 60));
                }

                Console.WriteLine("Double: {0:f2} lv.", nights * 72 * (1 - discount));
                Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
            }
            else
            {
                if (nights > 14)
                {
                    discount = (decimal)0.15;
                }

                Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
                Console.WriteLine("Double: {0:f2} lv.", nights * 77);
                Console.WriteLine("Suite: {0:f2} lv.", nights * 89 * (1 - discount));
            }

        }
    }
}