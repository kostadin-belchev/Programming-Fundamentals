namespace Exer_03_MinerTask
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    resources[input] = 0;
                }
                resources[input] += quantity;

                input = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
