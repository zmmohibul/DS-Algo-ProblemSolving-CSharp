using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubsetSum
{
    public class Solution
    {
        public bool SubsetSum(HashSet<int> numbers, int target)
        {
            if (numbers.Count == 0)
            {
                return target == 0;
            }
            else
            {
                var num = numbers.First();
                numbers.Remove(num);
                return SubsetSum(numbers, target) || SubsetSum(numbers, target - num);
            }
        }

        public int SubsetSumWays(HashSet<int> numbers, int target)
        {
            return SubsetSumWays(numbers, target, 0);
        }

        private int SubsetSumWays(HashSet<int> numbers, int target, int count)
        {
            if (numbers.Count == 0)
            {
                return count;
            }
            else
            {
                var first = numbers.First();
                numbers.Remove(first);
                if (target - first == 0)
                {
                    count += 1;
                }
                var c1 = SubsetSumWays(numbers, target, count);
                var c2 = SubsetSumWays(numbers, target - first, count);
                return c1 + c2;
            }

        }
    }
}