namespace _01_Passed
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
