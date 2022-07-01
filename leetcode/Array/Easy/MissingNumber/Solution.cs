using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissingNumber
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int sum = 0;
            for (int i = 1; i <= nums.Length; i++)
            {
                sum += nums[i];
            }

            int expectedSum = (nums.Length * (nums.Length + 1)) / 2;
            return expectedSum - sum;
        }
    }
}