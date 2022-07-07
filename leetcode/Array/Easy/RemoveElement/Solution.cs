using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val) 
        {
            int count = 0;
            var indicesToDelete = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    indicesToDelete.Add(i);
                }
            }
            
            int length = nums.Length;
            int c = 0;
            foreach (var index in indicesToDelete)
            {
                var ind = index - c;
                for (int i = ind + 1; i < length; i++)
                {
                    nums[i - 1] = nums[i];
                }
                length -= 1;
                c += 1;
            }
            
            return length;
        }
    }
}