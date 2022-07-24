using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepMultiplyingFoundValuesByTwo
{
    public class Solution
    {
        public int FindFinalValue(int[] nums, int original) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == original)
                {
                    original *= 2;
                    i = -1;
                }
            }
            return original;
        }
    }
}