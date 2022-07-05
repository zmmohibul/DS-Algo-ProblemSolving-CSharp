using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortArrayByIncreasingFrequency
{
    public class Solution
    {
        public int[] FrequencySort(int[] nums) 
        {
            var numFreq = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                numFreq[num] = numFreq.GetValueOrDefault(num, 0) + 1;
            }

            var counts = numFreq.Values.ToArray();
            Array.Sort(counts);
            
            var result = new int[nums.Length];
            int i = 0;

            for (int m = 0; m < counts.Length; m++)
            {
                var l = new List<int>();
                foreach (var (key, value) in numFreq)
                {
                    if (value == counts[m])
                    {
                        for (int k = 0; k < counts[m]; k++)
                        {
                            l.Add(key);
                        }
                    }
                }
                l.Sort();
                for (int j = l.Count - 1; j >= 0; j--)
                {
                    result[i] = l[j];
                    i += 1;
                }
                while (counts[m + 1] == counts[m])
                {
                    m += 1;
                }
            }

            return result;
        }
    }
}