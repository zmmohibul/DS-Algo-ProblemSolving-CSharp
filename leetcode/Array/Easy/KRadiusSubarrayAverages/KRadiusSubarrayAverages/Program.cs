using System;

namespace KRadiusSubarrayAverages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 7, 4, 3, 9, 1, 8, 5, 2, 6 };
            var result = Solution.GetAverages(arr, 3);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
