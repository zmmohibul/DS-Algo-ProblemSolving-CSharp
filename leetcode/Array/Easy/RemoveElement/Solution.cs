using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val) 
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i += 1;
                }
            }

            return i;
        }
    }
}