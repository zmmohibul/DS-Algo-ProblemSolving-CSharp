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
            if (n == 0)
            {
                return;
            }
            if (m == 0)
            {
                for (int x = 0; x < n; x++)
                {
                    nums1[x] = nums2[x];
                }
            }
            
            int i = m -1;
            int j = n - 1;
            int k = nums1.Length - 1;
            
            while (i >= 0 && j >= 0)
            {
                if (nums2[j] >= nums1[i])
                {
                    nums1[k] = nums2[j];
                    j -= 1;
                    k -= 1;
                }
                else
                {
                    nums1[k] = nums1[i];
                    i -= 1;
                    k -= 1;
                }
            }
            
            if (j >= 0)
            {
                while (j >= 0)
                {
                    nums1[k] = nums2[j];
                    j -= 1;
                    k -= 1;
                }
            }


        }
    }
}