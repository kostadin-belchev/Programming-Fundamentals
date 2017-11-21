namespace Exer_05_ArrayManipulator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while (command != "print")
            {
                var commandArgs = command.Split(' ').ToArray();

                switch (commandArgs[0])
                {
                    case "add":
                        inputList.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                        break;

                    case "addMany":
                        inputList.InsertRange(int.Parse(commandArgs[1]), 
                            commandArgs.Skip(2).Select(int.Parse).ToList());
                        break;

                    case "contains":
                        var number = int.Parse(commandArgs[1]);
                        Console.WriteLine(inputList.IndexOf(number));
                        break;

                    case "remove":
                        inputList.RemoveAt(int.Parse(commandArgs[1]));
                        break;

                    case "shift":
                        var shiftNumber = int.Parse(commandArgs[1]);
                        shiftNumber = shiftNumber % inputList.Count;
                        var rem = inputList.Take(shiftNumber).ToList();
                        inputList.RemoveRange(0, shiftNumber);
                        inputList.AddRange(rem);
                        break;

                    case "sumPairs":
                        for (int i = 0; i < inputList.Count - 1; i++)
                        {
                            var sum = inputList[i] + inputList[i + 1];
                            inputList[i] = sum;
                            inputList.RemoveAt(i + 1);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", String.Join(", ", inputList));
        }
    }
}
