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
            int j = 0;
            while (j < nums.Length)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i += 1;
                }
                j += 1;
            }

            return i;
        }
    }
}