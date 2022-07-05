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
            var numFreq = new Dictionary<int, int>();
            var numToReturn = 0;
            foreach (var num in nums)
            {
                numFreq[num] = numFreq.GetValueOrDefault(num, 0) + 1;
                if (numFreq[num] > 1)
                {
                    numToReturn = num;
                    break;
                }
            }

            return numToReturn;
        }
    }
}