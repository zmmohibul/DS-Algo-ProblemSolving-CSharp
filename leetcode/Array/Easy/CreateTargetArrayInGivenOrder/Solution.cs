using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateTargetArrayInGivenOrder
{
    public class Solution
    {
        public static int[] CreateTargetArray(int[] nums, int[] index) 
        {
            int[] target = new int[index.Length];
            for (int i = 0; i < index.Length; i++)
            {
                int j = index[i];
                int prev = target[j];
                int next;
                target[j] = nums[i];
                j += 1;
                while (j < index.Length)
                {
                    next = target[j];
                    target[j] = prev;
                    prev = next;
                    j += 1;
                }
            }


            return target;     
        }
    }
}