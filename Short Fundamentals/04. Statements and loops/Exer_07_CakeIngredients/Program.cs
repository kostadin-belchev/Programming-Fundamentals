namespace Exer_07_CakeIngredients
{
    using System;

    class StartUp
    {
        static void Main()
        {
            
            int n = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Bake!")
                {
                    break; 
                }
                    Console.WriteLine("Adding ingredient {0}.", command);
                    n++; 
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", n);
        }
    }
}
