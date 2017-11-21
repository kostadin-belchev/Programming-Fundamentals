namespace Exer_03_CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string inputText = Console.ReadLine();

            string pattern = @"\|<\w+";
            int skipElem = numbers[0];
            int takeElem = numbers[1];

            var camerasMatches = Regex.Matches(inputText, pattern);
            var cameras = (from Match camera in camerasMatches select camera.Value)
                .ToArray();
            var views = new List<String>();

            foreach (string view in cameras)
            {
                string currentView = view;

                currentView = currentView.Replace("|<", "");

                var filter = currentView
                    .ToCharArray()
                    .Skip(skipElem)
                    .Take(takeElem);

                string viewResult = string.Join("", filter);
                views.Add(viewResult);
            }

            Console.WriteLine(string.Join(", ", views));
        }
    }
}
