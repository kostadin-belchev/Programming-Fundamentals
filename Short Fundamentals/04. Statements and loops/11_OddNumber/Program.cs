namespace _11_OddNumber
{
    using System;
    
    class StartUp
    {
        static void Main()
        {
            while (true)
            {
                var number = Math.Abs(int.Parse(Console.ReadLine()));

                if (number % 2 == 1)
                {
                    Console.WriteLine("The number is: {0}", number);
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                
                }
            }
        }
    }
}
