using System;

namespace MinimumSizeSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            System.Console.WriteLine(sl.MinSubArrayLen(16, new int[] {1, 1, 3, 4, 4, 5, 6, 9}));
        }
    }
}
