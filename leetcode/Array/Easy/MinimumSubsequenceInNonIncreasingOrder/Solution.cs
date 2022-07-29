using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimumSubsequenceInNonIncreasingOrder
{
    public class Solution
    {
        public IList<int> MinSubsequence(int[] nums) 
        {
            // [3, 4, 8, 9, 10]
            Array.Sort(nums);
            
            var sum = 0;
            // sum = 34
            foreach (var num in nums)
            {
                sum += num;
            }
            
            var subSum = 0;
            var j = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                // subSum = 19
                subSum += nums[i]            ;
                // newSum = 
                var newSum = sum - subSum;
                if (subSum > newSum)
                {
                    j = i;
                    break;
                }
            }
            
            var result = new List<int>();
            var k = nums.Length - 1; 
            while (k >= j)
            {
                result.Add(nums[k]);
                k -= 1;
            }
            
            return result;
        }
    }
}