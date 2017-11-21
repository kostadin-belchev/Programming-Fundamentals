namespace Exer_14_MagicLetter
{
    using System;

    class StartUp
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (i.Equals(skip) == false
                        && j.Equals(skip) == false
                        && k.Equals(skip) == false)
                            {
                                Console.WriteLine("{0}{1}{2}", i, j, k);
                            }
                    }
                }
            }
        }
    }
}
