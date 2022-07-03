using System;

namespace IntersectionOfThreeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            System.Console.WriteLine(s.BinarySearch(new int[] {12, 28, 32, 46, 50, 88, 91, 94, 98}, 32));
        }
    }
}
