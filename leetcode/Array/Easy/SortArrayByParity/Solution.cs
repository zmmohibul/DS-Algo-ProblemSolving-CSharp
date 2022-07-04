using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortArrayByParity
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums) 
        {
            List<int> odds = new List<int>();

            int[] result = new int[nums.Length];
            int rInd = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result[rInd] = nums[i];
                    rInd += 1;
                }
                else
                {
                    odds.Add(nums[i]);
                }
            }

            for (int i = 0; i < odds.Count; i++)
            {
                result[rInd] = odds[i];
                rInd += 1;
            }

            return result;
        }
    }
}