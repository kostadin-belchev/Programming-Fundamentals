using System;

namespace Exer_01_HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(Greeting(name));

        }

        static string Greeting(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
