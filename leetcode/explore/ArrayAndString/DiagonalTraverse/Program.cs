using System;

namespace DiagonalTraverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // var mat = new int[5][];
            // int n = 1;
            // for (int i = 0; i < 5; i++)
            // {
            //     var row = new int[6];
            //     for (int j = 0; j < 6; j++)
            //     {
            //         row[j] = n;
            //         n += 1;
            //     }
            //     mat[i] = row;
            // }

            var mat = new int[2][];
            int n = 1;
            for (int i = 0; i < 2; i++)
            {
                var row = new int[4];
                for (int j = 0; j < 4; j++)
                {
                    row[j] = n;
                    n += 1;
                }
                mat[i] = row;
            }

            System.Console.WriteLine();

            Solution sl = new Solution();
            sl.FindDiagonalOrder(mat);
            System.Console.WriteLine();

            // foreach (var row in mat)
            // {
            //     foreach (var num in row)
            //     {
            //         Console.Write(num + " ");
            //     }
            //     Console.WriteLine();
            // }
            // System.Console.WriteLine();
        }
    }
}
