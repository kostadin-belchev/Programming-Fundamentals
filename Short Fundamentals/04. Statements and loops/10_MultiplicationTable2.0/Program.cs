namespace _10_MultiplicationTable2._0
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var integer = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            if (integer > 10 || n > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", integer, n, integer * n);
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i >= n)
                    {
                        Console.WriteLine("{0} X {1} = {2}", integer, n, integer * n);
                        n++;
                    }
                }
            }
        }
    }
}
