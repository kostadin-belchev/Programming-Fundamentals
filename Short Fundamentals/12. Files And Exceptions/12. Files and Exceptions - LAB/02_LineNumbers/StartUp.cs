namespace _02_LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] inputLines = File.ReadAllLines(@"Text files\Input.txt");
                var outputLines = new List<string>();

                for (int i = 0; i < inputLines.Length; i++)
                {
                    string currentLine = $"{i + 1}. {inputLines[i]}";
                    outputLines.Add(currentLine);
                }

                File.WriteAllLines(@"Text files\Output.txt", outputLines);
            }
            catch (Exception)
            {
                Console.WriteLine("Not able to read input / write output.");
            }
        }
    }
}
