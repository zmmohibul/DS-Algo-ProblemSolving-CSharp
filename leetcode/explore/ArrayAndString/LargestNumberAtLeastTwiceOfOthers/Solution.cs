using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LargestNumberAtLeastTwiceOfOthers
{
    public class Solution
    {
        public int DominantIndex(int[] nums) 
        {
            if (nums.Length < 2)
            {
                return 0;
            }
            
            var numCopy = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numCopy[i] = nums[i];
            }
            
            Array.Sort(numCopy);
            var largest = numCopy[numCopy.Length - 1];
            var secondLargest = numCopy[numCopy.Length - 2];
            if (secondLargest * 2 <= largest)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == largest)
                    {
                        return i;
                    }
                }
            }
            
            return -1;
        }
    }
}