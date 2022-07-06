using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CellsWithOddValuesInMatrix
{
    public class Solution
    {
        public int OddCells(int m, int n, int[][] indices) 
        {
            int[,] matrix = new int[m, n];
            
            foreach (var index in indices)
            {
                var r = index[0];
                var c = index[1];
                for (int row = 0; row < m; r++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        if (row == r || column == c)
                        {
                            matrix[row, column] += 1;
                        }
                    }
                }
            }

            foreach (var item in matrix)
            {
                Console.Write($"{item}, ");
            }

            return 0;
        }
    }
}