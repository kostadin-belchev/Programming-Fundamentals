using System;

namespace _07_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            byte years = byte.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0} {1}.\r\nYou are {2} years old.", firstName, lastName, years);
        }
    }
}
