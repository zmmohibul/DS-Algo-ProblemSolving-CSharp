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
            int[][] matrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
            }

            foreach (var index in indices)
            {
                var r = index[0];
                var c = index[1];
                for (int row = 0; row < m; row++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        if (row == r)
                        {
                            matrix[row][column] += 1;
                        }

                        if (column == c)
                        {
                            matrix[row][column] += 1;
                        }
                    }
                }
            }

            var oddCount = 0;
            foreach (var row in matrix)
            {
                foreach (var column in row)
                {
                    if (column % 2 != 0)
                    {
                        oddCount += 1;
                    }
                }
            }

            return oddCount;
        }
    }
}