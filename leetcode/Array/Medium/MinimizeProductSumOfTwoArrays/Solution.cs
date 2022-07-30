using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimizeProductSumOfTwoArrays
{
    public class Solution
    {
        public int MinProductSum(int[] nums1, int[] nums2) 
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            
            int j = nums2.Length - 1;
            int sum = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                sum = sum + (nums1[i] * nums2[j]);
                j -= 1;
            }
            
            return sum;
        }
    }
}