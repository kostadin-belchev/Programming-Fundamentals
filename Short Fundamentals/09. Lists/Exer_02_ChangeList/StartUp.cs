namespace Exer_02_ChangeList
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ');
            string action = command[0];

            while (action != "Even" && action != "Odd")
            {
                int element = int.Parse(command[1]);

                if(command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    inputList.Insert(index, element);
                }
                else if (command[0] == "Delete")
                {
                    inputList.RemoveAll(item => item == element);
                }

                command = Console.ReadLine().Split(' ');
                action = command[0];
            }

            foreach (var number in inputList)
            {
                if (command[0] == "Even")
                {
                    if (number % 2 == 0)
                    {
                        Console.Write("{0} ", number);
                    }
                }
                else
                {
                    if (number % 2 != 0)
                    {
                        Console.Write("{0} ", number);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
