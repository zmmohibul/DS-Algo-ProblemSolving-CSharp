using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAverageSubarrayI
{
    internal class Solution
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            double maxAverage = sum / k;

            int left = 0;
            for (int right = k; right < nums.Length; right++)
            {
                sum -= nums[left];
                sum += nums[right];
                double average = sum / k;
                if (average > maxAverage)
                {
                    maxAverage = average;
                }
                left += 1;
            }

            return maxAverage;
        }
    }
}
