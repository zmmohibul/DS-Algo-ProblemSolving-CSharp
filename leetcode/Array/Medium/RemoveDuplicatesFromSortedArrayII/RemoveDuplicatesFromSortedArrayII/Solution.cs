using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArrayII
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var freq = new Dictionary<int, int>();
            freq[nums[0]] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                freq[nums[i]] = freq.GetValueOrDefault(nums[i], 0) + 1;
            }

            int j = 0;
            int k = 0;
            for (int a = 0; a < freq.Count; a++)
            {
                if (freq[nums[k]] >= 2)
                {
                    int kn = nums[k];
                    int kc = freq[nums[k]];
                    k += kc;
                    nums[j] = kn;
                    nums[j + 1] = kn;
                    j += 2;

                }
                else
                {
                    nums[j] = nums[k];
                    j += 1;
                    k += 1;
                }
            }

            return j;
        }
    }
}
