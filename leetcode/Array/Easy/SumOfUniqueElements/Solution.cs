using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumOfUniqueElements
{
    public class Solution
    {
        public int SumOfUnique(int[] nums) 
        {
            // O(n log n)
            int sum = 0;

            // Sort the array
            Array.Sort(nums);

            // Iterate over each element with i index in nums
            int i = 0;
            for (i = 0; i < nums.Length - 1; i++)
            {
                int ithElement = nums[i];
                if (nums[i] != nums[i + 1])
                {
                    sum += nums[i];
                }
                else
                {
                    while (nums[i + 1] == ithElement)
                    {
                        i += 1;
                        if (i >= nums.Length - 1)
                        {
                            break;
                        }
                    }
                }

            }
            
            if (i == 0)
            {
                return nums[i];
            }
            else if (i < nums.Length)
            {
                if (nums[i] != nums[i - 1])
                {
                    sum += nums[i];
                }
            }
            return sum;
        }
    }
}