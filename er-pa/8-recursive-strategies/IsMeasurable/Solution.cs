using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsMeasurable
{
    public class Solution
    {
        public bool IsMeasurable(List<int> weights, int target)
        {
            return IsMeasurable(weights, target, 0);
        }

        private bool IsMeasurable(List<int> weights, int target, int i)
        {
            if (i == weights.Count)
            {
                return false;
            }
            
            if (weights[i] == target)
            {
                return true;
            }

            var newTarget1 = target + weights[i];
            var newTarget2 = Math.Max(target, weights[i]) - Math.Min(target, weights[i]);
            var iNext = i + 1;
            return IsMeasurable(weights, target, iNext) || IsMeasurable(weights, newTarget1, iNext) || IsMeasurable(weights, newTarget2, iNext);
        }
    }
}