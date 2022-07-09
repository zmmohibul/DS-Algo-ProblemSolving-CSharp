using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoveZeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums) 
        {
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) 
                {
                    zeroCount += 1;
                }
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    int j = i;
                    while (j < nums.Length - 1)
                    {
                        nums[j] = nums[j + 1];
                        j += 1;
                    }
                    nums[j] = 0;
                }
                if (nums[i] == 0 && i < nums.Length - zeroCount)
                {
                    i -= 1;
                }
            }
        }
    }
}