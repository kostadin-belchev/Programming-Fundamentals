using System;


namespace Exer_04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            double energy_after = (double)(energy * volume) / 100;
            double sugar_after = (double)(sugar * volume) / 100;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energy_after, sugar_after);

        }
    }
}
