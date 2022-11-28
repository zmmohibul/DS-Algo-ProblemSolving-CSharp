using System;

namespace FindMiddleIndexInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[] { 2, 3, -1, 8, 4 };
            var arr2 = new int[] { 1, -1, 4 };
            var arr3 = new int[] { 2, 5 };
            Console.WriteLine(Solution.FindMiddleIndex(arr1));
            Console.WriteLine(Solution.FindMiddleIndex(arr2));
            Console.WriteLine(Solution.FindMiddleIndex(arr3));
        }
    }
}
