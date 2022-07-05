using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NRepeatedElementInSize2NArray
{
    public class Solution
    {
        public int RepeatedNTimes(int[] nums)
        {
            var numSet = new HashSet<int>();

            var numToReturn = 0;
            foreach (var num in nums)
            {
                if (numSet.Contains(num))
                {
                    numToReturn = num;
                    break;
                }
                numSet.Add(num);
            }

            return numToReturn;
        }
    }
}