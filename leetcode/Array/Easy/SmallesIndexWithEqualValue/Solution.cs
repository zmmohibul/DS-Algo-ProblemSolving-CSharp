using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallesIndexWithEqualValue
{
    public class Solution
    {
        public int SmallestEqual(int[] nums) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 10 == nums[i])
                {
                    return i;
                }
            }
            
            return -1;
        }
    }
}