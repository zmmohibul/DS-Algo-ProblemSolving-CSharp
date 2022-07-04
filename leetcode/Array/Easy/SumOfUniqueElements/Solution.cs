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
            // O(n)
            var numsFreq = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                numsFreq[num] = numsFreq.GetValueOrDefault(num, 0) + 1;
            }

            int sum = 0;
            foreach (var (num, count) in numsFreq)
            {
                if (count == 1)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}