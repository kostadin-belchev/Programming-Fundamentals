namespace Exer_08_CaloriesCounter
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var calories = 0;

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine().ToLower();
                if (product == "cheese")
                {
                    calories += 500;
                }
                else if (product == "tomato sauce")
                {
                    calories += 150;
                }
                else if (product == "salami")
                {
                    calories += 600;
                }
                else if (product == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine("Total calories: {0}", calories);
        }
    }
}
