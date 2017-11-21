using System;

namespace Exer_05_CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var current_health = int.Parse(Console.ReadLine());
            var maximum_health = int.Parse(Console.ReadLine());
            var current_energy = int.Parse(Console.ReadLine());
            var maximum_energy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Health: |{0}{1}|", new String('|', current_health), new String('.', maximum_health - current_health));
            Console.WriteLine("Energy: |{0}{1}|", new String('|', current_energy), new String('.', maximum_energy - current_energy));
        }
    }
}
