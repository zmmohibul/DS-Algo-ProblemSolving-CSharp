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
        }
    }
}
