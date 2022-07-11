using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimumSizeSubarraySum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                if (nums[0] == target)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            Array.Sort(nums);
            int j = nums.Length - 1;
            int sum = 0;
            int count = 0;
            while (j >= 0)
            {
                sum += nums[j];
                count += 1;
                j -= 1;
                if (sum >= target)
                {
                    return target;
                }
            }

            return 0;
        }
    }
}