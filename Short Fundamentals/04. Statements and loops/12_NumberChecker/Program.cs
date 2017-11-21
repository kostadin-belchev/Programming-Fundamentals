namespace _12_NumberChecker
{
    using System;

    class StartUp
    {
        static void Main()
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
