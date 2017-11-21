using System;


namespace _02_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var sum = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
        }
    }
}
