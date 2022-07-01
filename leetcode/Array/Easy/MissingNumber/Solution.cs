using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissingNumber
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            var numsSet = new HashSet<int>();
            foreach (var num in nums)
            {
                numsSet.Add(num);
            }

            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsSet.Contains(i))
                {
                    ans = i;
                    break;
                }
            }
            return ans;
        }
    }
}