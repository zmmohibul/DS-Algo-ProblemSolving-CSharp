using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumOfDigitsInMinimumNumber
{
    public class Solution
    {
        public int SumOfDigits(int[] nums) 
        {
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            List<int> minSplitted = new List<int>();
            while (min > 0)
            {
                minSplitted.Add(min % 10);
                min = min / 10;
            }

            int minSplittedSum = 0;
            for (int i = 0; i < minSplitted.Count; i++)
            {
                minSplittedSum += minSplitted[i];
            }

            if (minSplittedSum % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}