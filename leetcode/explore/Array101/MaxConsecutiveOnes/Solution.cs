using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxConsecutiveOnes
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums) 
        {
            var currCount = 0;
            var count = 0;
            // [1,1,0,1,1,1]
            //              i
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currCount = 1;
                    i += 1;
                    while (i < nums.Length && nums[i] == 1)
                    {
                        currCount += 1;
                        i += 1;
                    }
                    if (currCount > count)
                    {
                        count = currCount;
                    }
                }
            }
            
            return count;
        }
    }
}