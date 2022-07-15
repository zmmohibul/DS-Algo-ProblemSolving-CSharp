using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoSumII
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            while (j > i)
            {
                int sum = numbers[i] + numbers[j];
                if (sum > target)
                {
                    j -= 1;
                }
                else if (sum < target)
                {
                    i += 1;
                }
                else
                {
                    break;
                }
            }

            return new int[] {i+1, j+1};
        }
    }
}