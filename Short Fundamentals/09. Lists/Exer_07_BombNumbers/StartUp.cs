namespace Exer_07_BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int specialNumber = bombArgs[0];
            int bombPower = bombArgs[1];
            bool stoppedDetonation = true;

            var remainingLeft = new List<int>();
            var remainingRight = new List<int>();

            int startIndex = 0;
            int detonated = 0;

            while (stoppedDetonation)
            {
                stoppedDetonation = false;

                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] == specialNumber)
                    {
                        startIndex = i - bombPower;
                        if(startIndex < 0)
                        {
                            startIndex = 0;
                        }

                        detonated = i + bombPower + 1;

                        if (detonated > inputList.Count)
                        {
                            detonated = inputList.Count;
                        }
                        stoppedDetonation = true;
                        break;
                    }
                }

                if (stoppedDetonation)
                {
                    remainingLeft = inputList.Take(startIndex).ToList();
                    remainingRight = inputList.Skip(detonated).ToList();


                    inputList = remainingLeft;
                    inputList.AddRange(remainingRight);
                }
            }
            int sum = inputList.Sum();
            Console.WriteLine(sum);
        }
    }
}
