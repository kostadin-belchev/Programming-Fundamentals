namespace _04_MergeFiles
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
                var firstFile = File.ReadAllLines(@"Text files\FileOne.txt");
                var secondFile = File.ReadAllLines(@"Text files\FileTwo.txt");

                var output = new List<string>();

                for (int i = 0; i < firstFile.Length; i++)
                {
                    output.Add(firstFile[i]);
                    output.Add(secondFile[i]);
                }

                File.WriteAllLines(@"Text files\Output.txt", output);
            }
            catch
            {
                Console.WriteLine("Cannot read input / write output.");
            }
        }
    }
}
