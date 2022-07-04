using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquaresOfASortedArray
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums) 
        {
            var numsSquared = new int[nums.Length];
            int i = 0;
            while (i < nums.Length && nums[i] < 0)
            {
                i += 1;
            }

            int j = 0;
            int k = 0;
            if (i == 0)
            {
                while (i < nums.Length)
                {
                    numsSquared[j] = nums[i] * nums[i];
                    i += 1;
                    j += 1;
                }
            }
            else if (i == nums.Length)
            {
                while (i > 0)
                {
                    i = i - 1;
                    numsSquared[j] = nums[i] * nums[i];
                    j += 1;
                }
            }
            else
            {
                j = i - 1;
                while (j >= 0 && i < nums.Length)
                {
                    var jSq = nums[j] * nums[j];
                    var iSq = nums[i] * nums[i];
                    if (jSq > iSq)
                    {
                        numsSquared[k] = iSq;
                        k += 1;
                        i += 1;
                    }
                    else if (iSq >= jSq)
                    {
                        numsSquared[k] = jSq;
                        k += 1;
                        j -= 1;
                    }
                }

                if (i < nums.Length)
                {
                    while (i < nums.Length)
                    {
                        numsSquared[k] = nums[i] * nums[i];
                        i += 1;
                        k += 1;
                    }
                }
                else if (j >= 0)
                {
                    while (j >= 0)
                    {
                        numsSquared[k] = nums[j] * nums[j];
                        j -= 1;
                        k += 1;
                    }
                }
            }
            return numsSquared;
        }
    }
}