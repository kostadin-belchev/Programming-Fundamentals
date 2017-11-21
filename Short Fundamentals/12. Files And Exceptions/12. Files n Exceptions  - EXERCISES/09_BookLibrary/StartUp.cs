namespace _09_BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _09_BookLibrary.Classes;
    using System.IO;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {

            var input = File.ReadAllLines(@"Text files\Input.txt");
            var library = AddBooks(input);
            int indexer = 0;
            int booksNumber = int.Parse(input[indexer++]);

            var pricesByAuthors = new Dictionary<string, decimal>();

            foreach (var book in library.Books)
            {
                if (!pricesByAuthors.ContainsKey(book.Author))
                {
                    pricesByAuthors[book.Author] = 0m;
                }

                pricesByAuthors[book.Author] += book.Price;
            }

            var result = pricesByAuthors
                .OrderByDescending(p => p.Value)
                .ThenBy(a => a.Key)
                .ToArray();

            var output = new List<string>();

            foreach (var author in result)
            {
                output.Add($"{author.Key} -> {author.Value:f2}");
            }
            File.WriteAllLines(@"Text files\Output.txt", output);
        }

        public static Library AddBooks(string[] input)
        {
            var library = new Library
            {
                Name = "Slaweykow",
                Books = new List<Book>()
            };

            int indexer = 0;
            int booksNumber = int.Parse(input[indexer++]);

            for (int i = 0; i < booksNumber; i++)
            {
                string[] informationArray = input[indexer++]
                    .Split(' ')
                    .ToArray();

                var book = new Book
                {
                    Title = informationArray[0],
                    Author = informationArray[1],
                    Publisher = informationArray[2],
                    ReleaseDate = DateTime
                        .ParseExact(informationArray[3]
                            , "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = informationArray[4],
                    Price = decimal.Parse(informationArray[5])
                };

                library.Books.Add(book);
            }
            return library;
        }
    }
}
