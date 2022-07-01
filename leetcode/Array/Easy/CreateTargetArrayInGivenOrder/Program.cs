using System;

namespace CreateTargetArrayInGivenOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Solution.CreateTargetArray(new int[]{0,1,2,3,4}, new int[]{0,1,2,2,1});
            foreach (var n in r)
            {
                Console.Write($"{n} ");
            }
            System.Console.WriteLine();
        }
    }
}
