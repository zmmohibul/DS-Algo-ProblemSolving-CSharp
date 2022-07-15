using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotateArray
{
    public class Solution
    {
        public void Rotate(int[] nums, int k) 
        {
            var result = new int[nums.Length];
            int i = nums.Length - k;
            for (int j = 0; j < k; j++)
            {
                result[j] = nums[i];
                i += 1;
            }

            i = k;
            int a = 0;
            while (i < nums.Length)
            {
                result[i] = nums[a];
                a += 1;
                i += 1;
            }

            Array.Copy(result, nums, nums.Length);
        }
    }
}