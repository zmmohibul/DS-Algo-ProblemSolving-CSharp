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
            // Brute Force O(n^2)
            int sum = 0;
            // Iterate over each element with i index in nums
            for (int i = 0; i < nums.Length; i++)
            {
                int ithElement = nums[i];
                // Check if the i th element exist in rest of the array
                bool ithElementFound = false;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i)
                    {
                        if (nums[j] == ithElement)
                        {
                            ithElementFound = true;
                            break;
                        }
                    }
                }

                // If ith element not found in rest of array add it to sum
                if (!ithElementFound)
                {
                    sum += ithElement;
                }
            }
            return sum;
        }
    }
}