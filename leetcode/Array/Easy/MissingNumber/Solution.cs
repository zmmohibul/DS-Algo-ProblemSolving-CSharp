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
            var sum = 0;
            foreach (var n in nums)
            {
                sum += n;
            }

            var expectedSum = (nums.Length * (nums.Length + 1)) / 2;
            return expectedSum - sum;
        }
    }
}