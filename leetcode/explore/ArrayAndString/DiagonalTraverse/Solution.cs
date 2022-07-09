using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagonalTraverse
{
    public class Solution
    {
        public void FindDiagonalOrder(int[][] mat) 
        {
            int m = mat.Length;
            int n = mat[0].Length;
            System.Console.WriteLine(m);
            System.Console.WriteLine(n);

            var diagonals = new string[m*n];
            diagonals[0] = $"{m} {n}";

            for (int i = 1; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    int a = 0;
                    int b = i;
                    for (int j = 0; j < m && j <= i; j++)
                    {
                        Console.Write(mat[a][b] + " ");
                        // Console.Write($"{a}{b} ");
                        a += 1;
                        b -= 1;
                    }
                }
                else
                {
                    int a = i;
                    int b = 0;
                    for (int j = 0; j < m && j <= i; j++)
                    {
                        Console.Write(mat[a][b] + " ");
                        // Console.Write($"{a}{b} ");
                        a -= 1;
                        b += 1;
                    }
                }
                System.Console.WriteLine();
                
            }
        }
    }
}