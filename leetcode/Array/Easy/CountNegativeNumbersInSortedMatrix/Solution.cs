using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountNegativeNumbersInSortedMatrix
{
    public class Solution
    {
        public int CountNegatives(int[][] grid) 
        {
            var count = 0;
            foreach (var row in grid)
            {
                for (int i = row.Length - 1; i >= 0; i--)
                {
                    if (row[i] < 0)
                    {
                        count += 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return count;
        }
    }
}