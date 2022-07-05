using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NRepeatedElementInSize2NArray
{
    public class Solution
    {
        public int RepeatedNTimes(int[] nums)
        {
            Array.Sort(nums);
            
            var numToReturn = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    numToReturn = nums[i];
                    break;
                }
            }

            return numToReturn;
        }
    }
}