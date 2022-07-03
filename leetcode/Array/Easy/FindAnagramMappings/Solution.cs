using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindAnagramMappings
{
    public class Solution
    {
        public int[] AnagramMappings(int[] nums1, int[] nums2) 
        {
            // Optimized O(n)
            // Intantiate a dictionary nums2Index for mapping index of each number in nums2
            Dictionary<int, int> nums2Index = new Dictionary<int, int>();

            // Iterate over each item in nums2 with index i
            for (int i = 0; i < nums2.Length; i++)
            {
                // Add item to dictionary with value as i
                nums2Index[nums2[i]] = i;
            }

            // Instantiate a result array of length nums1.Length
            int[] result = new int[nums1.Length];

            // Iterate over nums1 with index i 
            for (int i = 0; i < nums1.Length; i++)
            {
                // Insert the value of nums1[i] in nums2Index at result[i]
                result[i] = nums2Index[nums1[i]];
            }

            // Return the result array
            return result;
        }
    }
}