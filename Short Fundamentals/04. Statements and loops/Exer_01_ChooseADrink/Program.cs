namespace Exer_01_ChooseADrink
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var profession = Console.ReadLine().ToLower();

            switch (profession)
            {
                case "athlete":
                    Console.WriteLine("Water");
                    break;
                case "businessman":
                case "businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "softuni student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}