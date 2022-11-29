using System;

namespace MaximumAverageSubarrayI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 12, -5, -6, 50, 3 };
            Console.WriteLine(Solution.FindMaxAverage(arr, 4));
        }
    }
}
