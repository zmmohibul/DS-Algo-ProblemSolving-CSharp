using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayPartition
{
    public class Solution
    {
        public int ArrayPairSum(int[] nums) 
        {
            Array.Sort(nums);

            var sum = 0;
            for (int j = nums.Length - 1; j > 0; j -= 2)
            {
                sum += Math.Min(nums[j], nums[j - 1]);
            }

            return sum;
        }
    }
}