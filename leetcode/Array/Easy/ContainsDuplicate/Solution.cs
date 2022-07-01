using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums) 
        {
            var numsSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!numsSet.Contains(num))
                {
                    numsSet.Add(num);
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}