namespace Exer_05_BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Exer_05_BookLibrary.Classes;

    public class StartUp
    {
        public static void Main()
        {
            var booksNumber = int.Parse(Console.ReadLine());
            var library = new Library
            {
                Name = "Slaweykow",
                Books = new List<Book>()
            };

            var pricesByAuthors = new Dictionary<string, decimal>();

            for (int i = 0; i < booksNumber; i++)
            {
                var currentBook = GetBookInfo();
                library.Books.Add(currentBook);
            }

            foreach (var book in library.Books)
            {
                if (!pricesByAuthors.ContainsKey(book.Author))
                {
                    pricesByAuthors[book.Author] = 0m;
                }

                pricesByAuthors[book.Author] += book.Price;
            }

            PrintResult(pricesByAuthors);

        }

        public static Book GetBookInfo()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var currentBook = new Book
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = input[4],
                Price = decimal.Parse(input[5])
            };

            return currentBook;
        }

        public static void PrintResult(Dictionary<string, decimal> pricesByAuthors)
        {
            var result = pricesByAuthors
                .OrderByDescending(p => p.Value)
                .ThenBy(a => a.Key)
                .ToArray();

            foreach (var author in result)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }
}
