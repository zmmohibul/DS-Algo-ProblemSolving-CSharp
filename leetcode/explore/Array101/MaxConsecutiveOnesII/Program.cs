using System;

namespace MaxConsecutiveOnesII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            System.Console.WriteLine(sl.FindMaxConsecutiveOnes(new int[] {1, 0, 1, 1, 0}));
        }
    }
}
