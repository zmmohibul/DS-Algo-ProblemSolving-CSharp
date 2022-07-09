using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdMaximumNumber
{
    public class Solution
    {
        public int ThirdMax(int[] nums) 
        {
            // [3,2,1]
            //      j
            Array.Sort(nums);
            int j = 1;
            int ucount = 1;
            while (j < nums.Length)
            {
                if (nums[j - 1] != nums[j])
                {
                    ucount += 1;
                    if (ucount == 3)
                    {
                        return nums[j];
                    }
                }
                j += 1;
            }

            return nums[0];
        }
    }
}