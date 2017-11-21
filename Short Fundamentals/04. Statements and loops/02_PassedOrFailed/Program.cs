namespace _02_PassedOrFailed
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade > 2.99)
            {
                Console.WriteLine("Passed!");
            } else {
                Console.WriteLine("Failed!");
            }

        }
    }
}
