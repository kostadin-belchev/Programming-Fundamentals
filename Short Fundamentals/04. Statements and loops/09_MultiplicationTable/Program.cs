namespace _09_MultiplicationTable
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var integer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", integer, i, integer * i);
            }
        }
    }
}
