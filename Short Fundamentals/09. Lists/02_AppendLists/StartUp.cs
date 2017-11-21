namespace _02_AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split('|').Reverse().ToList();
            var outputList = new List<int>();

            foreach (var smallerList in inputList)
            {
                var listToAdd = smallerList.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                outputList.AddRange(listToAdd);
            }

            Console.WriteLine(String.Join(" ", outputList));
        }
    }
}
