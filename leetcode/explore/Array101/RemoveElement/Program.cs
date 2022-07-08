using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            var arr = new int[]{3, 2, 2, 3, 4, 6, 3, 1};
            int l = sl.RemoveElement(arr, 3);
            for (int i = 0; i < l; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            System.Console.WriteLine();
        }
    }
}
