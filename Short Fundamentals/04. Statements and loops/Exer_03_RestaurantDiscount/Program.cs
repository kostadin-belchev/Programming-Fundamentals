namespace Exer_03_RestaurantDiscount
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal price = 0;
            decimal price2 = 0;
            decimal discount = 0;
            string hall = "";
            
            //Packages
            if (package == "Normal")
            {
                price2 = 500;
                discount = (decimal)0.05;

            }
            else if (package == "Gold")
            {
                price2 = 750;
                discount = (decimal)0.10;
            }
            else if (package == "Platinum")
            {
                price2 = 1000;
                discount = (decimal)0.15;
            }
            // Group size
            if (groupSize <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (groupSize >= 51 && groupSize <= 100)
            {
                price = 5000;
                hall = "Terrace";
            }
            else if (groupSize >= 101 && groupSize <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }
            // If the group is bigger than 120 people
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else 
            {
                //Calculations
                decimal sum = (price + price2) * (1 - discount);
                decimal pricePerPerson = sum / groupSize;

                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
            }
        }
    }
}
