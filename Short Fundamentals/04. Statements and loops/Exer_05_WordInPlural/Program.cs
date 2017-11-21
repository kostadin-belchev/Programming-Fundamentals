namespace Exer_05_WordInPlural
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input.EndsWith("y"))
            {
                input = input.Remove(input.Length - 1);
                input += "ies";
            }
            else if (input.EndsWith("o")
                || input.EndsWith("ch") 
                || input.EndsWith("s")
                || input.EndsWith("sh") 
                || input.EndsWith("x")
                || input.EndsWith("z"))
            {
                input += "es";
            }
            else
            {
                input += "s";
            }
            Console.WriteLine(input);
        }
    }
}
