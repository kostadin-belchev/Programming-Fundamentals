namespace Exer_15_NeighbourWars
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int peshoDMG = int.Parse(Console.ReadLine());
            int goshoDMG = int.Parse(Console.ReadLine());

            int peshoHP = 100;
            int goshoHP = 100;
            int counter = 1;

            while(true)
            {
                if (counter % 2 == 1)
                {
                    goshoHP -= peshoDMG;
                    
                    if (goshoHP <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", counter);
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHP);
                }
                else if(counter % 2 == 0)
                {
                    peshoHP -= goshoDMG;

                    if (peshoHP <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", counter);
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHP);
                }

                if(counter % 3 == 0)
                {
                    goshoHP += 10;
                    peshoHP += 10;
                }
                counter++;
            }

        }
    }
}
