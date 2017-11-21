namespace Exer_03_UnicodeCharacters
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Console.WriteLine(GetUnicodeString(input));
        }

        public static string GetUnicodeString(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char letter in input)
            {
                sb.Append("\\u");
                //Original way: sb.Append(String.Format("{0:x4}", (int)letter));
                //Judge is giving Time limit error on some of the tests, so I had to change it.
                sb.Append(((int)letter).ToString("x4"));
            }
            return sb.ToString();
        }
    }
}
