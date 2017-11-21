namespace Exer_03_SearchForNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var outputList = new List<int>();

            for (int i = 0; i < command[0]; i++)
            {
                outputList.Add(inputList[i]);
            }

            outputList.RemoveRange(0, command[1]);

            foreach (var number in outputList)
            {
                if (number == command[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }
                
            }
            Console.WriteLine("NO!");
        }
    }
}
