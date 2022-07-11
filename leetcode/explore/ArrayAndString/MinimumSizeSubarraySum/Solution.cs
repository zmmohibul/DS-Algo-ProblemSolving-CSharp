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
            int sum = 0;
            int i = 0;
            int minCount = 0;
            while (sum < target && i < nums.Length)
            {
                sum += nums[i];
                i += 1;
                minCount += 1;
            }

            if (i == nums.Length && sum < target)
            {
                return 0;
            }

            int j = 0;
            int count = minCount;
            while (i < nums.Length)
            {
                if (sum >= target)
                {
                    sum -= nums[j];
                    count -= 1;
                    j += 1;
                }
                else
                {
                    sum += nums[i];
                    count += 1;
                    i += 1;
                }
                if (count < minCount && sum >= target)
                {
                    minCount = count;
                }
            }
            
            while (j < nums.Length)
            {
                sum -= nums[j];
                if (sum >= target)
                {
                    count -= 1;
                }
                else
                {
                    break;
                }

                j += 1;
                if (count < minCount && sum >= target)
                {
                    minCount = count;
                }
            }

            return minCount;
        }
    }
}