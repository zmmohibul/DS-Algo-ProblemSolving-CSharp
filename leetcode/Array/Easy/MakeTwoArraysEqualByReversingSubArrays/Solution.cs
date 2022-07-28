using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeTwoArraysEqualByReversingSubArrays
{
    public class Solution
    {
        public bool CanBeEqual(int[] target, int[] arr) 
        {
            var targetFreq = new Dictionary<int, int>();
            foreach (var num in target)
            {
                targetFreq[num] = targetFreq.GetValueOrDefault(num, 0) + 1;
            }
            
            var arrFreq = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (!targetFreq.ContainsKey(num))
                {
                    return false;
                }
                
                arrFreq[num] = arrFreq.GetValueOrDefault(num, 0) + 1;
            }
            
            foreach (var (num, count) in arrFreq)
            {
                if (targetFreq.ContainsKey(num) && targetFreq[num] != count)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}