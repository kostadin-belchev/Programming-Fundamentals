namespace Exer_06_BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Exer_06_BookLibraryModification.Classes;

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

            for (int i = 0; i < booksNumber; i++)
            {
                var currentBook = GetBookInfo();
                library.Books.Add(currentBook);
            }

            var titlesAfterDate = new Dictionary<string, DateTime>();
            var specificDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Books)
            {
                if (!titlesAfterDate.ContainsKey(book.Title) && book.ReleaseDate > specificDate)
                {
                    titlesAfterDate[book.Title] = book.ReleaseDate;
                }
            }

            var result = titlesAfterDate
               .OrderBy(d => d.Value)
               .ThenBy(t => t.Key)
               .ToArray();


            foreach (var title in result)
            {
                Console.WriteLine($"{title.Key} -> {title.Value:dd.MM.yyy}");
            }
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
    }
}

