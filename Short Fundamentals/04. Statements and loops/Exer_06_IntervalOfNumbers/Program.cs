namespace Exer_06_IntervalOfNumbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int n = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                Console.WriteLine(num2);
                for (int i = 1; i <= n; i++)
                {
                   
                    Console.WriteLine("{0}", num2 += 1);
                }
            }
            else if (num2 > num1)
            {
                Console.WriteLine(num1);
                for (int i = 1; i <= n; i++)
                {
                    
                    Console.WriteLine("{0}", num1 += 1);
                }
            }
        }
    }
}
