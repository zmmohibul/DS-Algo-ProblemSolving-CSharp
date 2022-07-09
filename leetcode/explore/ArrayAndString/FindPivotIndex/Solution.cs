using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindPivotIndex
{
    public class Solution
    {
        public int PivotIndex(int[] nums) 
        {
            var iSumDict = new Dictionary<int, int>();
            var iSum = 0;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                iSum += nums[i];
                iSumDict[i] = iSum;
            }
            
            if (iSum == 0)
            {
                return nums.Length - 1;
            }
            
            var jSum = 0;
            var j = 0;
            for (j = nums.Length - 1; j > 1; j--)
            {
                jSum += nums[j];
                if (iSumDict[j - 2] == jSum)
                {
                    return j - 1;
                }
            }
            
            jSum += nums[j];
            if (jSum == 0)
            {
                return 0;
            }
            
            return -1;
        }
    }
}