namespace Exer_13_GameOfNumbers
{
    using System;

    class StartUp
    {

    static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool found = false;
            int first = 0;
            int second = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;

                    if (i + j == magicNumber)
                    {
                        found = true;
                        first = i;
                        second = j;
                    }
                }
            }
            if (found == true)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", first, second, first + second);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            }
        }
    }
}
