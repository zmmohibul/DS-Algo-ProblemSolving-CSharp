using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivideArrayIntoEqualPairs
{
    public class Solution
    {
        public bool DivideArray(int[] nums) 
        {
            // [3,2,3,2,2,2]
            Array.Sort(nums);
            // [2, 2, 2, 2, 3, 3]
            //           i
            for (int i = 0; i < nums.Length; i++)
            {
                int currNumCount = 1;
                while (i + 1 < nums.Length && nums[i + 1] == nums[i])
                {
                    currNumCount += 1;
                    i += 1;
                }
                if (currNumCount % 2 != 0)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}