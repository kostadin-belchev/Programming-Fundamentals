namespace _07_SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfSales = int.Parse(Console.ReadLine());
            var SalesDictionary = new SortedDictionary<string, decimal>();

            for (int i = 0; i < numberOfSales; i++)
            {
                var currentSale = ReadSale();

                if (!SalesDictionary.ContainsKey(currentSale.Town))
                {
                    SalesDictionary[currentSale.Town] = 0m;
                }

                SalesDictionary[currentSale.Town] += currentSale.SalesResult;
            }

            foreach (var town in SalesDictionary)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }


        }
        public static Sale ReadSale()
        {
            var inputFromConsole =
                Console.ReadLine()
                .Split(' ')
                .ToArray();

            var SaleInfo = new Sale
            {
                Town = inputFromConsole[0],
                Product = inputFromConsole[1],
                Price = decimal.Parse(inputFromConsole[2]),
                Quantity = decimal.Parse(inputFromConsole[3])
            };

            return SaleInfo;

        }
    }
}
