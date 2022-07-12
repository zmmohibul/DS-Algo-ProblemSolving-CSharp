using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixDiagonalSum
{
    public class Solution
    {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;

            int i = 0;
            int j = 0;
            for (int k = 0; k < mat.Length; k++)
            {
                Console.Write(mat[i][j] + " ");
                sum += mat[i][j];
                i += 1;
                j += 1;
            }

            Console.WriteLine();

            i = 0;
            j = mat[0].Length - 1;
            for (int k = 0; k < mat.Length; k++)
            {
                Console.Write(mat[i][j] + " ");
                sum += mat[i][j];
                i += 1;
                j -= 1;
            }

            Console.WriteLine();

            if (mat.Length % 2 != 0)
            {
                sum -= mat[mat.Length / 2][mat.Length / 2];
            }
            
            return sum;
        }
    }
}