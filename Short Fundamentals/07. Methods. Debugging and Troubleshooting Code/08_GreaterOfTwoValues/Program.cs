using System;

namespace _08_GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            TypeCheck(type);
        }

        static void TypeCheck(string type)
        {
            if (type == "int")
            {

                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Max(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine((char)Math.Max(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                if (first.CompareTo(second) == 1)
                {
                    Console.WriteLine(first);
                }
                else if (first.CompareTo(second) == -1)
                {
                    Console.WriteLine(second);
                }
            }
        }
    }
}
