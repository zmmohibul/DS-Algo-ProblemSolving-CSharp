using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDisappearedNumbersInArray
{
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums) 
        {
            List<int> result = new List<int>();
            HashSet<int> numsSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numsSet.Add(nums[i]);
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!numsSet.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}