namespace Exer_11_DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var dragons = new Dictionary<string, SortedDictionary<string, double[]>>();
            int dragonsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < dragonsCount; i++)
            {
                string[] args = Console.ReadLine().Split(' ');

                string dragonColor = args[0];
                string dragonType = args[1];
                double dragonDMG = 0;
                double dragonHP = 0;
                double dragonArmor = 0;

                //Default values if no input
                dragonDMG = args[2] != "null" ? double.Parse(args[2]) : 45;
                dragonHP = args[3] != "null" ? double.Parse(args[3]) : 250;
                dragonArmor = args[4] != "null" ? double.Parse(args[4]) : 10;

                if (!dragons.ContainsKey(dragonColor))
                {
                    dragons[dragonColor] = new SortedDictionary<string, double[]>();
                }

                if (!dragons[dragonColor].ContainsKey(dragonType))
                {
                    dragons[dragonColor][dragonType] = new[] { 0d, 0d, 0d };
                }

                dragons[dragonColor][dragonType] = new[] { dragonDMG, dragonHP, dragonArmor };
            }
            foreach (var type in dragons)
            {
                double avrgDMG = type.Value.Values.Average(average => average[0]);
                double avrgHP = type.Value.Values.Average(average => average[1]);
                double avrgArmor = type.Value.Values.Average(average => average[2]);

                Console.WriteLine($"{type.Key}::({avrgDMG:f2}/{avrgHP:f2}/{avrgArmor:f2})");

                foreach (var dragon in dragons[type.Key])
                {
                    Console.WriteLine($"-{dragon.Key} -> " +
                                  $"damage: {dragon.Value[0]:f0}, " +
                                  $"health: {dragon.Value[1]:f0}, " +
                                  $"armor: {dragon.Value[2]:f0}");
                }
            }

        }
    }
}
