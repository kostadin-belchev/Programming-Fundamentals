namespace Exer_02_AdvertisementMessage
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] opinions =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] feelings =
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random randomizer = new Random();

            int messagesToGenerate = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesToGenerate; i++)
            {
                int opinionsIndex = randomizer.Next(0, opinions.Length);
                int feelingsIndex = randomizer.Next(0, feelings.Length);
                int authorIndex = randomizer.Next(0, authors.Length);
                int cityIndex = randomizer.Next(0, cities.Length);

                Console.WriteLine($"{opinions[opinionsIndex]} " +
                                  $"{feelings[feelingsIndex]} " +
                                  $"{authors[authorIndex]} - " +
                                  $"{cities[cityIndex]}.");
            }
        }
    }
}
