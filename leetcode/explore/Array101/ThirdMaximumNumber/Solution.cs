using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdMaximumNumber
{
    public class Solution
    {
        public int ThirdMax(int[] nums) 
        {
            var numsHashSet = new HashSet<int>();
            foreach (var num in nums)
            {
                numsHashSet.Add(num);
            }

            int firstMax = 0;
            for (int i = 0; i < 3; i++)
            {
                int max = int.MinValue;
                foreach (var num in numsHashSet)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }

                if (i == 0)
                {
                    firstMax = max;
                }

                numsHashSet.Remove(max);
                if (i == 0 && numsHashSet.Count < 2)
                {
                    return firstMax;
                }

                if (i == 2)
                {
                    return max;
                }
            }

            return 0;
        }
    }
}