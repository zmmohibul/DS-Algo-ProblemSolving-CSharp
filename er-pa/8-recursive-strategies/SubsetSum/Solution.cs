using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubsetSum
{
    public class Solution
    {
        public int SubsetSumWays(List<int> numbers, int target)
        {
            return SubsetSumWays(numbers, target, 0, 0);
        }

        public int SubsetSumWays(List<int> numbers, int target, int index, int count)
        {
            if (index == numbers.Count)
            {
                if (target == 0)
                {
                    count += 1;
                }
                return count;
            }
            else
            {
                var num = numbers[index];

                return SubsetSumWays(numbers, target, index + 1, count) + SubsetSumWays(numbers, target - num, index + 1, count);
            }
        }
    }
}