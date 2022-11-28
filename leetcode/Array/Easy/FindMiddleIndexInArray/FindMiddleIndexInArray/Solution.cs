using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMiddleIndexInArray
{
    internal class Solution
    {
        public static int FindMiddleIndex(int[] nums)
        {
            var leftIndexSum = new Dictionary<int, int>();
            var leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                leftIndexSum[i] = leftSum;
                leftSum += nums[i];
            }

            var rightIndexSum = new Dictionary<int, int>();
            var rightSum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                rightIndexSum[i] = rightSum;
                rightSum += nums[i];
            }

            foreach (var (ind, sum) in leftIndexSum)
            {
                if (rightIndexSum[ind] == sum)
                {
                    return ind;
                }
            }

            return -1;
        }
    }
}
