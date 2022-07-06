using System;

namespace CellsWithOddValuesInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            int[][] a = new int[2][];
            a[0] = new int[]{0, 1};
            a[1] = new int[]{1, 1};
            System.Console.WriteLine(sl.OddCells(2, 3, a));
        }
    }
}
