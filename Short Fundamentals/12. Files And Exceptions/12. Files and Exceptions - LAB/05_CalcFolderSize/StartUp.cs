namespace _05_CalcFolderSize
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] files = Directory.GetFiles("TestFolder");
                double sum = 0;

                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    sum += fileInfo.Length;
                }
                sum = sum / 1024 / 1024;
                File.WriteAllText(@"Text files\Output.txt", sum.ToString());
            }
            catch
            {
                Console.WriteLine("Cannot find directory / write output.");
            }
        }
    }
}
