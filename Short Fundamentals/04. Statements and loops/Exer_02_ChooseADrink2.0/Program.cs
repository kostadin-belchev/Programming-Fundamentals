namespace Exer_02_ChooseADrink2._0
{
    using System; 

    class StartUp
    {
        static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            double price = 0;

            switch (profession)
            {
                case "Athlete":
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    break;
                default:
                    price = 1.20;
                    break;
            }
            Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * price);
        }
    }
}
