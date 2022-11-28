using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindowMaximum
{
    internal class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var result = new List<int>();
            var max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int x = i;
                if (x + k - 1 < nums.Length)
                {
                    for (int j = 0; j < k; j++)
                    {
                        if (nums[x] > max)
                        {
                            max = nums[x];
                        }
                        x += 1;
                    }
                    result.Add(max);
                }

            }

            return result.ToArray();
        }
    }
}
