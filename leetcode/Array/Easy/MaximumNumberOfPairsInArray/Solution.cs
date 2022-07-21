using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaximumNumberOfPairsInArray
{
    public class Solution
    {
        public int[] NumberOfPairs(int[] nums) 
        {
            var d = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                d[num] = d.GetValueOrDefault(num, 0) + 1;
            }
            
            int sameCount = 0;
            int remCount = 0;
            foreach (var (num, count) in d)
            {
                sameCount = sameCount + (count / 2);
                remCount = remCount + (count % 2);
            }
            
            return new int[] {sameCount, remCount};
        }
    }
}