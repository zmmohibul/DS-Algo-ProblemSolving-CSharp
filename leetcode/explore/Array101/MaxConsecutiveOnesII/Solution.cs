using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxConsecutiveOnesII
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums) 
        {
            int maxCount = 0;
            int i = 0;
            int j = 0;
            int lastSeenZero = 0;
            int zeroCount = 0;
            while (j < nums.Length)
            {
                if (nums[j] == 0)
                {
                    zeroCount += 1;
                    if (zeroCount >= 2)
                    {
                        int count = j - i;
                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                        i = lastSeenZero + 1;
                        zeroCount -= 1;
                    }
                    lastSeenZero = j;
                }
                j += 1;
            }
            
            if (j - i > maxCount)
            {
                return j - i;
            }
            else
            {
                return maxCount;
            }
        }
    }
}