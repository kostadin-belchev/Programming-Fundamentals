namespace _08_SumOfOddNumbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var start = 1;
            var sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", start);
                sum += start;
                start += 2;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
