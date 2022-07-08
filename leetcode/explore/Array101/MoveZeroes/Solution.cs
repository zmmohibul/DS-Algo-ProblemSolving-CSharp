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
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                    zeroCount += 1;
                }
            }
            int j = nums.Length - 1;
            for (int i = 0; i < zeroCount; i++)
            {
                nums[j] = 0;
                j -= 1;
            }
        }
    }
}