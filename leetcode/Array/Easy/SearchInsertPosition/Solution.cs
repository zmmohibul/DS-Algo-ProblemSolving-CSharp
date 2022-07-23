using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target) 
        {
            int mid = 0;
            int j = nums.Length - 1;
            int i = 0;
            
            while (j >= i)
            {
                mid = (i + j) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    i = mid + 1;
                }
                else if (target < nums[mid])
                {
                    j = mid - 1;
                }
            }
            
            if (target > nums[mid])
            {
                return i;
            }
            else
            {
                return j + 1;
            }
        }
    }
}