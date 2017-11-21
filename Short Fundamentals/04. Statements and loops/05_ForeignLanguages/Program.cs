namespace _05_ForeignLanguages
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var country = Console.ReadLine().ToLower();

            if (country == "usa" || country == "england")
            {
                Console.WriteLine("English");
            }
            else if (country == "spain" || country == "argentina" || country == "mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
