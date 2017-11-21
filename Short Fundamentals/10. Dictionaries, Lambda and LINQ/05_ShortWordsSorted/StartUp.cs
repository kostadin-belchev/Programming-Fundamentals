namespace _05_ShortWordsSorted
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
               .ToLower()
               .Split(new[]
               { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }
               , StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            var output = input
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(String.Join(", ", output));
        }
    }
}
