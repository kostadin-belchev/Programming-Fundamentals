namespace Exer_09_CountTheIntegers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int counter = 0;
            while (true)
            {
                string userInput = Console.ReadLine();

                int value;
                if (int.TryParse(userInput, out value))
                {
                    counter+= 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
