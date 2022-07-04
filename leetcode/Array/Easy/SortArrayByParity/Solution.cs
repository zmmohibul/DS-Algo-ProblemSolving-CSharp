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
            List<int> evens = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens.Add(nums[i]);
                }
                else
                {
                    odds.Add(nums[i]);
                }
            }

            int[] result = new int[nums.Length];
            int rInd = 0;
            for (int i = 0; i < evens.Count; i++)
            {
                result[rInd] = evens[i];
                rInd += 1;
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