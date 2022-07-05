using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n) 
        {
            int i = 0;
            int j = 0;
            var result = new int[m + n];
            int k = 0;
            while (i < m && j < n)
            {
                if (nums1[i] <= nums2[j])
                {
                    result[k] = nums1[i];
                    i += 1;
                    k += 1;
                }
                else
                {
                    result[k] = nums2[j];
                    j += 1;
                    k += 1;
                }
            }

            if (i < m)
            {
                while (i < m)
                {
                    result[k] = nums1[i];
                    i += 1;
                    k += 1;
                }
            }
            else if (j < n)
            {
                while (j < n)
                {
                    result[k] = nums2[j];
                    j += 1;
                    k += 1;
                }
            }

            for (int l = 0; l < result.Length; l++)
            {
                nums1[l] = result[l];
            }
        }
    }
}