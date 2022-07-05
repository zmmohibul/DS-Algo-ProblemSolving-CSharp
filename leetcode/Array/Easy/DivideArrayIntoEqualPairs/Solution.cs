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
            var numFreq = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                numFreq[num] = numFreq.GetValueOrDefault(num, 0) + 1;
            }

            foreach (var count in numFreq.Values)
            {
                if (count % 2 != 0)
                {
                    return false;
                }
            }

            return true;            
        }
    }
}