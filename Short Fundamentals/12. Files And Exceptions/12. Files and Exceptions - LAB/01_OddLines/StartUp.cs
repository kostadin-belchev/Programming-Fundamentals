namespace _01_OddLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] inputText = File.ReadAllLines(@"Text files\Input.txt");
                string[] oddLines = inputText
                    .Where((inpTxt, i) => i % 2 == 1)
                    .ToArray();
                File.WriteAllLines(@"Text files\Output.txt", oddLines);
            }
            catch (Exception)
            {
                Console.WriteLine("Not able to read input / write output.");
            }
        }
    }
}
