using System;

namespace CheckIfNAndItsDoubleExist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            System.Console.WriteLine(sl.CheckIfExist(new int[] {10,2,5,3}));
            System.Console.WriteLine(sl.CheckIfExist(new int[] {7,1,14,11}));
            System.Console.WriteLine(sl.CheckIfExist(new int[] {3,1,7,11}));
            // System.Console.WriteLine(sl.BinarySearch(new int[] {1, 2, 3, 4, 6, 9, 11, 22, 33}, 4.0, 0));
        }
    }
}
