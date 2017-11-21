namespace _06_FoldAndSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = inputList.Length / 4;

            var left = new int[k];
            var middle = new int[k * 2];
            var right = new int[k];

            left = inputList.Take(k).Reverse().ToArray();
            middle = inputList.Skip(k).Take(2 * k).ToArray();
            right = inputList.Reverse().Take(k).ToArray();

            var joinLeftRight = left.Concat(right).ToArray();
            var result = joinLeftRight.Select((x, index) => x + middle[index]).ToArray();

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
